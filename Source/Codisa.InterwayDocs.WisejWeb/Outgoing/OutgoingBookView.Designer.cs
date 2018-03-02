using System.Drawing;

namespace Codisa.InterwayDocs.Outgoing
{
    partial class OutgoingBookView
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            this.components = new System.ComponentModel.Container();
            this.toolTip = new Wisej.Web.ToolTip(this.components);
            this.errorWarnInfoProvider = new CslaContrib.WisejWeb.ErrorWarnInfoProvider(this.components);
            this.headerPanel = new Wisej.Web.Panel();
            this.displayName = new Wisej.Web.Label();
            this.headerImageLabel = new Wisej.Web.Label();
            this.headerMessage = new Wisej.Web.Label();
            this.fastDate = new Wisej.Web.ComboBox();
            this.toggleSearchArea = new Wisej.Web.Button();
            this.searchPanel = new Wisej.Web.Panel();
            this.fullTextLabel = new Wisej.Web.Label();
            this.criteria_FullText = new Wisej.Web.TextBox();
            this.archiveLocationLabel = new Wisej.Web.Label();
            this.criteria_ArchiveLocation = new Wisej.Web.TextBox();
            this.dateTypeLabel = new Wisej.Web.Label();
            this.dateType = new Wisej.Web.ComboBox();
            this.startDateLabel = new Wisej.Web.Label();
            this.criteria_StartDate = new Wisej.Web.TextBox();
            this.endDateLabel = new Wisej.Web.Label();
            this.criteria_EndDate = new Wisej.Web.TextBox();
            this.search = new Wisej.Web.Button();
            this.listNavigator = new MvvmFx.CaliburnMicro.WisejWeb.Toolable.PanelEx();
            this.printList = new MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx();
            this.dataGridView = new Wisej.Web.DataGridView();
            this.registerIdDataGridViewTextBoxColumn = new Wisej.Web.DataGridViewTextBoxColumn();
            this.registerDateDataGridViewTextBoxColumn = new Wisej.Web.DataGridViewTextBoxColumn();
            this.documentTypeDataGridViewTextBoxColumn = new Wisej.Web.DataGridViewTextBoxColumn();
            this.documentReferenceDataGridViewTextBoxColumn = new Wisej.Web.DataGridViewTextBoxColumn();
            this.documentEntityDataGridViewTextBoxColumn = new Wisej.Web.DataGridViewTextBoxColumn();
            this.documentDeptDataGridViewTextBoxColumn = new Wisej.Web.DataGridViewTextBoxColumn();
            this.documentClassDataGridViewTextBoxColumn = new Wisej.Web.DataGridViewTextBoxColumn();
            this.documentDateDataGridViewTextBoxColumn = new Wisej.Web.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new Wisej.Web.DataGridViewTextBoxColumn();
            this.recipientNameDataGridViewTextBoxColumn = new Wisej.Web.DataGridViewTextBoxColumn();
            this.sendDateDataGridViewTextBoxColumn = new Wisej.Web.DataGridViewTextBoxColumn();
            this.recipientTownDataGridViewTextBoxColumn = new Wisej.Web.DataGridViewTextBoxColumn();
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
            this.headerPanel.Dock = Wisej.Web.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1004, 40);
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
            this.fastDate.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.fastDate.Location = new System.Drawing.Point(760, 10);
            this.fastDate.Name = "fastDate";
            this.fastDate.Size = new System.Drawing.Size(121, 21);
            this.fastDate.TabIndex = 1;
            this.toolTip.SetToolTip(this.fastDate, global::Codisa.InterwayDocs.Properties.Resources.FastDateToolTip);
            // 
            // toggleSearchArea
            // 
            this.toggleSearchArea.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.toggleSearchArea.Image = global::Codisa.InterwayDocs.Properties.Resources.ArrowUp16;
            this.toggleSearchArea.Location = new System.Drawing.Point(972, 10);
            this.toggleSearchArea.Name = "toggleSearchArea";
            this.toggleSearchArea.Size = new System.Drawing.Size(23, 23);
            this.toggleSearchArea.TabIndex = 2;
            this.toolTip.SetToolTip(this.toggleSearchArea, global::Codisa.InterwayDocs.Properties.Resources.HideSearchPanel);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchPanel.Controls.Add(this.fullTextLabel);
            this.searchPanel.Controls.Add(this.criteria_FullText);
            this.searchPanel.Controls.Add(this.archiveLocationLabel);
            this.searchPanel.Controls.Add(this.criteria_ArchiveLocation);
            this.searchPanel.Controls.Add(this.dateTypeLabel);
            this.searchPanel.Controls.Add(this.dateType);
            this.searchPanel.Controls.Add(this.startDateLabel);
            this.searchPanel.Controls.Add(this.criteria_StartDate);
            this.searchPanel.Controls.Add(this.endDateLabel);
            this.searchPanel.Controls.Add(this.criteria_EndDate);
            this.searchPanel.Controls.Add(this.search);
            this.searchPanel.Dock = Wisej.Web.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 40);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1004, 65);
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
            // archiveLocationLabel
            // 
            this.archiveLocationLabel.Location = new System.Drawing.Point(684, 12);
            this.archiveLocationLabel.Name = "archiveLocationLabel";
            this.archiveLocationLabel.Size = new System.Drawing.Size(70, 13);
            this.archiveLocationLabel.TabStop = false;
            this.archiveLocationLabel.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelArchiveLocation;
            this.archiveLocationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip.SetToolTip(this.archiveLocationLabel, global::Codisa.InterwayDocs.Properties.Resources.ToolTipLocation);
            // 
            // criteria_ArchiveLocation
            // 
            this.criteria_ArchiveLocation.Location = new System.Drawing.Point(762, 9);
            this.criteria_ArchiveLocation.MaxLength = 50;
            this.criteria_ArchiveLocation.Name = "criteria_ArchiveLocation";
            this.criteria_ArchiveLocation.Size = new System.Drawing.Size(100, 20);
            this.criteria_ArchiveLocation.TabIndex = 5;
            this.criteria_ArchiveLocation.Enter += new System.EventHandler(this.StoreLastActiveControl);
            this.criteria_ArchiveLocation.MouseLeave += new System.EventHandler(this.ForceValidation);
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
            this.dateType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.dateType.Location = new System.Drawing.Point(85, 35);
            this.dateType.Name = "dateType";
            this.dateType.Size = new System.Drawing.Size(164, 21);
            this.dateType.TabIndex = 6;
            // 
            // startDateLabel
            // 
            this.startDateLabel.Location = new System.Drawing.Point(277, 38);
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
            this.endDateLabel.Location = new System.Drawing.Point(441, 38);
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
            this.toolTip.SetToolTip(this.search, null);
            // 
            // listNavigator
            // 
            this.listNavigator.Dock = Wisej.Web.DockStyle.Top;
            this.listNavigator.Controls.Add(this.dataGridView);
            this.listNavigator.Tools.AddRange(new MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx[] {
            this.printList});
            this.listNavigator.HeaderBackColor = System.Drawing.Color.FromName("@toolbar");
            this.listNavigator.HeaderForeColor = System.Drawing.Color.FromName("@toolbarText");
            this.listNavigator.Location = new System.Drawing.Point(0, 105);
            this.listNavigator.Name = "listNavigator";
            this.listNavigator.Text = "listNavigator";
            this.listNavigator.ShowCloseButton = false;
            this.listNavigator.ShowHeader = true;
            this.listNavigator.Size = new System.Drawing.Size(1004, 169);
            this.listNavigator.TabIndex = 10;
            // 
            // printList
            // 
            this.printList.Image = global::Codisa.InterwayDocs.Properties.Resources.Excel;
            this.printList.Name = "printList";
            this.printList.ToolTipText = global::Codisa.InterwayDocs.Properties.Resources.ToolTipExportListExcel;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.registerIdDataGridViewTextBoxColumn,
            this.registerDateDataGridViewTextBoxColumn,
            this.documentTypeDataGridViewTextBoxColumn,
            this.documentReferenceDataGridViewTextBoxColumn,
            this.documentEntityDataGridViewTextBoxColumn,
            this.documentDeptDataGridViewTextBoxColumn,
            this.documentClassDataGridViewTextBoxColumn,
            this.documentDateDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.recipientNameDataGridViewTextBoxColumn,
            this.sendDateDataGridViewTextBoxColumn,
            this.recipientTownDataGridViewTextBoxColumn});
            this.dataGridView.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 130);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowColumnVisibilityMenu = false;
            this.dataGridView.Size = new System.Drawing.Size(1004, 219);
            this.dataGridView.TabIndex = 11;
            // 
            // registerIdDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.registerIdDataGridViewTextBoxColumn.DataPropertyName = "RegisterId";
            this.registerIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;this.registerIdDataGridViewTextBoxColumn.DataPropertyName = "RegisterId";
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
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Assunto";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sendDateDataGridViewTextBoxColumn
            // 
            this.sendDateDataGridViewTextBoxColumn.DataPropertyName = "SendDate";
            this.sendDateDataGridViewTextBoxColumn.HeaderText = "Data expedição";
            this.sendDateDataGridViewTextBoxColumn.Name = "sendDateDataGridViewTextBoxColumn";
            this.sendDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recipientNameDataGridViewTextBoxColumn
            // 
            this.recipientNameDataGridViewTextBoxColumn.DataPropertyName = "RecipientName";
            this.recipientNameDataGridViewTextBoxColumn.HeaderText = "Destinatário";
            this.recipientNameDataGridViewTextBoxColumn.Name = "recipientNameDataGridViewTextBoxColumn";
            this.recipientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recipientTownDataGridViewTextBoxColumn
            // 
            this.recipientTownDataGridViewTextBoxColumn.DataPropertyName = "RecipientTown";
            this.recipientTownDataGridViewTextBoxColumn.HeaderText = "Localidade";
            this.recipientTownDataGridViewTextBoxColumn.Name = "recipientTownDataGridViewTextBoxColumn";
            this.recipientTownDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeItem
            // 
            this.activeItem.Dock = Wisej.Web.DockStyle.Bottom;
            this.activeItem.Location = new System.Drawing.Point(0, 349);
            this.activeItem.Name = "activeItem";
            this.activeItem.Size = new System.Drawing.Size(1004, 294);
            this.activeItem.TabIndex = 12;
            // 
            // OutgoingBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            //this.BackColor = Color.DeepPink;
            this.Controls.Add(this.activeItem);
            this.Controls.Add(this.listNavigator);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "OutgoingBookView";
            this.Size = new System.Drawing.Size(1004, 568);
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

        private Wisej.Web.ToolTip toolTip;
        private CslaContrib.WisejWeb.ErrorWarnInfoProvider errorWarnInfoProvider;
        private Wisej.Web.Panel headerPanel;
        private Wisej.Web.Label displayName;
        private Wisej.Web.Label headerImageLabel;
        private Wisej.Web.Label headerMessage;
        private Wisej.Web.ComboBox fastDate;
        private Wisej.Web.Button toggleSearchArea;
        private Wisej.Web.Panel searchPanel;
        private Wisej.Web.Label fullTextLabel;
        private Wisej.Web.TextBox criteria_FullText;
        private Wisej.Web.Label archiveLocationLabel;
        private Wisej.Web.TextBox criteria_ArchiveLocation;
        private Wisej.Web.Label dateTypeLabel;
        private Wisej.Web.ComboBox dateType;
        private Wisej.Web.Label endDateLabel;
        private Wisej.Web.TextBox criteria_EndDate;
        private Wisej.Web.Label startDateLabel;
        private Wisej.Web.TextBox criteria_StartDate;
        private Wisej.Web.Button search;
        private MvvmFx.CaliburnMicro.WisejWeb.Toolable.PanelEx listNavigator;
        private MvvmFx.CaliburnMicro.WisejWeb.Toolable.ComponentToolEx printList;
        private Wisej.Web.DataGridView dataGridView;
        private Wisej.Web.DataGridViewTextBoxColumn registerIdDataGridViewTextBoxColumn;
        private Wisej.Web.DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
        private Wisej.Web.DataGridViewTextBoxColumn documentTypeDataGridViewTextBoxColumn;
        private Wisej.Web.DataGridViewTextBoxColumn documentReferenceDataGridViewTextBoxColumn;
        private Wisej.Web.DataGridViewTextBoxColumn documentEntityDataGridViewTextBoxColumn;
        private Wisej.Web.DataGridViewTextBoxColumn documentDeptDataGridViewTextBoxColumn;
        private Wisej.Web.DataGridViewTextBoxColumn documentClassDataGridViewTextBoxColumn;
        private Wisej.Web.DataGridViewTextBoxColumn documentDateDataGridViewTextBoxColumn;
        private Wisej.Web.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private Wisej.Web.DataGridViewTextBoxColumn recipientNameDataGridViewTextBoxColumn;
        private Wisej.Web.DataGridViewTextBoxColumn sendDateDataGridViewTextBoxColumn;
        private Wisej.Web.DataGridViewTextBoxColumn recipientTownDataGridViewTextBoxColumn;
        private MvvmFx.CaliburnMicro.ContentContainer activeItem;
    }
}
