﻿namespace Codisa.InterwayDocs.Outgoing
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
            this.model_DocumentClass = new System.Windows.Forms.TextBox();
            this.documentClassLabel = new System.Windows.Forms.Label();
            this.model_DocumentDate = new System.Windows.Forms.TextBox();
            this.documentDateLabel = new System.Windows.Forms.Label();
            this.model_Subject = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.model_SendDate = new System.Windows.Forms.TextBox();
            this.sendDateLabel = new System.Windows.Forms.Label();
            this.model_RecipientName = new System.Windows.Forms.TextBox();
            this.recipientNameLabel = new System.Windows.Forms.Label();
            this.model_RecipientTown = new System.Windows.Forms.TextBox();
            this.recipientTownLabel = new System.Windows.Forms.Label();
            this.model_Notes = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.model_ArchiveLocation = new System.Windows.Forms.TextBox();
            this.archiveLocationLabel = new System.Windows.Forms.Label();
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
            this.toggleDetailPanel.ToolTipText = "Hide the register";
            // 
            // printDetail
            // 
            this.printDetail.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.printDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printDetail.Image = global::Codisa.InterwayDocs.Properties.Resources.Excel;
            this.printDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printDetail.Name = "printDetail";
            this.printDetail.Size = new System.Drawing.Size(23, 22);
            this.printDetail.ToolTipText = "Export the register to Excel";
            // 
            // cancel
            // 
            this.cancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancel.Image = global::Codisa.InterwayDocs.Properties.Resources.Delete16;
            this.cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(23, 22);
            this.cancel.ToolTipText = "Cancel changes";
            // 
            // save
            // 
            this.save.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save.Image = global::Codisa.InterwayDocs.Properties.Resources.Save16;
            this.save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(23, 22);
            this.save.ToolTipText = "Confirm changes";
            // 
            // editDetail
            // 
            this.editDetail.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.editDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editDetail.Image = global::Codisa.InterwayDocs.Properties.Resources.Edit16;
            this.editDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editDetail.Name = "editDetail";
            this.editDetail.Size = new System.Drawing.Size(23, 22);
            this.editDetail.ToolTipText = "Edit the register.";
            // 
            // createRegister
            // 
            this.createRegister.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.createRegister.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createRegister.Image = global::Codisa.InterwayDocs.Properties.Resources.AddNew16;
            this.createRegister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createRegister.Name = "createRegister";
            this.createRegister.Size = new System.Drawing.Size(23, 22);
            this.createRegister.ToolTipText = "New register";
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
            this.toolTip.SetToolTip(this.registerDateLabel, "Document creation date.");
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
            this.documentGroup.Controls.Add(this.model_DocumentClass);
            this.documentGroup.Controls.Add(this.documentClassLabel);
            this.documentGroup.Controls.Add(this.model_DocumentDate);
            this.documentGroup.Controls.Add(this.documentDateLabel);
            this.documentGroup.Controls.Add(this.model_Subject);
            this.documentGroup.Controls.Add(this.subjectLabel);
            this.documentGroup.Location = new System.Drawing.Point(7, 57);
            this.documentGroup.Name = "documentGroup";
            this.documentGroup.Size = new System.Drawing.Size(990, 126);
            this.documentGroup.TabIndex = 2;
            this.documentGroup.TabStop = false;
            this.documentGroup.Text = "Document";
            // 
            // verticalDivider1
            // 
            this.verticalDivider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.documentTypeLabel.Text = "Type";
            this.toolTip.SetToolTip(this.documentTypeLabel, "Document type");
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
            this.toolTip.SetToolTip(this.documentReferenceLabel, "The number that is written on the document.");
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
            this.toolTip.SetToolTip(this.documentEntityLabel, "Document Producing Entity");
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
            this.documentDeptLabel.Text = "Department";
            this.toolTip.SetToolTip(this.documentDeptLabel, "Department that produced the document.");
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
            this.documentClassLabel.Text = "Class";
            this.toolTip.SetToolTip(this.documentClassLabel, "Document classification code");
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
            this.documentDateLabel.Location = new System.Drawing.Point(853, 22);
            this.documentDateLabel.Name = "documentDateLabel";
            this.documentDateLabel.Size = new System.Drawing.Size(50, 13);
            this.documentDateLabel.Text = "Date";
            this.documentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.documentDateLabel, "The date that is written on the document.");
            // 
            // model_Subject
            // 
            this.model_Subject.Location = new System.Drawing.Point(548, 45);
            this.model_Subject.MaxLength = 500;
            this.model_Subject.Multiline = true;
            this.model_Subject.Name = "model_Subject";
            this.model_Subject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            this.subjectLabel.Text = "Subject";
            this.toolTip.SetToolTip(this.subjectLabel, "Document subject");
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
            this.sendDateLabel.Text = "Sent date";
            this.toolTip.SetToolTip(this.sendDateLabel, "Date of document dispatch");
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
            this.recipientNameLabel.Text = "Recipient";
            this.toolTip.SetToolTip(this.recipientNameLabel, "Document recipient");
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
            this.recipientTownLabel.Text = "Town";
            this.toolTip.SetToolTip(this.recipientTownLabel, "Document recipient town");
            // 
            // model_Notes
            // 
            this.model_Notes.Location = new System.Drawing.Point(555, 189);
            this.model_Notes.MaxLength = 500;
            this.model_Notes.Multiline = true;
            this.model_Notes.Name = "model_Notes";
            this.model_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            this.notesLabel.Text = "Observations";
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
            this.archiveLocationLabel.Text = "Location";
            this.toolTip.SetToolTip(this.archiveLocationLabel, "Location where the document is archived.");
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
            this.verticalDivider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalDivider2.Location = new System.Drawing.Point(472, 189);
            this.verticalDivider2.Name = "verticalDivider2";
            this.verticalDivider2.Size = new System.Drawing.Size(2, 73);
            // 
            // whenEmptyCreateRegister
            // 
            this.whenEmptyCreateRegister.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.whenEmptyCreateRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whenEmptyCreateRegister.Location = new System.Drawing.Point(335, 127);
            this.whenEmptyCreateRegister.Name = "whenEmptyCreateRegister";
            this.whenEmptyCreateRegister.Size = new System.Drawing.Size(338, 65);
            this.whenEmptyCreateRegister.TabIndex = 8;
            this.whenEmptyCreateRegister.Text = "Click to create an outgoing mail register";
            this.whenEmptyCreateRegister.UseVisualStyleBackColor = true;
            this.whenEmptyCreateRegister.Visible = false;
            // 
            // OutgoingDetailView
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
            this.Controls.Add(this.model_ArchiveLocation);
            this.Controls.Add(this.archiveLocationLabel);
            this.Controls.Add(this.model_Notes);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.model_SendDate);
            this.Controls.Add(this.sendDateLabel);
            this.Controls.Add(this.model_RecipientName);
            this.Controls.Add(this.recipientNameLabel);
            this.Controls.Add(this.model_RecipientTown);
            this.Controls.Add(this.recipientTownLabel);
            this.Controls.Add(this.detailToolStrip);
            this.DoubleBuffered = true;
            this.Name = "OutgoingDetailView";
            this.Size = new System.Drawing.Size(1008, 294);
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
        private System.Windows.Forms.TextBox model_Subject;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox model_SendDate;
        private System.Windows.Forms.Label sendDateLabel;
        private System.Windows.Forms.TextBox model_RecipientName;
        private System.Windows.Forms.Label recipientNameLabel;
        private System.Windows.Forms.TextBox model_RecipientTown;
        private System.Windows.Forms.Label recipientTownLabel;
        private System.Windows.Forms.TextBox model_Notes;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox model_ArchiveLocation;
        private System.Windows.Forms.Label archiveLocationLabel;
        private System.Windows.Forms.Label audit;
        private System.Windows.Forms.ToolTip toolTip;
        private CslaContrib.Windows.ErrorWarnInfoProvider errorWarnInfoProvider;
        private System.Windows.Forms.Label verticalDivider1;
        private System.Windows.Forms.Label verticalDivider2;
        private System.Windows.Forms.Button whenEmptyCreateRegister;
    }
}
