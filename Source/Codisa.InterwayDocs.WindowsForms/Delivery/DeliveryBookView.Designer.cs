namespace Codisa.InterwayDocs.Delivery
{
    partial class DeliveryBookView
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorWarnInfoProvider = new CslaContrib.Windows.ErrorWarnInfoProvider(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.displayName = new System.Windows.Forms.Label();
            this.headerImageLabel = new System.Windows.Forms.Label();
            this.headerMessage = new System.Windows.Forms.Label();
            this.fastDate = new System.Windows.Forms.ComboBox();
            this.toggleSearchArea = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.fullTextLabel = new System.Windows.Forms.Label();
            this.criteria_FullText = new System.Windows.Forms.TextBox();
            this.dateTypeLabel = new System.Windows.Forms.Label();
            this.dateType = new System.Windows.Forms.ComboBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.criteria_StartDate = new System.Windows.Forms.TextBox();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.criteria_EndDate = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.listNavigator = new System.Windows.Forms.ToolStrip();
            this.panelTitle = new System.Windows.Forms.ToolStripLabel();
            this.firstPage = new System.Windows.Forms.ToolStripButton();
            this.previousPage = new System.Windows.Forms.ToolStripButton();
            this.currentPage = new System.Windows.Forms.ToolStripTextBox();
            this.nextpage = new System.Windows.Forms.ToolStripButton();
            this.lastPage = new System.Windows.Forms.ToolStripButton();
            this.printList = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.registerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentReferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentEntityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expeditorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeItem = new MvvmFx.CaliburnMicro.ContentContainer();
            this.headerPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorWarnInfoProvider)).BeginInit();
            this.listNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // errorWarnInfoProvider
            // 
            this.errorWarnInfoProvider.ContainerControl = this;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.displayName);
            this.headerPanel.Controls.Add(this.headerImageLabel);
            this.headerPanel.Controls.Add(this.headerMessage);
            this.headerPanel.Controls.Add(this.fastDate);
            this.headerPanel.Controls.Add(this.toggleSearchArea);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1008, 40);
            this.headerPanel.TabIndex = 0;
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayName.Location = new System.Drawing.Point(60, 10);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(0, 22);
            this.displayName.TabStop = false;
            // 
            // headerImageLabel
            // 
            this.headerImageLabel.Image = global::Codisa.InterwayDocs.Properties.Resources.EmailView;
            this.headerImageLabel.Location = new System.Drawing.Point(20, 6);
            this.headerImageLabel.Name = "headerImageLabel";
            this.headerImageLabel.Size = new System.Drawing.Size(26, 26);
            this.headerImageLabel.TabStop = false;
            // 
            // headerMessage
            // 
            this.headerMessage.AutoSize = true;
            this.headerMessage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerMessage.Location = new System.Drawing.Point(450, 10);
            this.headerMessage.Name = "headerMessage";
            this.headerMessage.Size = new System.Drawing.Size(0, 22);
            this.headerMessage.TabStop = false;
            // 
            // fastDate
            // 
            this.fastDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fastDate.Location = new System.Drawing.Point(760, 10);
            this.fastDate.Name = "fastDate";
            this.fastDate.Size = new System.Drawing.Size(121, 21);
            this.fastDate.TabIndex = 1;
            this.toolTip.SetToolTip(this.fastDate, global::Codisa.InterwayDocs.Properties.Resources.FastDateToolTip);
            // 
            // toggleSearchArea
            // 
            this.toggleSearchArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleSearchArea.FlatAppearance.BorderSize = 0;
            this.toggleSearchArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleSearchArea.Image = global::Codisa.InterwayDocs.Properties.Resources.ArrowUp16;
            this.toggleSearchArea.Location = new System.Drawing.Point(972, 10);
            this.toggleSearchArea.Name = "toggleSearchArea";
            this.toggleSearchArea.Size = new System.Drawing.Size(23, 23);
            this.toggleSearchArea.TabIndex = 2;
            this.toolTip.SetToolTip(this.toggleSearchArea, global::Codisa.InterwayDocs.Properties.Resources.HideSearchPanel);
            this.toggleSearchArea.UseVisualStyleBackColor = true;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchPanel.Controls.Add(this.fullTextLabel);
            this.searchPanel.Controls.Add(this.criteria_FullText);
            this.searchPanel.Controls.Add(this.dateTypeLabel);
            this.searchPanel.Controls.Add(this.dateType);
            this.searchPanel.Controls.Add(this.startDateLabel);
            this.searchPanel.Controls.Add(this.criteria_StartDate);
            this.searchPanel.Controls.Add(this.endDateLabel);
            this.searchPanel.Controls.Add(this.criteria_EndDate);
            this.searchPanel.Controls.Add(this.search);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 40);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1008, 65);
            this.searchPanel.TabIndex = 3;
            // 
            // fullTextLabel
            // 
            this.fullTextLabel.AutoSize = true;
            this.fullTextLabel.Location = new System.Drawing.Point(22, 12);
            this.fullTextLabel.Name = "fullTextLabel";
            this.fullTextLabel.Size = new System.Drawing.Size(56, 13);
            this.fullTextLabel.TabStop = false;
            this.fullTextLabel.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelFullText;
            this.toolTip.SetToolTip(this.fullTextLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipFullText);
            // 
            // criteria_FullText
            // 
            this.criteria_FullText.Location = new System.Drawing.Point(85, 9);
            this.criteria_FullText.MaxLength = 100;
            this.criteria_FullText.Name = "criteria_FullText";
            this.criteria_FullText.Size = new System.Drawing.Size(504, 20);
            this.criteria_FullText.TabIndex = 4;
            this.criteria_FullText.Enter += new System.EventHandler(this.StoreLastActiveControl);
            this.criteria_FullText.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // dateTypeLabel
            // 
            this.dateTypeLabel.AutoSize = true;
            this.dateTypeLabel.Location = new System.Drawing.Point(22, 38);
            this.dateTypeLabel.Name = "dateTypeLabel";
            this.dateTypeLabel.Size = new System.Drawing.Size(35, 13);
            this.dateTypeLabel.TabStop = false;
            this.dateTypeLabel.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelDates;
            this.toolTip.SetToolTip(this.dateTypeLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipDates);
            // 
            // dateType
            // 
            this.dateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateType.Location = new System.Drawing.Point(85, 35);
            this.dateType.Name = "dateType";
            this.dateType.Size = new System.Drawing.Size(164, 21);
            this.dateType.TabIndex = 6;
            // 
            // startDateLabel
            // 
            this.startDateLabel.Location = new System.Drawing.Point(282, 38);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(40, 13);
            this.startDateLabel.TabStop = false;
            this.startDateLabel.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelStartDate;
            this.startDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip.SetToolTip(this.startDateLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipStartDate);
            // 
            // criteria_StartDate
            // 
            this.criteria_StartDate.Location = new System.Drawing.Point(325, 35);
            this.criteria_StartDate.MaxLength = 10;
            this.criteria_StartDate.Name = "criteria_StartDate";
            this.criteria_StartDate.Size = new System.Drawing.Size(100, 20);
            this.criteria_StartDate.TabIndex = 7;
            this.criteria_StartDate.Enter += new System.EventHandler(this.StoreLastActiveControl);
            this.criteria_StartDate.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // endDateLabel
            // 
            this.endDateLabel.Location = new System.Drawing.Point(446, 38);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(40, 13);
            this.endDateLabel.TabStop = false;
            this.endDateLabel.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelEndDate;
            this.endDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip.SetToolTip(this.endDateLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipEndDate);
            // 
            // criteria_EndDate
            // 
            this.criteria_EndDate.Location = new System.Drawing.Point(489, 35);
            this.criteria_EndDate.MaxLength = 10;
            this.criteria_EndDate.Name = "criteria_EndDate";
            this.criteria_EndDate.Size = new System.Drawing.Size(100, 20);
            this.criteria_EndDate.TabIndex = 8;
            this.criteria_EndDate.Enter += new System.EventHandler(this.StoreLastActiveControl);
            this.criteria_EndDate.MouseLeave += new System.EventHandler(this.ForceValidation);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(920, 32);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 9;
            this.search.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelSearch;
            this.search.UseVisualStyleBackColor = true;
            this.search.MouseHover += new System.EventHandler(this.ForceValidation);
            // 
            // listNavigator
            // 
            this.listNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelTitle,
            this.firstPage,
            this.previousPage,
            this.currentPage,
            this.nextpage,
            this.lastPage,
            this.printList});
            this.listNavigator.Location = new System.Drawing.Point(0, 105);
            this.listNavigator.Name = "listNavigator";
            this.listNavigator.Size = new System.Drawing.Size(1008, 25);
            this.listNavigator.TabIndex = 10;
            // 
            // panelTitle
            // 
            this.panelTitle.AutoSize = false;
            this.panelTitle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(200, 22);
            this.panelTitle.Text = "panelTitle";
            this.panelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstPage
            // 
            this.firstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstPage.Enabled = false;
            this.firstPage.Image = global::Codisa.InterwayDocs.Properties.Resources.MoveFirst16;
            this.firstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.firstPage.Name = "firstPage";
            this.firstPage.Size = new System.Drawing.Size(23, 22);
            this.firstPage.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipFirstPage;
            // 
            // previousPage
            // 
            this.previousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.previousPage.Enabled = false;
            this.previousPage.Image = global::Codisa.InterwayDocs.Properties.Resources.MoveBack16;
            this.previousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(23, 22);
            this.previousPage.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipPreviousPage;
            // 
            // currentPage
            // 
            this.currentPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentPage.Name = "currentPage";
            this.currentPage.ReadOnly = true;
            this.currentPage.Size = new System.Drawing.Size(50, 25);
            this.currentPage.Text = "1 / 1";
            this.currentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentPage.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipCurrentPageTotalPages;
            // 
            // nextpage
            // 
            this.nextpage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextpage.Enabled = false;
            this.nextpage.Image = global::Codisa.InterwayDocs.Properties.Resources.MoveNext16;
            this.nextpage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextpage.Name = "nextpage";
            this.nextpage.Size = new System.Drawing.Size(23, 22);
            this.nextpage.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipNextPage;
            // 
            // lastPage
            // 
            this.lastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastPage.Enabled = false;
            this.lastPage.Image = global::Codisa.InterwayDocs.Properties.Resources.MoveLast16;
            this.lastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lastPage.Name = "lastPage";
            this.lastPage.Size = new System.Drawing.Size(23, 22);
            this.lastPage.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipLastPage;
            // 
            // printList
            // 
            this.printList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.printList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printList.Image = global::Codisa.InterwayDocs.Properties.Resources.Excel;
            this.printList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printList.Name = "printList";
            this.printList.Size = new System.Drawing.Size(23, 22);
            this.printList.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipExportListExcel;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerIdDataGridViewTextBoxColumn,
            this.registerDateDataGridViewTextBoxColumn,
            this.documentTypeDataGridViewTextBoxColumn,
            this.documentReferenceDataGridViewTextBoxColumn,
            this.documentEntityDataGridViewTextBoxColumn,
            this.documentDeptDataGridViewTextBoxColumn,
            this.documentClassDataGridViewTextBoxColumn,
            this.documentDateDataGridViewTextBoxColumn,
            this.recipientNameDataGridViewTextBoxColumn,
            this.expeditorNameDataGridViewTextBoxColumn,
            this.receptionNameDataGridViewTextBoxColumn,
            this.receptionDateDataGridViewTextBoxColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 130);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1008, 268);
            this.dataGridView.TabIndex = 11;
            // 
            // registerIdDataGridViewTextBoxColumn
            // 
            this.registerIdDataGridViewTextBoxColumn.DataPropertyName = "RegisterId";
            this.registerIdDataGridViewTextBoxColumn.HeaderText = "N.º Ordem";
            this.registerIdDataGridViewTextBoxColumn.Name = "registerIdDataGridViewTextBoxColumn";
            this.registerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registerDateDataGridViewTextBoxColumn
            // 
            this.registerDateDataGridViewTextBoxColumn.DataPropertyName = "RegisterDate";
            this.registerDateDataGridViewTextBoxColumn.HeaderText = "Data reg.";
            this.registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
            this.registerDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentTypeDataGridViewTextBoxColumn
            // 
            this.documentTypeDataGridViewTextBoxColumn.DataPropertyName = "DocumentType";
            this.documentTypeDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.documentTypeDataGridViewTextBoxColumn.Name = "documentTypeDataGridViewTextBoxColumn";
            this.documentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentReferenceDataGridViewTextBoxColumn
            // 
            this.documentReferenceDataGridViewTextBoxColumn.DataPropertyName = "DocumentReference";
            this.documentReferenceDataGridViewTextBoxColumn.HeaderText = "Nº documento";
            this.documentReferenceDataGridViewTextBoxColumn.Name = "documentReferenceDataGridViewTextBoxColumn";
            this.documentReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentEntityDataGridViewTextBoxColumn
            // 
            this.documentEntityDataGridViewTextBoxColumn.DataPropertyName = "DocumentEntity";
            this.documentEntityDataGridViewTextBoxColumn.HeaderText = "Entidade";
            this.documentEntityDataGridViewTextBoxColumn.Name = "documentEntityDataGridViewTextBoxColumn";
            this.documentEntityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentDeptDataGridViewTextBoxColumn
            // 
            this.documentDeptDataGridViewTextBoxColumn.DataPropertyName = "DocumentDept";
            this.documentDeptDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.documentDeptDataGridViewTextBoxColumn.Name = "documentDeptDataGridViewTextBoxColumn";
            this.documentDeptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentClassDataGridViewTextBoxColumn
            // 
            this.documentClassDataGridViewTextBoxColumn.DataPropertyName = "DocumentClass";
            this.documentClassDataGridViewTextBoxColumn.HeaderText = "Classificação";
            this.documentClassDataGridViewTextBoxColumn.Name = "documentClassDataGridViewTextBoxColumn";
            this.documentClassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentDateDataGridViewTextBoxColumn
            // 
            this.documentDateDataGridViewTextBoxColumn.DataPropertyName = "DocumentDate";
            this.documentDateDataGridViewTextBoxColumn.HeaderText = "Data doc.";
            this.documentDateDataGridViewTextBoxColumn.Name = "documentDateDataGridViewTextBoxColumn";
            this.documentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recipientNameDataGridViewTextBoxColumn
            // 
            this.recipientNameDataGridViewTextBoxColumn.DataPropertyName = "RecipientName";
            this.recipientNameDataGridViewTextBoxColumn.HeaderText = "Destinatário";
            this.recipientNameDataGridViewTextBoxColumn.Name = "recipientNameDataGridViewTextBoxColumn";
            this.recipientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expeditorNameDataGridViewTextBoxColumn
            // 
            this.expeditorNameDataGridViewTextBoxColumn.DataPropertyName = "ExpeditorName";
            this.expeditorNameDataGridViewTextBoxColumn.HeaderText = "Expedido";
            this.expeditorNameDataGridViewTextBoxColumn.Name = "expeditorNameDataGridViewTextBoxColumn";
            this.expeditorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptionNameDataGridViewTextBoxColumn
            // 
            this.receptionNameDataGridViewTextBoxColumn.DataPropertyName = "ReceptionName";
            this.receptionNameDataGridViewTextBoxColumn.HeaderText = "Recebido";
            this.receptionNameDataGridViewTextBoxColumn.Name = "receptionNameDataGridViewTextBoxColumn";
            this.receptionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptionDateDataGridViewTextBoxColumn
            // 
            this.receptionDateDataGridViewTextBoxColumn.DataPropertyName = "ReceptionDate";
            this.receptionDateDataGridViewTextBoxColumn.HeaderText = "Data recepção";
            this.receptionDateDataGridViewTextBoxColumn.Name = "receptionDateDataGridViewTextBoxColumn";
            this.receptionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeItem
            // 
            this.activeItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.activeItem.Location = new System.Drawing.Point(0, 401);
            this.activeItem.Name = "activeItem";
            this.activeItem.Size = new System.Drawing.Size(1008, 242);
            this.activeItem.TabIndex = 12;
            // 
            // DeliveryBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.activeItem);
            this.Controls.Add(this.listNavigator);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.headerPanel);
            this.DoubleBuffered = true;
            this.Name = "DeliveryBookView";
            this.Size = new System.Drawing.Size(1008, 643);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorWarnInfoProvider)).EndInit();
            this.listNavigator.ResumeLayout(false);
            this.listNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private CslaContrib.Windows.ErrorWarnInfoProvider errorWarnInfoProvider;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label displayName;
        private System.Windows.Forms.Label headerImageLabel;
        private System.Windows.Forms.Label headerMessage;
        private System.Windows.Forms.ComboBox fastDate;
        private System.Windows.Forms.Button toggleSearchArea;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label fullTextLabel;
        private System.Windows.Forms.TextBox criteria_FullText;
        private System.Windows.Forms.Label dateTypeLabel;
        private System.Windows.Forms.ComboBox dateType;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.TextBox criteria_EndDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.TextBox criteria_StartDate;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ToolStrip listNavigator;
        private System.Windows.Forms.ToolStripLabel panelTitle;
        private System.Windows.Forms.ToolStripButton firstPage;
        private System.Windows.Forms.ToolStripButton previousPage;
        private System.Windows.Forms.ToolStripTextBox currentPage;
        private System.Windows.Forms.ToolStripButton nextpage;
        private System.Windows.Forms.ToolStripButton lastPage;
        private System.Windows.Forms.ToolStripButton printList;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentReferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentEntityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expeditorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionDateDataGridViewTextBoxColumn;
        private MvvmFx.CaliburnMicro.ContentContainer activeItem;
    }
}
