namespace Codisa.InterwayDocs.Outgoing
{
    partial class OutgoingDetailView
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
            this.detailPanel = new MvvmFx.CaliburnMicro.WisejWeb.Toolable.PanelEx();
            this.toggleDetailPanel = new MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx();
            this.printDetail = new MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx();
            this.cancel = new MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx();
            this.save = new MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx();
            this.editDetail = new MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx();
            this.createRegister = new MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx();
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
            this.documentClassLabel = new Wisej.Web.Label();
            this.model_DocumentClass = new Wisej.Web.TextBox();
            this.documentDateLabel = new Wisej.Web.Label();
            this.model_DocumentDate = new Wisej.Web.TextBox();
            this.subjectLabel = new Wisej.Web.Label();
            this.model_Subject = new Wisej.Web.TextBox();
            this.sendDateLabel = new Wisej.Web.Label();
            this.model_SendDate = new Wisej.Web.TextBox();
            this.recipientNameLabel = new Wisej.Web.Label();
            this.model_RecipientName = new Wisej.Web.TextBox();
            this.recipientTownLabel = new Wisej.Web.Label();
            this.model_RecipientTown = new Wisej.Web.TextBox();
            this.notesLabel = new Wisej.Web.Label();
            this.model_Notes = new Wisej.Web.TextBox();
            this.archiveLocationLabel = new Wisej.Web.Label();
            this.model_ArchiveLocation = new Wisej.Web.TextBox();
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
            this.detailPanel.Tools.AddRange(new MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx[] {
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
            this.model_RegisterDate.MouseLeave += new System.EventHandler(this.ForceValidation);
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
            this.documentGroup.Controls.Add(this.documentClassLabel);
            this.documentGroup.Controls.Add(this.model_DocumentClass);
            this.documentGroup.Controls.Add(this.documentDateLabel);
            this.documentGroup.Controls.Add(this.model_DocumentDate);
            this.documentGroup.Controls.Add(this.subjectLabel);
            this.documentGroup.Controls.Add(this.model_Subject);
            this.documentGroup.Location = new System.Drawing.Point(7, 57);
            this.documentGroup.Name = "documentGroup";
            this.documentGroup.Size = new System.Drawing.Size(990, 126);
            this.documentGroup.TabIndex = 2;
            this.documentGroup.TabStop = false;
            this.documentGroup.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelDocument;
            // 
            // verticalDivider1
            // 
            this.verticalDivider1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.verticalDivider1.Location = new System.Drawing.Point(465, 19);
            this.verticalDivider1.Name = "verticalDivider1";
            this.verticalDivider1.Size = new System.Drawing.Size(2, 99);
            // 
            // model_DocumentType
            // 
            this.model_DocumentType.Location = new System.Drawing.Point(89, 19);
            this.model_DocumentType.MaxLength = 25;
            this.model_DocumentType.Name = "model_DocumentType";
            this.model_DocumentType.Size = new System.Drawing.Size(180, 20);
            this.model_DocumentType.TabIndex = 1;
            this.model_DocumentType.MouseLeave += new System.EventHandler(this.ForceValidation);
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
            this.model_DocumentReference.MouseLeave += new System.EventHandler(this.ForceValidation);
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
            this.model_DocumentEntity.MouseLeave += new System.EventHandler(this.ForceValidation);
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
            this.model_DocumentDept.Location = new System.Drawing.Point(89, 97);
            this.model_DocumentDept.MaxLength = 50;
            this.model_DocumentDept.Name = "model_DocumentDept";
            this.model_DocumentDept.Size = new System.Drawing.Size(360, 20);
            this.model_DocumentDept.TabIndex = 4;
            this.model_DocumentDept.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // documentDeptLabel
            // 
            this.documentDeptLabel.AutoSize = true;
            this.documentDeptLabel.Location = new System.Drawing.Point(14, 100);
            this.documentDeptLabel.Name = "documentDeptLabel";
            this.documentDeptLabel.Size = new System.Drawing.Size(47, 13);
            this.documentDeptLabel.Text = "Departamento";
            this.toolTip.SetToolTip(this.documentDeptLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentDept);
            // 
            // model_DocumentClass
            // 
            this.model_DocumentClass.Location = new System.Drawing.Point(548, 19);
            this.model_DocumentClass.MaxLength = 7;
            this.model_DocumentClass.Name = "model_DocumentClass";
            this.model_DocumentClass.Size = new System.Drawing.Size(60, 20);
            this.model_DocumentClass.TabIndex = 5;
            this.model_DocumentClass.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // documentClassLabel
            // 
            this.documentClassLabel.AutoSize = true;
            this.documentClassLabel.Location = new System.Drawing.Point(473, 22);
            this.documentClassLabel.Name = "documentClassLabel";
            this.documentClassLabel.Size = new System.Drawing.Size(69, 13);
            this.documentClassLabel.Text = "Classificação";
            this.toolTip.SetToolTip(this.documentClassLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentClass);
            // 
            // model_DocumentDate
            // 
            this.model_DocumentDate.Location = new System.Drawing.Point(907, 19);
            this.model_DocumentDate.MaxLength = 10;
            this.model_DocumentDate.Name = "model_DocumentDate";
            this.model_DocumentDate.Size = new System.Drawing.Size(65, 20);
            this.model_DocumentDate.TabIndex = 6;
            this.model_DocumentDate.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // documentDateLabel
            // 
            this.documentDateLabel.AutoSize = true;
            this.documentDateLabel.Location = new System.Drawing.Point(871, 22);
            this.documentDateLabel.Name = "documentDateLabel";
            this.documentDateLabel.Size = new System.Drawing.Size(30, 13);
            this.documentDateLabel.Text = "Data";
            this.toolTip.SetToolTip(this.documentDateLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentDate);
            // 
            // model_Subject
            // 
            this.model_Subject.Location = new System.Drawing.Point(548, 45);
            this.model_Subject.MaxLength = 500;
            this.model_Subject.Multiline = true;
            this.model_Subject.Name = "model_Subject";
            this.model_Subject.ScrollBars = Wisej.Web.ScrollBars.Vertical;
            this.model_Subject.Size = new System.Drawing.Size(425, 72);
            this.model_Subject.TabIndex = 7;
            this.model_Subject.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(473, 48);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(45, 13);
            this.subjectLabel.Text = "Assunto";
            this.toolTip.SetToolTip(this.subjectLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipSubject);
            // 
            // model_SendDate
            // 
            this.model_SendDate.Location = new System.Drawing.Point(96, 189);
            this.model_SendDate.MaxLength = 10;
            this.model_SendDate.Name = "model_SendDate";
            this.model_SendDate.Size = new System.Drawing.Size(65, 20);
            this.model_SendDate.TabIndex = 3;
            this.model_SendDate.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // sendDateLabel
            // 
            this.sendDateLabel.AutoSize = true;
            this.sendDateLabel.Location = new System.Drawing.Point(4, 192);
            this.sendDateLabel.Name = "sendDateLabel";
            this.sendDateLabel.Size = new System.Drawing.Size(93, 13);
            this.sendDateLabel.Text = "Data expedição";
            this.toolTip.SetToolTip(this.sendDateLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipSendDate);
            // 
            // model_RecipientName
            // 
            this.model_RecipientName.Location = new System.Drawing.Point(96, 215);
            this.model_RecipientName.MaxLength = 50;
            this.model_RecipientName.Name = "model_RecipientName";
            this.model_RecipientName.Size = new System.Drawing.Size(360, 20);
            this.model_RecipientName.TabIndex = 4;
            this.model_RecipientName.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // recipientNameLabel
            // 
            this.recipientNameLabel.AutoSize = true;
            this.recipientNameLabel.Location = new System.Drawing.Point(4, 218);
            this.recipientNameLabel.Name = "recipientNameLabel";
            this.recipientNameLabel.Size = new System.Drawing.Size(69, 13);
            this.recipientNameLabel.Text = "Destinatário";
            this.toolTip.SetToolTip(this.recipientNameLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipRecipientName);
            // 
            // model_RecipientTown
            // 
            this.model_RecipientTown.Location = new System.Drawing.Point(96, 241);
            this.model_RecipientTown.MaxLength = 50;
            this.model_RecipientTown.Name = "model_RecipientTown";
            this.model_RecipientTown.Size = new System.Drawing.Size(360, 20);
            this.model_RecipientTown.TabIndex = 5;
            this.model_RecipientTown.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // recipientTownLabel
            // 
            this.recipientTownLabel.AutoSize = true;
            this.recipientTownLabel.Location = new System.Drawing.Point(4, 244);
            this.recipientTownLabel.Name = "recipientTownLabel";
            this.recipientTownLabel.Size = new System.Drawing.Size(89, 13);
            this.recipientTownLabel.Text = "Localidade";
            this.toolTip.SetToolTip(this.recipientTownLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipRecipientTown);
            // 
            // model_Notes
            // 
            this.model_Notes.Location = new System.Drawing.Point(555, 189);
            this.model_Notes.MaxLength = 500;
            this.model_Notes.Multiline = true;
            this.model_Notes.Name = "model_Notes";
            this.model_Notes.ScrollBars = Wisej.Web.ScrollBars.Vertical;
            this.model_Notes.Size = new System.Drawing.Size(425, 46);
            this.model_Notes.TabIndex = 6;
            this.model_Notes.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(480, 192);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(70, 13);
            this.notesLabel.Text = "Observações";
            // 
            // model_ArchiveLocation
            // 
            this.model_ArchiveLocation.Location = new System.Drawing.Point(555, 241);
            this.model_ArchiveLocation.MaxLength = 50;
            this.model_ArchiveLocation.Name = "model_ArchiveLocation";
            this.model_ArchiveLocation.Size = new System.Drawing.Size(360, 20);
            this.model_ArchiveLocation.TabIndex = 7;
            this.model_ArchiveLocation.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // archiveLocationLabel
            // 
            this.archiveLocationLabel.AutoSize = true;
            this.archiveLocationLabel.Location = new System.Drawing.Point(480, 244);
            this.archiveLocationLabel.Name = "archiveLocationLabel";
            this.archiveLocationLabel.Size = new System.Drawing.Size(64, 13);
            this.archiveLocationLabel.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelArchiveLocation;
            this.toolTip.SetToolTip(this.archiveLocationLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipLocation);
            // 
            // audit
            // 
            this.audit.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audit.Location = new System.Drawing.Point(555, 273);
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
            this.verticalDivider2.Location = new System.Drawing.Point(472, 189);
            this.verticalDivider2.Name = "verticalDivider2";
            this.verticalDivider2.Size = new System.Drawing.Size(2, 73);
            // 
            // whenEmptyCreateRegister
            // 
            this.whenEmptyCreateRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whenEmptyCreateRegister.Location = new System.Drawing.Point(335, 127);
            this.whenEmptyCreateRegister.Name = "whenEmptyCreateRegister";
            this.whenEmptyCreateRegister.Size = new System.Drawing.Size(338, 65);
            this.whenEmptyCreateRegister.TabIndex = 8;
            this.whenEmptyCreateRegister.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelClickCreateOutgoing;
            this.whenEmptyCreateRegister.Visible = false;
            // 
            // OutgoingDetailView
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
            this.Controls.Add(this.archiveLocationLabel);
            this.Controls.Add(this.model_ArchiveLocation);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.model_Notes);
            this.Controls.Add(this.sendDateLabel);
            this.Controls.Add(this.model_SendDate);
            this.Controls.Add(this.recipientNameLabel);
            this.Controls.Add(this.model_RecipientName);
            this.Controls.Add(this.recipientTownLabel);
            this.Controls.Add(this.model_RecipientTown);
            this.Controls.Add(this.detailPanel);
            this.Name = "OutgoingDetailView";
            this.Size = new System.Drawing.Size(1008, 294);
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            this.documentGroup.ResumeLayout(false);
            this.documentGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorWarnInfoProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MvvmFx.CaliburnMicro.WisejWeb.Toolable.PanelEx detailPanel;
        private MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx createRegister;
        private MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx editDetail;
        private MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx cancel;
        private MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx save;
        private MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx printDetail;
        private MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx toggleDetailPanel;
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
        private Wisej.Web.Label subjectLabel;
        private Wisej.Web.TextBox model_Subject;
        private Wisej.Web.Label sendDateLabel;
        private Wisej.Web.TextBox model_SendDate;
        private Wisej.Web.Label recipientNameLabel;
        private Wisej.Web.TextBox model_RecipientName;
        private Wisej.Web.Label recipientTownLabel;
        private Wisej.Web.TextBox model_RecipientTown;
        private Wisej.Web.Label notesLabel;
        private Wisej.Web.TextBox model_Notes;
        private Wisej.Web.Label archiveLocationLabel;
        private Wisej.Web.TextBox model_ArchiveLocation;
        private Wisej.Web.Label audit;
        private Wisej.Web.ToolTip toolTip;
        private CslaContrib.WisejWeb.ErrorWarnInfoProvider errorWarnInfoProvider;
        private Wisej.Web.Label verticalDivider1;
        private Wisej.Web.Label verticalDivider2;
        private Wisej.Web.Button whenEmptyCreateRegister;
    }
}
