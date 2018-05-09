using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.Serialization;
#if WISEJ
using Wisej.Web;
using FormsBinding = Wisej.Web.Binding;
using ToolStrip = Wisej.Web.ToolBar;
using ToolStripButton = Wisej.Web.ToolBarButton;
using ToolStripItemProxy = MvvmFx.CaliburnMicro.ComponentHandlers.ToolBarButtonProxy;
#else
using System.Windows.Forms;
using FormsBinding = System.Windows.Forms.Binding;
using ToolStripItemProxy = MvvmFx.CaliburnMicro.ComponentHandlers.ToolStripItemProxy;
#endif
using Codisa.InterwayDocs.Properties;
using MvvmFx.CaliburnMicro;
using MvvmFx.Bindings.Data;
using Binding = MvvmFx.Bindings.Data.Binding;

namespace Codisa.InterwayDocs.Framework
{
    public class DetailViewBase : UserControl, INotifyPropertyChangedEx, IDetailView
    {
        #region Fields and properties

        protected int StandardViewHeight;

        protected readonly BindingManager BindingManager = new BindingManager();
        protected IHaveModel ViewModel;
        protected IBookViewModel ParentViewModel;
#if WINFORMS
        protected ToolStrip BaseDetailToolStrip;
        protected ToolStripButton BaseToggleDetailPanel;
#else
        protected MvvmFx.CaliburnMicro.WisejWeb.Toolable.PanelEx BaseDetailPanel;
        protected MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx BaseToggleDetailPanel;
        protected CslaContrib.WisejWeb.ErrorWarnInfoProvider BaseErrorWarnInfoProvider;
#endif
        protected Button BaseWhenEmptyCreateRegister;

        public List<Control> NamedElements { get; set; }

        protected List<string> AlwaysVisibleElements { get; set; }

        private bool _readOnly = true;

        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                if (_readOnly != value)
                {
                    _readOnly = value;
                    SetBackColor();
                    NotifyOfPropertyChange("ReadOnly");
                }
            }
        }

        #endregion

        #region Helpers

        protected void BindText(TextBox text)
        {
            var propertyOnViewModel = text.Name;

            var modelPrefix = "model_";
            if (propertyOnViewModel.StartsWith(modelPrefix))
            {
                propertyOnViewModel = propertyOnViewModel.Substring(modelPrefix.Length);
                text.DataBindings.Add(new FormsBinding("Text", ViewModel.Model, propertyOnViewModel));
            }
            else
            {
                text.DataBindings.Add(new FormsBinding("Text", ViewModel, propertyOnViewModel));
            }
        }

        protected void BindFormReadOnly()
        {
            BindingManager.Bindings.Add(new Binding(this, "ReadOnly", ViewModel.Model, "IsReadOnly")
            {
                //BindOnValidation = true,
                //Converter = new IsReadOnlyConverter(),
                Mode = BindingMode.OneWayToTarget
            });
        }

        protected void BindTextBoxReadOnly(TextBox textBox)
        {
            BindingManager.Bindings.Add(new Binding(textBox, "ReadOnly", ViewModel.Model, "IsReadOnly")
            {
                //BindOnValidation = true,
                //Converter = new IsReadOnlyConverter(),
                Mode = BindingMode.OneWayToTarget
            });
        }

        protected void SetBackColor()
        {
            BackColor = ReadOnly
                ? System.Drawing.Color.FromArgb(255, 255, 192)
                : System.Drawing.Color.FromArgb(192, 192, 255);
        }

        public void ShowEmptyRegister()
        {
#if WISEJ
            BaseErrorWarnInfoProvider.Clear();
#endif
            ReadOnly = true;
            foreach (var control in NamedElements)
            {
                if (AlwaysVisibleElements.Contains(control.Name))
                    control.Visible = true;
                else
                {
                    if (control is ToolStripItemProxy)
                        control.Visible = true;
                    control.Visible = false;
                }
            }

            Visible = true;
        }

        #endregion

        #region Commmun event handlers

        protected void ForceValidation(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        #endregion

        #region Layout area methods

        public void ToggleDetailPanel()
        {
            ParentViewModel.IsDetailPanelOpen = !ParentViewModel.IsDetailPanelOpen;
            SetSizeDetailPanel();
        }

        public void SetSizeDetailPanel()
        {
            var bookViewBase = ParentViewModel.GetView() as BookViewBase;
            if (bookViewBase != null)
            {
#if WINFORMS
                var toolStripHeight = BaseDetailToolStrip.Height;
#else
                var toolStripHeight = BaseDetailPanel.HeaderSize;
#endif
                if (ParentViewModel.IsDetailPanelOpen)
                {
                    // show

                    BaseToggleDetailPanel.ToolTipText = Resources.ToolTipHideDetail;
                    BaseToggleDetailPanel.Image = Resources.ArrowDown16;

                    if (!ParentViewModel.IsDetailPanelStateOpen)
                    {
                        ParentViewModel.IsDetailPanelStateOpen = true;
                        bookViewBase.ListResize(-StandardViewHeight + toolStripHeight, StandardViewHeight);
                    }
                }
                else
                {
                    // hide

                    BaseToggleDetailPanel.ToolTipText = Resources.ToolTipShowDetailPanel;
                    BaseToggleDetailPanel.Image = Resources.ArrowUp16;

                    if (ParentViewModel.IsDetailPanelStateOpen)
                    {
                        ParentViewModel.IsDetailPanelStateOpen = false;
                        bookViewBase.ListResize(+StandardViewHeight - toolStripHeight, toolStripHeight);
                    }
                }
            }
        }

        #endregion

        #region Translations

        public virtual void RefreshTranslation()
        {
            BaseToggleDetailPanel.ToolTipText = Resources.ToolTipHideDetail;
            BaseToggleDetailPanel.ToolTipText = Resources.ToolTipShowDetailPanel;
        }

        #endregion

        #region INotifyPropertyChangedEx implementation

        /// <summary>
        ///   Occurs when a property value changes.
        /// </summary>
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        [field: NonSerialized]
        private bool _isNotifying; //serializator try to serialize even autogenerated fields

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