using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
#if WISEJ
using Wisej.Base;
using Wisej.Web;
using MvvmFx.CaliburnMicro.WisejWeb.Toolable;
using FormsBinding = Wisej.Web.Binding;
#else
using System.Windows.Forms;
using FormsBinding = System.Windows.Forms.Binding;
#endif
using Codisa.InterwayDocs.Properties;
using MvvmFx.CaliburnMicro;
using MvvmFx.Bindings.Data;

namespace Codisa.InterwayDocs.Framework
{
    public class BookViewBase : UserControl, INotifyPropertyChangedEx, IBookView
    {
        #region Fields and properties

        private Control _lastActiveControl;
        private bool _isFocusing;

        protected readonly BindingManager BindingManager = new BindingManager();
        protected IBookViewModel ViewModel;
        protected IMainFormViewModel RootViewModel;

        protected DataGridView baseDataGridView;
#if WISEJ
        protected PanelEx baselistNavigator;
#endif
        protected ContentContainer baseActiveItem;
        protected Button baseSearch;
        protected Button baseToggleSearchArea;
        protected TextBox baseCriteria_FullText;
        protected ToolTip baseToolTip;
        protected Panel baseSearchPanel;

        private DataGridViewCellStyle _currentCellStyle;
#if WINFORMS
        private DataGridViewCellStyle _highlightCellStyle;
#endif

        private int _rowId;

        public int RowId
        {
            get { return _rowId; }
            set
            {
                if (_rowId != value)
                {
#if WINFORMS
                    baseDataGridView.EnableHeadersVisualStyles = true;
#endif
                    _rowId = value;
                    if (_rowId < 0)
                        baseDataGridView.ClearSelection();
                    else
                    {
                        baseDataGridView.DefaultCellStyle = _currentCellStyle;
                        var row = FindRow(_rowId);
                        if (row != null)
                        {
                            row.Cells[0].Selected = true;
                            row.Selected = true;
                        }
                    }

                    NotifyOfPropertyChange("RowId");
                }
            }
        }

        private DataGridViewRow FindRow(int rowId)
        {
            return baseDataGridView.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells.Count > 0)
                .FirstOrDefault(row => row.Cells[0].Value.ToString() == rowId.ToString());
        }

        #endregion

        #region Helpers

        public void CancelClose(bool doClose, int rowId)
        {
            if (doClose)
            {
                var previousRowId = _rowId;
                _rowId = -1;
                RowId = previousRowId;
            }
            else if (_rowId == -1)
            {
#if WINFORMS
                baseDataGridView.EnableHeadersVisualStyles = false;
#endif
            }
            else if (rowId != _rowId)
            {
#if WINFORMS
                baseDataGridView.DefaultCellStyle = _highlightCellStyle;
#endif
            }
        }

        #endregion

        #region Commmun event handlers

