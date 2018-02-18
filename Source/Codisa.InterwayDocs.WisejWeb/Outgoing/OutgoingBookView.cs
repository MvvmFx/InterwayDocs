using System;
using Codisa.InterwayDocs.Business;
using Codisa.InterwayDocs.Business.SearchObjects;
using Codisa.InterwayDocs.Framework;
using Codisa.InterwayDocs.Properties;
using MvvmFx.CaliburnMicro;
using MvvmFx.Bindings.Data;
using Binding = MvvmFx.Bindings.Data.Binding;
using FormsBinding = Wisej.Web.Binding;

namespace Codisa.InterwayDocs.Outgoing
{
    public partial class OutgoingBookView : BookViewBase, IHaveDataContext
    {
        #region Fields and properties

        private bool _isBindingSet;

        #endregion

        #region Initializers

        public OutgoingBookView()
        {
            InitializeComponent();

            baseDataGridView = dataGridView;
            baselistNavigator = listNavigator;
            baseActiveItem = activeItem;
            baseSearch = search;
            baseToggleSearchArea = toggleSearchArea;
            baseCriteria_FullText = criteria_FullText;
            baseToolTip = toolTip;
            baseSearchPanel = searchPanel;

            Load += ViewBaseLoad;

            dataGridView.SelectionChanged += DataGridViewSelectionChanged;
        }

        #endregion

        #region IHaveDataContext implementation

        public event EventHandler<DataContextChangedEventArgs> DataContextChanged = delegate { };

        public object DataContext
        {
            get { return ViewModel; }
            set
            {
                var viewModel = value as OutgoingBookViewModel;
                if (viewModel != null)
                {
                    IsNotifying = true;

                    ViewModel = viewModel;

                    RootViewModel = viewModel.RootViewModel;

                    SetConfiguration();
                    BindOnce();
                    Rebind();

                    DataContextChanged(this, new DataContextChangedEventArgs());
                }
            }
        }

        private void Rebind()
        {
            dataGridView.DataSource = ViewModel.Model;
            errorWarnInfoProvider.DataSource = ViewModel.Criteria;
        }

        private void BindOnce()
        {
            if (_isBindingSet)
                return;

            search.DataBindings.Add(new FormsBinding("Enabled", ViewModel.Criteria, "IsValid"));

            fastDate.DataSource = FastDateOptionList.GetFastDateOptionList(FastDateOptionsFacade.Instance);
            fastDate.ValueMember = "FastDateOptionName";
            fastDate.DisplayMember = "FastDateOptionDescription";
            fastDate.SelectedIndex = 0;

            dateType.DataSource = ViewModel.Criteria.DateTypeList;
            dateType.ValueMember = "DateTypeName";
            dateType.DisplayMember = "DateTypeDescription";
            dateType.SelectedIndex = 0;

            //BindingManager.BindOnValidation = true;

            // as it is, it will select the first item of the list

            // comment to start with no item selected
            var gridBinding = new Binding();
            gridBinding.SourceObject = ViewModel;
            gridBinding.SourcePath = "ListItemId";
            gridBinding.TargetObject = this;
            gridBinding.TargetPath = "RowId";
            gridBinding.Mode = BindingMode.TwoWay;
            BindingManager.Bindings.Add(gridBinding);

            // uncomment to start with no item selected
            /*listBox1.ClearSelected();

            var binding = new Binding();
            binding.SourceObject = ViewModel;
            binding.SourcePath = "ListItemId";
            binding.TargetObject = listBox1;
            binding.TargetPath = "RowId";
            binding.Mode = BindingMode.TwoWay;
            BindingManager.Bindings.Add(binding);*/

            var bindingDisplayName = new Binding();
            bindingDisplayName.SourceObject = ViewModel;
            bindingDisplayName.SourcePath = "DisplayName";
            bindingDisplayName.TargetObject = listNavigator;
            bindingDisplayName.TargetPath = "Text";
            bindingDisplayName.Mode = BindingMode.OneWayToTarget;
            BindingManager.Bindings.Add(bindingDisplayName);

            BindText(criteria_FullText);
            BindText(criteria_ArchiveLocation);
            BindText(criteria_StartDate);
            BindText(criteria_EndDate);

            _isBindingSet = true;
        }

        private void SetConfiguration()
        {
            var iHaveConfigurationList = ViewModel as IHaveConfigurationList;
            if (iHaveConfigurationList != null)
            {
                var configurationList = iHaveConfigurationList.ConfigurationList;

                Helper.SetElementConfiguration(registerIdDataGridViewTextBoxColumn, configurationList);
                Helper.SetElementConfiguration(registerDateDataGridViewTextBoxColumn, configurationList);
                Helper.SetElementConfiguration(documentTypeDataGridViewTextBoxColumn, configurationList);
                Helper.SetElementConfiguration(documentReferenceDataGridViewTextBoxColumn, configurationList);
                Helper.SetElementConfiguration(documentEntityDataGridViewTextBoxColumn, configurationList);
                Helper.SetElementConfiguration(documentDeptDataGridViewTextBoxColumn, configurationList);
                Helper.SetElementConfiguration(documentClassDataGridViewTextBoxColumn, configurationList);
                Helper.SetElementConfiguration(documentDateDataGridViewTextBoxColumn, configurationList);
                Helper.SetElementConfiguration(subjectDataGridViewTextBoxColumn, configurationList);
                Helper.SetElementConfiguration(recipientNameDataGridViewTextBoxColumn, configurationList);
                Helper.SetElementConfiguration(sendDateDataGridViewTextBoxColumn, configurationList);
                Helper.SetElementConfiguration(recipientTownDataGridViewTextBoxColumn, configurationList);
            }
        }

        #endregion

        #region Translations

        public override void RefreshTranslation()
        {
            base.RefreshTranslation();

            SetConfiguration();

            errorWarnInfoProvider.DataSource = ViewModel.Criteria;
            search.DataBindings.Clear();
            search.DataBindings.Add(new FormsBinding("Enabled", ViewModel.Criteria, "IsValid"));

            fastDate.DataSource = FastDateOptionList.GetFastDateOptionList(FastDateOptionsFacade.Instance);
            dateType.DataSource = ViewModel.Criteria.DateTypeList;

            RebindText(criteria_FullText);
            RebindText(criteria_ArchiveLocation);
            RebindText(criteria_StartDate);
            RebindText(criteria_EndDate);

            toolTip.SetToolTip(fastDate, Resources.FastDateToolTip);
            fullTextLabel.Text = Resources.LabelFullText;
            toolTip.SetToolTip(fullTextLabel, Resources.ToolTipFullText);
            archiveLocationLabel.Text = Resources.LabelArchiveLocation;
            toolTip.SetToolTip(archiveLocationLabel, Resources.ToolTipLocation);
            dateTypeLabel.Text = Resources.LabelDates;
            toolTip.SetToolTip(dateTypeLabel, Resources.ToolTipDates);
            startDateLabel.Text = Resources.LabelStartDate;
            toolTip.SetToolTip(startDateLabel, Resources.ToolTipStartDate);
            endDateLabel.Text = Resources.LabelEndDate;
            toolTip.SetToolTip(endDateLabel, Resources.ToolTipEndDate);
            search.Text = Resources.LabelSearch;
            printList.ToolTipText = Resources.ToolTipExportListExcel;
        }

        #endregion
    }
}