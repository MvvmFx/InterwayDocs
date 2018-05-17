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
            this.detailToolStrip = new System.Windows.Forms.ToolStrip();
            this.toggleDetailPanel = new System.Windows.Forms.ToolStripButton();
            this.printDetail = new System.Windows.Forms.ToolStripButton();
            this.cancel = new System.Windows.Forms.ToolStripButton();
            this.save = new System.Windows.Forms.ToolStripButton();
            this.editDetail = new System.Windows.Forms.ToolStripButton();
            this.createRegister = new System.Windows.Forms.ToolStripButton();
            this.panelTitle = new System.Windows.Forms.ToolStripLabel();
            this.registerId = new System.Windows.Forms.Label();
            this.model_RegisterDate = new System.Windows.Forms.TextBox();
            this.registerDateLabel = new System.Windows.Forms.Label();
            this.documentGroup = new System.Windows.Forms.GroupBox();
            this.verticalDivider1 = new System.Windows.Forms.Label();
            this.model_DocumentType = new System.Windows.Forms.TextBox();
            this.documentTypeLabel = new System.Windows.Forms.Label();
            this.model_DocumentReference = new System.Windows.Forms.TextBox();
            this.documentReferenceLabel = new System.Windows.Forms.Label();
            this.model_DocumentEntity = new System.Windows.Forms.TextBox();
            this.documentEntityLabel = new System.Windows.Forms.Label();
            this.model_DocumentDept = new System.Windows.Forms.TextBox();
            this.documentDeptLabel = new System.Windows.Forms.Label();
            this.model_RecipientName = new System.Windows.Forms.TextBox();
            this.recipientNameLabel = new System.Windows.Forms.Label();
            this.model_DocumentClass = new System.Windows.Forms.TextBox();
            this.documentClassLabel = new System.Windows.Forms.Label();
            this.model_DocumentDate = new System.Windows.Forms.TextBox();
            this.documentDateLabel = new System.Windows.Forms.Label();
            this.model_ExpeditorName = new System.Windows.Forms.TextBox();
            this.expeditorNameLabel = new System.Windows.Forms.Label();
            this.model_ReceptionName = new System.Windows.Forms.TextBox();
            this.receptionNameLabel = new System.Windows.Forms.Label();
            this.model_ReceptionDate = new System.Windows.Forms.TextBox();
            this.receptionDateLabel = new System.Windows.Forms.Label();
            this.audit = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorWarnInfoProvider = new CslaContrib.Windows.ErrorWarnInfoProvider(this.components);
            this.verticalDivider2 = new System.Windows.Forms.Label();
            this.whenEmptyCreateRegister = new System.Windows.Forms.Button();
            this.detailToolStrip.SuspendLayout();
            this.documentGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorWarnInfoProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // detailToolStrip
            // 
            this.detailToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleDetailPanel,
            this.printDetail,
            this.cancel,
            this.save,
            this.editDetail,
            this.createRegister,
            this.panelTitle});
            this.detailToolStrip.Location = new System.Drawing.Point(0, 0);
            this.detailToolStrip.Name = "detailToolStrip";
            this.detailToolStrip.Size = new System.Drawing.Size(1008, 25);
            this.detailToolStrip.MouseHover += new System.EventHandler(this.ForceValidation);
            // 
            // toggleDetailPanel
            // 
            this.toggleDetailPanel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toggleDetailPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toggleDetailPanel.Image = global::Codisa.InterwayDocs.Properties.Resources.ArrowDown16;
            this.toggleDetailPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toggleDetailPanel.Name = "toggleDetailPanel";
            this.toggleDetailPanel.Size = new System.Drawing.Size(23, 22);
            this.toggleDetailPanel.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipHideDetail;
            // 
            // printDetail
            // 
            this.printDetail.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.printDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printDetail.Image = global::Codisa.InterwayDocs.Properties.Resources.Excel;
            this.printDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printDetail.Name = "printDetail";
            this.printDetail.Size = new System.Drawing.Size(23, 22);
            this.printDetail.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipExportRegisterExcel;
            // 
            // cancel
            // 
            this.cancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancel.Image = global::Codisa.InterwayDocs.Properties.Resources.Delete16;
            this.cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(23, 22);
            this.cancel.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipCancel;
            // 
            // save
            // 
            this.save.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save.Image = global::Codisa.InterwayDocs.Properties.Resources.Save16;
            this.save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(23, 22);
            this.save.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipSave;
            // 
            // editDetail
            // 
            this.editDetail.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.editDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editDetail.Image = global::Codisa.InterwayDocs.Properties.Resources.Edit16;
            this.editDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editDetail.Name = "editDetail";
            this.editDetail.Size = new System.Drawing.Size(23, 22);
            this.editDetail.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipEdit;
            // 
            // createRegister
            // 
            this.createRegister.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.createRegister.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createRegister.Image = global::Codisa.InterwayDocs.Properties.Resources.AddNew16;
            this.createRegister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createRegister.Name = "createRegister";
            this.createRegister.Size = new System.Drawing.Size(23, 22);
            this.createRegister.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipNew;
            // 
            // panelTitle
            // 
            this.panelTitle.AutoSize = false;
            this.panelTitle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.panelTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(150, 22);
            this.panelTitle.Text = "panelTitle";
            this.panelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // registerId
            // 
            this.registerId.AutoSize = true;
            this.registerId.Location = new System.Drawing.Point(13, 34);
            this.registerId.Name = "registerId";
            this.registerId.Size = new System.Drawing.Size(104, 13);
            this.registerId.Text = "Register nr. ####";
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
            this.registerDateLabel.Location = new System.Drawing.Point(278, 34);
            this.registerDateLabel.Name = "registerDateLabel";
            this.registerDateLabel.Size = new System.Drawing.Size(110, 13);
            this.registerDateLabel.Text = "Register date";
            this.registerDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.registerDateLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipRegisterDate);
            // 
            // documentGroup
            // 
            this.documentGroup.Controls.Add(this.verticalDivider1);
            this.documentGroup.Controls.Add(this.model_DocumentType);
            this.documentGroup.Controls.Add(this.documentTypeLabel);
            this.documentGroup.Controls.Add(this.model_DocumentReference);
            this.documentGroup.Controls.Add(this.documentReferenceLabel);
            this.documentGroup.Controls.Add(this.model_DocumentEntity);
            this.documentGroup.Controls.Add(this.documentEntityLabel);
            this.documentGroup.Controls.Add(this.model_DocumentDept);
            this.documentGroup.Controls.Add(this.documentDeptLabel);
            this.documentGroup.Controls.Add(this.model_RecipientName);
            this.documentGroup.Controls.Add(this.recipientNameLabel);
            this.documentGroup.Controls.Add(this.model_DocumentClass);
            this.documentGroup.Controls.Add(this.documentClassLabel);
            this.documentGroup.Controls.Add(this.model_DocumentDate);
            this.documentGroup.Controls.Add(this.documentDateLabel);
            this.documentGroup.Location = new System.Drawing.Point(7, 57);
            this.documentGroup.Name = "documentGroup";
            this.documentGroup.Size = new System.Drawing.Size(990, 100);
            this.documentGroup.TabIndex = 2;
            this.documentGroup.TabStop = false;
            this.documentGroup.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelDocument;
            // 
            // verticalDivider1
            // 
            this.verticalDivider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.model_DocumentType.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // documentTypeLabel
            // 
            this.documentTypeLabel.AutoSize = true;
            this.documentTypeLabel.Location = new System.Drawing.Point(14, 22);
            this.documentTypeLabel.Name = "documentTypeLabel";
            this.documentTypeLabel.Size = new System.Drawing.Size(45, 13);
            this.documentTypeLabel.Text = "Type";
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
            this.documentReferenceLabel.Text = "Number";
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
            this.documentEntityLabel.Text = "Entity";
            this.toolTip.SetToolTip(this.documentEntityLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentEntity);
            // 
            // model_DocumentDept
            // 
            this.model_DocumentDept.Location = new System.Drawing.Point(565, 19);
            this.model_DocumentDept.MaxLength = 50;
            this.model_DocumentDept.Name = "model_DocumentDept";
            this.model_DocumentDept.Size = new System.Drawing.Size(360, 20);
            this.model_DocumentDept.TabIndex = 4;
            this.model_DocumentDept.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // documentDeptLabel
            // 
            this.documentDeptLabel.AutoSize = true;
            this.documentDeptLabel.Location = new System.Drawing.Point(473, 22);
            this.documentDeptLabel.Name = "documentDeptLabel";
            this.documentDeptLabel.Size = new System.Drawing.Size(47, 13);
            this.documentDeptLabel.Text = "Department";
            this.toolTip.SetToolTip(this.documentDeptLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentDept);
            // 
            // model_DocumentClass
            // 
            this.model_DocumentClass.Location = new System.Drawing.Point(565, 45);
            this.model_DocumentClass.MaxLength = 7;
            this.model_DocumentClass.Name = "model_DocumentClass";
            this.model_DocumentClass.Size = new System.Drawing.Size(60, 20);
            this.model_DocumentClass.TabIndex = 5;
            this.model_DocumentClass.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // documentClassLabel
            // 
            this.documentClassLabel.AutoSize = true;
            this.documentClassLabel.Location = new System.Drawing.Point(473, 48);
            this.documentClassLabel.Name = "documentClassLabel";
            this.documentClassLabel.Size = new System.Drawing.Size(69, 13);
            this.documentClassLabel.Text = "Class";
            this.toolTip.SetToolTip(this.documentClassLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentClass);
            // 
            // model_DocumentDate
            // 
            this.model_DocumentDate.Location = new System.Drawing.Point(860, 45);
            this.model_DocumentDate.MaxLength = 10;
            this.model_DocumentDate.Name = "model_DocumentDate";
            this.model_DocumentDate.Size = new System.Drawing.Size(65, 20);
            this.model_DocumentDate.TabIndex = 6;
            this.model_DocumentDate.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // documentDateLabel
            // 
            this.documentDateLabel.Location = new System.Drawing.Point(806, 48);
            this.documentDateLabel.Name = "documentDateLabel";
            this.documentDateLabel.Size = new System.Drawing.Size(50, 13);
            this.documentDateLabel.Text = "Date";
            this.documentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.documentDateLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDocumentDate);
            // 
            // model_RecipientName
            // 
            this.model_RecipientName.Location = new System.Drawing.Point(565, 71);
            this.model_RecipientName.MaxLength = 50;
            this.model_RecipientName.Name = "model_RecipientName";
            this.model_RecipientName.Size = new System.Drawing.Size(360, 20);
            this.model_RecipientName.TabIndex = 7;
            this.model_RecipientName.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // recipientNameLabel
            // 
            this.recipientNameLabel.AutoSize = true;
            this.recipientNameLabel.Location = new System.Drawing.Point(473, 74);
            this.recipientNameLabel.Name = "recipientNameLabel";
            this.recipientNameLabel.Size = new System.Drawing.Size(45, 13);
            this.recipientNameLabel.Text = "Recipient";
            this.toolTip.SetToolTip(this.recipientNameLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipRecipientName);
            // 
            // model_ExpeditorName
            // 
            this.model_ExpeditorName.Location = new System.Drawing.Point(96, 163);
            this.model_ExpeditorName.MaxLength = 50;
            this.model_ExpeditorName.Name = "model_ExpeditorName";
            this.model_ExpeditorName.Size = new System.Drawing.Size(360, 20);
            this.model_ExpeditorName.TabIndex = 3;
            this.model_ExpeditorName.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // expeditorNameLabel
            // 
            this.expeditorNameLabel.AutoSize = true;
            this.expeditorNameLabel.Location = new System.Drawing.Point(4, 166);
            this.expeditorNameLabel.Name = "expeditorNameLabel";
            this.expeditorNameLabel.Size = new System.Drawing.Size(69, 13);
            this.expeditorNameLabel.Text = "Sent by";
            this.toolTip.SetToolTip(this.expeditorNameLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipExpeditorName);
            // 
            // model_ReceptionName
            // 
            this.model_ReceptionName.Location = new System.Drawing.Point(96, 189);
            this.model_ReceptionName.MaxLength = 50;
            this.model_ReceptionName.Name = "model_ReceptionName";
            this.model_ReceptionName.Size = new System.Drawing.Size(360, 20);
            this.model_ReceptionName.TabIndex = 6;
            this.model_ReceptionName.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // receptionNameLabel
            // 
            this.receptionNameLabel.AutoSize = true;
            this.receptionNameLabel.Location = new System.Drawing.Point(4, 192);
            this.receptionNameLabel.Name = "receptionNameLabel";
            this.receptionNameLabel.Size = new System.Drawing.Size(89, 13);
            this.receptionNameLabel.Text = "Received by";
            this.toolTip.SetToolTip(this.receptionNameLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipReceptionName);
            // 
            // model_ReceptionDate
            // 
            this.model_ReceptionDate.Location = new System.Drawing.Point(572, 163);
            this.model_ReceptionDate.MaxLength = 10;
            this.model_ReceptionDate.Name = "model_ReceptionDate";
            this.model_ReceptionDate.Size = new System.Drawing.Size(65, 20);
            this.model_ReceptionDate.TabIndex = 4;
            this.model_ReceptionDate.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // receptionDateLabel
            // 
            this.receptionDateLabel.AutoSize = true;
            this.receptionDateLabel.Location = new System.Drawing.Point(480, 166);
            this.receptionDateLabel.Name = "receptionDateLabel";
            this.receptionDateLabel.Size = new System.Drawing.Size(93, 13);
            this.receptionDateLabel.Text = "Reception date";
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
            this.verticalDivider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalDivider2.Location = new System.Drawing.Point(472, 163);
            this.verticalDivider2.Name = "verticalDivider2";
            this.verticalDivider2.Size = new System.Drawing.Size(2, 47);
            // 
            // whenEmptyCreateRegister
            // 
            this.whenEmptyCreateRegister.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.whenEmptyCreateRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whenEmptyCreateRegister.Location = new System.Drawing.Point(335, 101);
            this.whenEmptyCreateRegister.Name = "whenEmptyCreateRegister";
            this.whenEmptyCreateRegister.Size = new System.Drawing.Size(338, 65);
            this.whenEmptyCreateRegister.TabIndex = 8;
            this.whenEmptyCreateRegister.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelClickCreateDelivery;
            this.whenEmptyCreateRegister.UseVisualStyleBackColor = true;
            this.whenEmptyCreateRegister.Visible = false;
            // 
            // DeliveryDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.whenEmptyCreateRegister);
            this.Controls.Add(this.verticalDivider2);
            this.Controls.Add(this.registerId);
            this.Controls.Add(this.model_RegisterDate);
            this.Controls.Add(this.registerDateLabel);
            this.Controls.Add(this.documentGroup);
            this.Controls.Add(this.audit);
            this.Controls.Add(this.model_ReceptionName);
            this.Controls.Add(this.receptionNameLabel);
            this.Controls.Add(this.model_ReceptionDate);
            this.Controls.Add(this.receptionDateLabel);
            this.Controls.Add(this.model_ExpeditorName);
            this.Controls.Add(this.expeditorNameLabel);
            this.Controls.Add(this.detailToolStrip);
            this.DoubleBuffered = true;
            this.Name = "DeliveryDetailView";
            this.Size = new System.Drawing.Size(1008, 242);
            this.detailToolStrip.ResumeLayout(false);
            this.detailToolStrip.PerformLayout();
            this.documentGroup.ResumeLayout(false);
            this.documentGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorWarnInfoProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip detailToolStrip;
        private System.Windows.Forms.ToolStripButton createRegister;
        private System.Windows.Forms.ToolStripButton editDetail;
        private System.Windows.Forms.ToolStripButton cancel;
        private System.Windows.Forms.ToolStripButton save;
        private System.Windows.Forms.ToolStripButton printDetail;
        private System.Windows.Forms.ToolStripButton toggleDetailPanel;
        private System.Windows.Forms.ToolStripLabel panelTitle;
        private System.Windows.Forms.Label registerId;
        private System.Windows.Forms.TextBox model_RegisterDate;
        private System.Windows.Forms.Label registerDateLabel;
        private System.Windows.Forms.GroupBox documentGroup;
        private System.Windows.Forms.TextBox model_DocumentType;
        private System.Windows.Forms.Label documentTypeLabel;
        private System.Windows.Forms.TextBox model_DocumentReference;
        private System.Windows.Forms.Label documentReferenceLabel;
        private System.Windows.Forms.TextBox model_DocumentEntity;
        private System.Windows.Forms.Label documentEntityLabel;
        private System.Windows.Forms.TextBox model_DocumentDept;
        private System.Windows.Forms.Label documentDeptLabel;
        private System.Windows.Forms.TextBox model_DocumentClass;
        private System.Windows.Forms.Label documentClassLabel;
        private System.Windows.Forms.TextBox model_DocumentDate;
        private System.Windows.Forms.Label documentDateLabel;
        private System.Windows.Forms.TextBox model_RecipientName;
        private System.Windows.Forms.Label recipientNameLabel;
        private System.Windows.Forms.TextBox model_ExpeditorName;
        private System.Windows.Forms.Label expeditorNameLabel;
        private System.Windows.Forms.TextBox model_ReceptionName;
        private System.Windows.Forms.Label receptionNameLabel;
        private System.Windows.Forms.TextBox model_ReceptionDate;
        private System.Windows.Forms.Label receptionDateLabel;
        private System.Windows.Forms.Label audit;
        private System.Windows.Forms.ToolTip toolTip;
        private CslaContrib.Windows.ErrorWarnInfoProvider errorWarnInfoProvider;
        private System.Windows.Forms.Label verticalDivider1;
        private System.Windows.Forms.Label verticalDivider2;
        private System.Windows.Forms.Button whenEmptyCreateRegister;
    }
}
