using System;
using System.Collections.Generic;
using Codisa.InterwayDocs.Business;
using Codisa.InterwayDocs.Framework;
using Codisa.InterwayDocs.Properties;
using MvvmFx.CaliburnMicro;
using MvvmFx.Bindings.Data;
using Binding = MvvmFx.Bindings.Data.Binding;

namespace Codisa.InterwayDocs.Outgoing
{
    public partial class OutgoingDetailView : DetailViewBase, IHaveDataContext
    {
        #region Fields and properties

        private bool _isBindingSet;

        #endregion

        #region Initializers

        public OutgoingDetailView()
        {
            Visible = false;
            InitializeComponent();
            StandardViewHeight = Height;
            //model_RegisterDate.Focus();

            AlwaysVisibleElements = new List<string>();
            AlwaysVisibleElements.Add(whenEmptyCreateRegister.Name);
            AlwaysVisibleElements.Add(detailToolStrip.Name);
            AlwaysVisibleElements.Add(createRegister.Name);
            AlwaysVisibleElements.Add(editDetail.Name);
            AlwaysVisibleElements.Add(cancel.Name);
            AlwaysVisibleElements.Add(save.Name);
            AlwaysVisibleElements.Add(printDetail.Name);
            AlwaysVisibleElements.Add(toggleDetailPanel.Name);

            BaseDetailToolStrip = detailToolStrip;
            BaseToggleDetailPanel = toggleDetailPanel;
            BaseWhenEmptyCreateRegister = whenEmptyCreateRegister;
        }

        #endregion

        #region IHaveDataContext implementation

        public event EventHandler<DataContextChangedEventArgs> DataContextChanged = delegate { };

        public object DataContext
        {
            get { return ViewModel; }
            set
            {
                if (value != ViewModel)
                {
                    var viewModel = value as OutgoingDetailViewModel;
                    if (viewModel != null)
                    {
                        IsNotifying = true;

                        ViewModel = viewModel;
                        ParentViewModel = viewModel.ParentViewModel;
                        if (ParentViewModel.RootViewModel.UseLongNameEntities)
                        {
                            model_DocumentEntity.MaxLength = 150;
                            model_DocumentDept.MaxLength = 150;
                            model_RecipientName.MaxLength = 150;
                        }

                        if (viewModel.Model.RegisterId != 0)
                        {
                            SetConfiguration();
                            Bind();
                            DataContextChanged(this, new DataContextChangedEventArgs());
                            Visible = true;
                        }
                    }
                }
            }
        }

        private void Bind()
        {
            if (_isBindingSet)
                return;

            BindingManager.BindOnValidation = true;

            var binding = new Binding();
            binding.SourceObject = ViewModel;
            binding.SourcePath = "DisplayName";
            binding.TargetObject = panelTitle;
            binding.TargetPath = "Text";
            binding.Mode = BindingMode.OneWayToTarget;
            BindingManager.Bindings.Add(binding);

            var bindingRegisterId = new Binding();
            bindingRegisterId.SourceObject = ViewModel;
            bindingRegisterId.SourcePath = "DisplayName";
            bindingRegisterId.TargetObject = registerId;
            bindingRegisterId.TargetPath = "Text";
            bindingRegisterId.Mode = BindingMode.OneWayToTarget;
            BindingManager.Bindings.Add(bindingRegisterId);

            BindText(model_RegisterDate);
            BindText(model_DocumentType);
            BindText(model_DocumentReference);
            BindText(model_DocumentEntity);
            BindText(model_DocumentDept);
            BindText(model_DocumentClass);
            BindText(model_DocumentDate);
            BindText(model_Subject);
            BindText(model_SendDate);
            BindText(model_RecipientName);
            BindText(model_RecipientTown);
            BindText(model_ArchiveLocation);
            BindText(model_Notes);

            errorWarnInfoProvider.DataSource = ViewModel.Model;

            BindFormReadOnly();
            BindTextBoxReadOnly(model_RegisterDate);
            BindTextBoxReadOnly(model_DocumentType);
            BindTextBoxReadOnly(model_DocumentReference);
            BindTextBoxReadOnly(model_DocumentEntity);
            BindTextBoxReadOnly(model_DocumentDept);
            BindTextBoxReadOnly(model_DocumentClass);
            BindTextBoxReadOnly(model_DocumentDate);
            BindTextBoxReadOnly(model_Subject);
            BindTextBoxReadOnly(model_SendDate);
            BindTextBoxReadOnly(model_RecipientName);
            BindTextBoxReadOnly(model_RecipientTown);
            BindTextBoxReadOnly(model_ArchiveLocation);
            BindTextBoxReadOnly(model_Notes);

            _isBindingSet = true;
        }