        protected void ForceValidation(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        protected void ViewBaseLoad(object sender, EventArgs e)
        {
            Load -= ViewBaseLoad;

            _currentCellStyle = baseDataGridView.DefaultCellStyle;
#if WINFORMS
            _highlightCellStyle = new DataGridViewCellStyle {SelectionBackColor = Color.Red};
#endif

            _lastActiveControl = baseCriteria_FullText;

            if (baseSearchPanel.Visible)
            {
                SetFocusAndAcceptButton();
            }

            baseDataGridView.Resize += BaseDataGridViewResize;
        }

        private void BaseDataGridViewResize(object sender, EventArgs e)
        {
#if WISEJ
            ParentForm.Update();
            //ApplicationBase.Update(ParentForm);
#endif

            ShowSelectRow();
        }

        protected void DataGridViewSelectionChanged(object sender, EventArgs e)
        {
            var grid = (DataGridView) sender;
            if (grid.SelectedRows.Count > 0)
            {
                if (grid.SelectedRows[0].Cells.Count > 0)
                {
                    var stringId = grid.SelectedRows[0].Cells[0].Value.ToString();
                    RowId = Convert.ToInt32(stringId, 10);
                }
            }
        }

        protected void StoreLastActiveControl(object sender, EventArgs e)
        {
            if (_isFocusing)
                return;

            _lastActiveControl = sender as Control;
        }

        #endregion

        #region Binding helpers

        protected void RebindText(TextBox text)
        {
            text.DataBindings.Clear();
            BindText(text);
        }

        protected void BindText(TextBox text)
        {
            var propertyOnViewModel = text.Name;

            var criteriaPrefix = "criteria_";
            var modelPrefix = "model_";
            if (propertyOnViewModel.StartsWith(criteriaPrefix))
            {
                propertyOnViewModel = propertyOnViewModel.Substring(criteriaPrefix.Length);
                text.DataBindings.Add(new FormsBinding("Text", ViewModel.Criteria, propertyOnViewModel));
            }
            else if (propertyOnViewModel.StartsWith(modelPrefix))
            {
                propertyOnViewModel = propertyOnViewModel.Substring(modelPrefix.Length);
                text.DataBindings.Add(new FormsBinding("Text", ViewModel.Model, propertyOnViewModel));
            }
            else
            {
                text.DataBindings.Add(new FormsBinding("Text", ViewModel, propertyOnViewModel));
            }
        }

        #endregion

        #region Layout area methods

        public void ShowSearchArea()
        {
            if (RootViewModel != null)
            {
                if (!baseSearchPanel.Visible)
                    ToggleSearchArea();
            }
        }

        public void ToggleSearchArea()
        {
            if (RootViewModel != null)
            {
                if (baseSearchPanel.Visible)
                {
                    // hide

                    baseToolTip.SetToolTip(baseToggleSearchArea, Resources.ToolTipShowSearchPanel);
                    baseToggleSearchArea.Image = Resources.ArrowDown16;

                    // TODO: the following properties should be bound.
                    baseSearchPanel.Visible = false;
                    RootViewModel.IsSearchPanelOpen = false;
                }
                else
                {
                    // show

                    baseToolTip.SetToolTip(baseToggleSearchArea, Resources.HideSearchPanel);
                    baseToggleSearchArea.Image = Resources.ArrowUp16;

                    // TODO: the following properties should be bound.
                    baseSearchPanel.Visible = true;
                    RootViewModel.IsSearchPanelOpen = true;

                    SetFocusAndAcceptButton();
                    ShowSelectRow();
                }
            }
        }

        private void SetFocusAndAcceptButton()
        {
            _isFocusing = true;

            _lastActiveControl.Focus();

            if (ParentForm != null)
                ParentForm.AcceptButton = baseSearch;

            _isFocusing = false;
        }

        internal void ListResize(int panelSize, int baseItemHeight)
        {
            baseActiveItem.Size = new Size(baseActiveItem.Width, baseItemHeight);
            ShowSelectRow();
        }

        private void ShowSelectRow()
        {
            if (baseDataGridView.SelectedRows.Count == 0)
                return;

#if WISEJ
            //ParentForm.Update();
            Update();
            baseDataGridView.Update();
            //ApplicationBase.Update(ParentForm);
            ApplicationBase.Update(this);
            ApplicationBase.Update(baseDataGridView);
            baseDataGridView.ScrollCellIntoView(0, baseDataGridView.SelectedRows[0].Index);
#else
            if (baseDataGridView.SelectedRows[0].Displayed)
                return;

            ScrollGrid();
#endif
        }

#if WINFORMS
        private void ScrollGrid()
        {
            int halfWay = baseDataGridView.DisplayedRowCount(false) / 2;
            if (baseDataGridView.FirstDisplayedScrollingRowIndex + halfWay > baseDataGridView.SelectedRows[0].Index ||
                baseDataGridView.FirstDisplayedScrollingRowIndex + baseDataGridView.DisplayedRowCount(false) -
                halfWay <= baseDataGridView.SelectedRows[0].Index)
            {
                int targetRow = baseDataGridView.SelectedRows[0].Index;

                targetRow = Math.Max(targetRow - halfWay, 0);
                baseDataGridView.FirstDisplayedScrollingRowIndex = targetRow;
            }
        }
#endif

        #endregion

        #region Translations

        public virtual void RefreshTranslation()
        {
            if (RootViewModel != null)
            {
                if (baseSearchPanel.Visible)
                    baseToolTip.SetToolTip(baseToggleSearchArea, Resources.ToolTipShowSearchPanel);
                else
                    baseToolTip.SetToolTip(baseToggleSearchArea, Resources.HideSearchPanel);
            }
        }

        #endregion

        #region INotifyPropertyChangedEx implementation

        /// <summary>
        ///   Occurs when a property value changes.
        /// </summary>
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        [field: NonSerialized] private bool _isNotifying; //serializator try to serialize even autogenerated fields

        /// <summary>
        ///   Enables/Disables property change notification.
        /// </summary>
        [Browsable(false)]
        public bool IsNotifying
        {
            get { return _isNotifying; }
            set { _isNotifying = value; }
        }

        /// <summary>
        ///   Raises a change notification indicating that all bindings should be refreshed.
        /// </summary>
        public new void Refresh()
        {
            NotifyOfPropertyChange(string.Empty);
            base.Refresh();
        }

        /// <summary>
        ///   Notifies subscribers of the property change.
        /// </summary>
        /// <param name = "propertyName">Name of the property.</param>
        public virtual void NotifyOfPropertyChange(string propertyName)
        {
            if (IsNotifying)
            {
                Execute.OnUIThread(() => RaisePropertyChangedEventCore(propertyName));
            }
        }

        /// <summary>
        ///   Notifies subscribers of the property change.
        /// </summary>
        /// <typeparam name = "TProperty">The type of the property.</typeparam>
        /// <param name = "property">The property expression.</param>
        public virtual void NotifyOfPropertyChange<TProperty>(Expression<Func<TProperty>> property)
        {
            NotifyOfPropertyChange(property.GetMemberInfo().Name);
        }

        /// <summary>
        ///   Raises the property changed event immediately.
        /// </summary>
        /// <param name = "propertyName">Name of the property.</param>
        public virtual void RaisePropertyChangedEventImmediately(string propertyName)
        {
            if (IsNotifying)
            {
                RaisePropertyChangedEventCore(propertyName);
            }
        }

        private void RaisePropertyChangedEventCore(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Called when the object is deserialized.
        /// </summary>
        /// <param name="c">The streaming context.</param>
        [OnDeserialized]
        public void OnDeserialized(StreamingContext c)
        {
            IsNotifying = true;
        }

        /// <summary>
        /// Used to indicate whether or not the IsNotifying property is serialized to Xml.
        /// </summary>
        /// <returns>Whether or not to serialize the IsNotifying property. The default is false.</returns>
        public virtual bool ShouldSerializeIsNotifying()
        {
            return false;
        }

        #endregion
    }
}