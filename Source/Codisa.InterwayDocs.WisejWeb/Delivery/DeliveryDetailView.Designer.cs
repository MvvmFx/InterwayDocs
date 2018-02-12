namespace Codisa.InterwayDocs.Delivery
{
    partial class DeliveryDetailView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.detailPanel = new CaliburnMicro.WisejWeb.PanelEx.PanelEx();
            this.toggleDetailPanel = new CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx();
            this.printDetail = new CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx();
            this.cancel = new CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx();
            this.save = new CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx();
            this.editDetail = new CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx();
            this.createRegister = new CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx();
            this.registerId = new Wisej.Web.Label();
            this.registerDateLabel = new Wisej.Web.Label();
            this.model_RegisterDate = new Wisej.Web.TextBox();
            this.documentGroup = new Wisej.Web.GroupBox();
            this.verticalDivider1 = new Wisej.Web.Label();
            this.documentTypeLabel = new Wisej.Web.Label();
            this.model_DocumentType = new Wisej.Web.TextBox();
            this.documentReferenceLabel = new Wisej.Web.Label();
            this.model_DocumentReference = new Wisej.Web.TextBox();
            this.documentEntityLabel = new Wisej.Web.Label();
            this.model_DocumentEntity = new Wisej.Web.TextBox();
            this.documentDeptLabel = new Wisej.Web.Label();
            this.model_DocumentDept = new Wisej.Web.TextBox();
            this.recipientNameLabel = new Wisej.Web.Label();
            this.model_RecipientName = new Wisej.Web.TextBox();
            this.documentClassLabel = new Wisej.Web.Label();
            this.model_DocumentClass = new Wisej.Web.TextBox();
            this.documentDateLabel = new Wisej.Web.Label();
            this.model_DocumentDate = new Wisej.Web.TextBox();
            this.expeditorNameLabel = new Wisej.Web.Label();
            this.model_ExpeditorName = new Wisej.Web.TextBox();
            this.receptionNameLabel = new Wisej.Web.Label();
            this.model_ReceptionName = new Wisej.Web.TextBox();
            this.receptionDateLabel = new Wisej.Web.Label();
            this.model_ReceptionDate = new Wisej.Web.TextBox();
            this.audit = new Wisej.Web.Label();
            this.toolTip = new Wisej.Web.ToolTip(this.components);
            this.errorWarnInfoProvider = new CslaContrib.WisejWeb.ErrorWarnInfoProvider(this.components);
            this.verticalDivider2 = new Wisej.Web.Label();
            this.whenEmptyCreateRegister = new Wisej.Web.Button();
            this.detailPanel.SuspendLayout();
            this.documentGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorWarnInfoProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // detailPanel
            // 
            this.detailPanel.Dock = Wisej.Web.DockStyle.Fill;
            this.detailPanel.Tools.AddRange(new CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx[] {
            this.createRegister,
            this.editDetail,
            this.save,
            this.cancel,
            this.printDetail,
            this.toggleDetailPanel});
            this.detailPanel.HeaderBackColor = System.Drawing.Color.FromName("@toolbar");
            this.detailPanel.HeaderForeColor = System.Drawing.Color.FromName("@toolbarText");
            this.detailPanel.Location = new System.Drawing.Point(0, 0);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Text = "detailPanel";
            this.detailPanel.ShowCloseButton = false;
            this.detailPanel.ShowHeader = true;
            this.detailPanel.Size = new System.Drawing.Size(1008, 25);
            // 
            // toggleDetailPanel
            // 
            this.toggleDetailPanel.Image = global::Codisa.InterwayDocs.Properties.Resources.ArrowDown16;
            this.toggleDetailPanel.Name = "toggleDetailPanel";
            this.toggleDetailPanel.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipHideDetail;
            // 
            // printDetail
            // 
            this.printDetail.Image = global::Codisa.InterwayDocs.Properties.Resources.Excel;
            this.printDetail.Name = "printDetail";
            this.printDetail.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipExportRegisterExcel;
            // 
            // cancel
            // 
            this.cancel.Image = global::Codisa.InterwayDocs.Properties.Resources.Delete16;
            this.cancel.Name = "cancel";
            this.cancel.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipCancel;
            // 
            // save
            // 
            this.save.Image = global::Codisa.InterwayDocs.Properties.Resources.Save16;
            this.save.Name = "save";
            this.save.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipSave;
            // 
            // editDetail
            // 
            this.editDetail.Image = global::Codisa.InterwayDocs.Properties.Resources.Edit16;
            this.editDetail.Name = "editDetail";
            this.editDetail.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipEdit;
            // 
            // createRegister
            // 
            this.createRegister.Image = global::Codisa.InterwayDocs.Properties.Resources.AddNew16;
            this.createRegister.Name = "createRegister";
            this.createRegister.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipNew;
            // 
            // registerId
            // 
            this.registerId.AutoSize = true;
            this.registerId.Location = new System.Drawing.Point(13, 34);
            this.registerId.Name = "registerId";
            this.registerId.Size = new System.Drawing.Size(104, 13);
            this.registerId.Text = "Nº de Registo ####";
            // 
            // model_RegisterDate
            // 
            this.model_RegisterDate.Location = new System.Drawing.Point(391, 31);
            this.model_RegisterDate.MaxLength = 10;
            this.model_RegisterDate.Name = "model_RegisterDate";
            this.model_RegisterDate.Size = new System.Drawing.Size(65, 20);
            this.model_RegisterDate.TabIndex = 1;
            // 
            // registerDateLabel
            // 
            this.registerDateLabel.AutoSize = true;
            this.registerDateLabel.Location = new System.Drawing.Point(308, 34);
            this.registerDateLabel.Name = "registerDateLabel";
            this.registerDateLabel.Size = new System.Drawing.Size(79, 13);
            this.registerDateLabel.Text = "Data de registo";
            this.toolTip.SetToolTip(this.registerDateLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipRegisterDate);
            // 
            // documentGroup
            // 
            this.documentGroup.Controls.Add(this.verticalDivider1);
            this.documentGroup.Controls.Add(this.documentTypeLabel);
            this.documentGroup.Controls.Add(this.model_DocumentType);
            this.documentGroup.Controls.Add(this.documentReferenceLabel);
            this.documentGroup.Controls.Add(this.model_DocumentReference);
            this.documentGroup.Controls.Add(this.documentEntityLabel);
            this.documentGroup.Controls.Add(this.model_DocumentEntity);
            this.documentGroup.Controls.Add(this.documentDeptLabel);
            this.documentGroup.Controls.Add(this.model_DocumentDept);
            this.documentGroup.Controls.Add(this.recipientNameLabel);
            this.documentGroup.Controls.Add(this.model_RecipientName);
            this.documentGroup.Controls.Add(this.documentClassLabel);
            this.documentGroup.Controls.Add(this.model_DocumentClass);
            this.documentGroup.Controls.Add(this.documentDateLabel);
            this.documentGroup.Controls.Add(this.model_DocumentDate);
            this.documentGroup.Location = new System.Drawing.Point(7, 57);
            this.documentGroup.Name = "documentGroup";
            this.documentGroup.Size = new System.Drawing.Size(990, 100);
            this.documentGroup.TabIndex = 2;
            this.documentGroup.TabStop = false;
            this.documentGroup.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelDocument;
            // 
            // verticalDivider1
            // 
            this.verticalDivider1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.verticalDivider1.Location = new System.Drawing.Point(465, 19);
            this.verticalDivider1.Name = "verticalDivider1";
            this.verticalDivider1.Size = new System.Drawing.Size(2, 73);
            // 
            // model_DocumentType
            // 
            this.model_DocumentType.Location = new System.Drawing.Point(89, 19);
            this.model_DocumentType.MaxLength = 25;
            this.model_DocumentType.Name = "model_DocumentType";
            this.model_DocumentType.Size = new System.Drawing.Size(180, 20);
            this.model_DocumentType.TabIndex = 1;
            // 
            // documentTypeLabel
            // 
            this.documentTypeLabel.AutoSize = true;
            this.documentTypeLabel.Location = new System.Drawing.Point(14, 22);
            this.documentTypeLabel.Name = "documentTypeLabel";
            this.documentTypeLabel.Size = new System.Drawing.Size(45, 13);
            this.documentTypeLabel.Text = "Tipo";
            this.toolTip.SetToolTip(this.documentTypeLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentType);
            // 
            // model_DocumentReference
            // 
            this.model_DocumentReference.Location = new System.Drawing.Point(89, 45);
            this.model_DocumentReference.MaxLength = 20;
            this.model_DocumentReference.Name = "model_DocumentReference";
            this.model_DocumentReference.Size = new System.Drawing.Size(150, 20);
            this.model_DocumentReference.TabIndex = 2;
            // 
            // documentReferenceLabel
            // 
            this.documentReferenceLabel.AutoSize = true;
            this.documentReferenceLabel.Location = new System.Drawing.Point(14, 48);
            this.documentReferenceLabel.Name = "documentReferenceLabel";
            this.documentReferenceLabel.Size = new System.Drawing.Size(44, 13);
            this.documentReferenceLabel.Text = "Número";
            this.toolTip.SetToolTip(this.documentReferenceLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentNumber);
            // 
            // model_DocumentEntity
            // 
            this.model_DocumentEntity.Location = new System.Drawing.Point(89, 71);
            this.model_DocumentEntity.MaxLength = 50;
            this.model_DocumentEntity.Name = "model_DocumentEntity";
            this.model_DocumentEntity.Size = new System.Drawing.Size(360, 20);
            this.model_DocumentEntity.TabIndex = 3;
            // 
            // documentEntityLabel
            // 
            this.documentEntityLabel.AutoSize = true;
            this.documentEntityLabel.Location = new System.Drawing.Point(14, 74);
            this.documentEntityLabel.Name = "documentEntityLabel";
            this.documentEntityLabel.Size = new System.Drawing.Size(36, 13);
            this.documentEntityLabel.Text = "Entidade";
            this.toolTip.SetToolTip(this.documentEntityLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentEntity);
            // 
            // model_DocumentDept
            // 
            this.model_DocumentDept.Location = new System.Drawing.Point(565, 19);
            this.model_DocumentDept.MaxLength = 50;
            this.model_DocumentDept.Name = "model_DocumentDept";
            this.model_DocumentDept.Size = new System.Drawing.Size(360, 20);
            this.model_DocumentDept.TabIndex = 4;
            // 
            // documentDeptLabel
            // 
            this.documentDeptLabel.AutoSize = true;
            this.documentDeptLabel.Location = new System.Drawing.Point(473, 22);
            this.documentDeptLabel.Name = "documentDeptLabel";
            this.documentDeptLabel.Size = new System.Drawing.Size(47, 13);
            this.documentDeptLabel.Text = "Departamento";
            this.toolTip.SetToolTip(this.documentDeptLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentDept);
            // 
            // model_DocumentClass
            // 
            this.model_DocumentClass.Location = new System.Drawing.Point(565, 45);
            this.model_DocumentClass.MaxLength = 7;
            this.model_DocumentClass.Name = "model_DocumentClass";
            this.model_DocumentClass.Size = new System.Drawing.Size(60, 20);
            this.model_DocumentClass.TabIndex = 5;
            // 
            // documentClassLabel
            // 
            this.documentClassLabel.AutoSize = true;
            this.documentClassLabel.Location = new System.Drawing.Point(473, 48);
            this.documentClassLabel.Name = "documentClassLabel";
            this.documentClassLabel.Size = new System.Drawing.Size(69, 13);
            this.documentClassLabel.Text = "Classificação";
            this.toolTip.SetToolTip(this.documentClassLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentClass);
            // 
            // model_DocumentDate
            // 
            this.model_DocumentDate.Location = new System.Drawing.Point(860, 45);
            this.model_DocumentDate.MaxLength = 10;
            this.model_DocumentDate.Name = "model_DocumentDate";
            this.model_DocumentDate.Size = new System.Drawing.Size(65, 20);
            this.model_DocumentDate.TabIndex = 6;
            // 
            // documentDateLabel
            // 
            this.documentDateLabel.AutoSize = true;
            this.documentDateLabel.Location = new System.Drawing.Point(824, 48);
            this.documentDateLabel.Name = "documentDateLabel";
            this.documentDateLabel.Size = new System.Drawing.Size(30, 13);
            this.documentDateLabel.Text = "Data";
            this.toolTip.SetToolTip(this.documentDateLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentDate);
            // 
            // model_RecipientName
            // 
            this.model_RecipientName.Location = new System.Drawing.Point(565, 71);
            this.model_RecipientName.MaxLength = 50;
            this.model_RecipientName.Name = "model_RecipientName";
            this.model_RecipientName.Size = new System.Drawing.Size(360, 20);
            this.model_RecipientName.TabIndex = 7;
            // 
            // recipientNameLabel
            // 
            this.recipientNameLabel.AutoSize = true;
            this.recipientNameLabel.Location = new System.Drawing.Point(473, 74);
            this.recipientNameLabel.Name = "recipientNameLabel";
            this.recipientNameLabel.Size = new System.Drawing.Size(45, 13);
            this.recipientNameLabel.Text = "Destinatário";
            this.toolTip.SetToolTip(this.recipientNameLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipRecipientName);
            // 
            // model_ExpeditorName
            // 
            this.model_ExpeditorName.Location = new System.Drawing.Point(96, 163);
            this.model_ExpeditorName.MaxLength = 50;
            this.model_ExpeditorName.Name = "model_ExpeditorName";
            this.model_ExpeditorName.Size = new System.Drawing.Size(360, 20);
            this.model_ExpeditorName.TabIndex = 3;
            // 
            // expeditorNameLabel
            // 
            this.expeditorNameLabel.AutoSize = true;
            this.expeditorNameLabel.Location = new System.Drawing.Point(4, 166);
            this.expeditorNameLabel.Name = "expeditorNameLabel";
            this.expeditorNameLabel.Size = new System.Drawing.Size(69, 13);
            this.expeditorNameLabel.Text = "Expedido por";
            this.toolTip.SetToolTip(this.expeditorNameLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipExpeditorName);
            // 
            // model_ReceptionName
            // 
            this.model_ReceptionName.Location = new System.Drawing.Point(96, 189);
            this.model_ReceptionName.MaxLength = 50;
            this.model_ReceptionName.Name = "model_ReceptionName";
            this.model_ReceptionName.Size = new System.Drawing.Size(360, 20);
            this.model_ReceptionName.TabIndex = 6;
            // 
            // receptionNameLabel
            // 
            this.receptionNameLabel.AutoSize = true;
            this.receptionNameLabel.Location = new System.Drawing.Point(4, 192);
            this.receptionNameLabel.Name = "receptionNameLabel";
            this.receptionNameLabel.Size = new System.Drawing.Size(89, 13);
            this.receptionNameLabel.Text = "Recebido por";
            this.toolTip.SetToolTip(this.receptionNameLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipReceptionName);
            // 
            // model_ReceptionDate
            // 
            this.model_ReceptionDate.Location = new System.Drawing.Point(572, 163);
            this.model_ReceptionDate.MaxLength = 10;
            this.model_ReceptionDate.Name = "model_ReceptionDate";
            this.model_ReceptionDate.Size = new System.Drawing.Size(65, 20);
            this.model_ReceptionDate.TabIndex = 4;
            // 
            // receptionDateLabel
            // 
            this.receptionDateLabel.AutoSize = true;
            this.receptionDateLabel.Location = new System.Drawing.Point(480, 166);
            this.receptionDateLabel.Name = "receptionDateLabel";
            this.receptionDateLabel.Size = new System.Drawing.Size(93, 13);
            this.receptionDateLabel.Text = "Data de recepção";
            this.toolTip.SetToolTip(this.receptionDateLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipReceptionDate);
            // 
            // audit
            // 
            this.audit.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audit.Location = new System.Drawing.Point(555, 221);
            this.audit.Name = "audit";
            this.audit.Size = new System.Drawing.Size(429, 13);
            this.audit.Text = "Audit line";
            this.audit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorWarnInfoProvider
            // 
            this.errorWarnInfoProvider.ContainerControl = this;
            // 
            // verticalDivider2
            // 
            this.verticalDivider2.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.verticalDivider2.Location = new System.Drawing.Point(472, 163);
            this.verticalDivider2.Name = "verticalDivider2";
            this.verticalDivider2.Size = new System.Drawing.Size(2, 47);
            // 
            // whenEmptyCreateRegister
            // 
            this.whenEmptyCreateRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whenEmptyCreateRegister.Location = new System.Drawing.Point(335, 101);
            this.whenEmptyCreateRegister.Name = "whenEmptyCreateRegister";
            this.whenEmptyCreateRegister.Size = new System.Drawing.Size(338, 65);
            this.whenEmptyCreateRegister.TabIndex = 8;
            this.whenEmptyCreateRegister.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelClickCreateDelivery;
            this.whenEmptyCreateRegister.Visible = false;
            // 
            // DeliveryDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.whenEmptyCreateRegister);
            this.Controls.Add(this.verticalDivider2);
            this.Controls.Add(this.registerId);
            this.Controls.Add(this.registerDateLabel);
            this.Controls.Add(this.model_RegisterDate);
            this.Controls.Add(this.documentGroup);
            this.Controls.Add(this.audit);
            this.Controls.Add(this.receptionNameLabel);
            this.Controls.Add(this.model_ReceptionName);
            this.Controls.Add(this.receptionDateLabel);
            this.Controls.Add(this.model_ReceptionDate);
            this.Controls.Add(this.expeditorNameLabel);
            this.Controls.Add(this.model_ExpeditorName);
            this.Controls.Add(this.detailPanel);
            this.Name = "DeliveryDetailView";
            this.Size = new System.Drawing.Size(1008, 242);
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            this.documentGroup.ResumeLayout(false);
            this.documentGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorWarnInfoProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CaliburnMicro.WisejWeb.PanelEx.PanelEx detailPanel;
        private CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx createRegister;
        private CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx editDetail;
        private CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx cancel;
        private CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx save;
        private CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx printDetail;
        private CaliburnMicro.WisejWeb.PanelEx.ComponentToolEx toggleDetailPanel;
        private Wisej.Web.Label registerId;
        private Wisej.Web.Label registerDateLabel;
        private Wisej.Web.TextBox model_RegisterDate;
        private Wisej.Web.GroupBox documentGroup;
        private Wisej.Web.Label documentTypeLabel;
        private Wisej.Web.TextBox model_DocumentType;
        private Wisej.Web.Label documentReferenceLabel;
        private Wisej.Web.TextBox model_DocumentReference;
        private Wisej.Web.Label documentEntityLabel;
        private Wisej.Web.TextBox model_DocumentEntity;
        private Wisej.Web.Label documentDeptLabel;
        private Wisej.Web.TextBox model_DocumentDept;
        private Wisej.Web.Label documentClassLabel;
        private Wisej.Web.TextBox model_DocumentClass;
        private Wisej.Web.Label documentDateLabel;
        private Wisej.Web.TextBox model_DocumentDate;
        private Wisej.Web.Label recipientNameLabel;
        private Wisej.Web.TextBox model_RecipientName;
        private Wisej.Web.Label expeditorNameLabel;
        private Wisej.Web.TextBox model_ExpeditorName;
        private Wisej.Web.Label receptionNameLabel;
        private Wisej.Web.TextBox model_ReceptionName;
        private Wisej.Web.Label receptionDateLabel;
        private Wisej.Web.TextBox model_ReceptionDate;
        private Wisej.Web.Label audit;
        private Wisej.Web.ToolTip toolTip;
        private CslaContrib.WisejWeb.ErrorWarnInfoProvider errorWarnInfoProvider;
        private Wisej.Web.Label verticalDivider1;
        private Wisej.Web.Label verticalDivider2;
        private Wisej.Web.Button whenEmptyCreateRegister;
    }
}