        private void SetConfiguration()
        {
            var iHaveConfigurationList = ViewModel as IHaveConfigurationList;
            if (iHaveConfigurationList != null)
            {
                var configurationList = iHaveConfigurationList.ConfigurationList;

                Helper.SetElementConfiguration(registerDateLabel, configurationList);
                Helper.SetElementConfiguration(model_RegisterDate, configurationList);
                Helper.SetElementConfiguration(documentTypeLabel, configurationList);
                Helper.SetElementConfiguration(model_DocumentType, configurationList);
                Helper.SetElementConfiguration(documentReferenceLabel, configurationList);
                Helper.SetElementConfiguration(model_DocumentReference, configurationList);
                Helper.SetElementConfiguration(documentEntityLabel, configurationList);
                Helper.SetElementConfiguration(model_DocumentEntity, configurationList);
                Helper.SetElementConfiguration(documentDeptLabel, configurationList);
                Helper.SetElementConfiguration(model_DocumentDept, configurationList);
                Helper.SetElementConfiguration(documentClassLabel, configurationList);
                Helper.SetElementConfiguration(model_DocumentClass, configurationList);
                Helper.SetElementConfiguration(documentDateLabel, configurationList);
                Helper.SetElementConfiguration(model_DocumentDate, configurationList);
                Helper.SetElementConfiguration(subjectLabel, configurationList);
                Helper.SetElementConfiguration(model_Subject, configurationList);
                Helper.SetElementConfiguration(sendDateLabel, configurationList);
                Helper.SetElementConfiguration(model_SendDate, configurationList);
                Helper.SetElementConfiguration(recipientNameLabel, configurationList);
                Helper.SetElementConfiguration(model_RecipientName, configurationList);
                Helper.SetElementConfiguration(recipientTownLabel, configurationList);
                Helper.SetElementConfiguration(model_RecipientTown, configurationList);
                Helper.SetElementConfiguration(notesLabel, configurationList);
                Helper.SetElementConfiguration(model_Notes, configurationList);
                Helper.SetElementConfiguration(model_ArchiveLocation, configurationList);
                Helper.SetElementConfiguration(archiveLocationLabel, configurationList);
            }
        }

        #endregion

        #region Translations

        public override void RefreshTranslation()
        {
            base.RefreshTranslation();

            SetConfiguration();

            toggleDetailPanel.ToolTipText = Resources.ToolTipHideDetail;
            printDetail.ToolTipText = Resources.ToolTipExportRegisterExcel;
            cancel.ToolTipText = Resources.ToolTipCancel;
            save.ToolTipText = Resources.ToolTipSave;
            editDetail.ToolTipText = Resources.ToolTipEdit;
            createRegister.ToolTipText = Resources.ToolTipNew;
            toolTip.SetToolTip(registerDateLabel, Resources.ToolTipRegisterDate);
            documentGroup.Text = Resources.LabelDocument;
            toolTip.SetToolTip(documentTypeLabel, Resources.ToolTipDocumentType);
            toolTip.SetToolTip(documentReferenceLabel, Resources.ToolTipDocumentNumber);
            toolTip.SetToolTip(documentEntityLabel, Resources.ToolTipDocumentEntity);
            toolTip.SetToolTip(documentDeptLabel, Resources.ToolTipDocumentDept);
            toolTip.SetToolTip(documentClassLabel, Resources.ToolTipDocumentClass);
            toolTip.SetToolTip(documentDateLabel, Resources.ToolTipDocumentDate);
            toolTip.SetToolTip(subjectLabel, Resources.ToolTipSubject);
            toolTip.SetToolTip(sendDateLabel, Resources.ToolTipSendDate);
            toolTip.SetToolTip(recipientNameLabel, Resources.ToolTipRecipientName);
            toolTip.SetToolTip(recipientTownLabel, Resources.ToolTipRecipientTown);
            archiveLocationLabel.Text = Resources.LabelArchiveLocation;
            toolTip.SetToolTip(archiveLocationLabel, Resources.ToolTipLocation);
            whenEmptyCreateRegister.Text = Resources.LabelClickCreateIncoming;
        }

        #endregion
    }
}