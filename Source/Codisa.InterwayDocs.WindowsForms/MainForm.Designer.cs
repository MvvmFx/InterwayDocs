namespace Codisa.InterwayDocs
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.openIncomingBook = new System.Windows.Forms.ToolStripMenuItem();
            this.openOutgoingBook = new System.Windows.Forms.ToolStripMenuItem();
            this.openDeliveryBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backup = new System.Windows.Forms.ToolStripMenuItem();
            this.restore = new System.Windows.Forms.ToolStripMenuItem();
            this.export = new System.Windows.Forms.ToolStripMenuItem();
            this.import = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.language = new System.Windows.Forms.ToolStripComboBox();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfManual = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.activeItem = new MvvmFx.CaliburnMicro.ContentContainer();
            this.busyIndicator = new Codisa.InterwayDocs.Framework.BusyIndicator();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openIncomingBook,
            this.openOutgoingBook,
            this.openDeliveryBook,
            this.toolsMenuItem,
            this.helpMenuItem,
            this.language,
            this.languageLabel});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1008, 27);
            this.mainMenu.TabIndex = 0;
            // 
            // openIncomingBook
            // 
            this.openIncomingBook.Name = "openIncomingBook";
            this.openIncomingBook.Size = new System.Drawing.Size(70, 23);
            this.openIncomingBook.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelIncoming;
            // 
            // openOutgoingBook
            // 
            this.openOutgoingBook.Name = "openOutgoingBook";
            this.openOutgoingBook.Size = new System.Drawing.Size(70, 23);
            this.openOutgoingBook.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelOutgoing;
            // 
            // openDeliveryBook
            // 
            this.openDeliveryBook.Name = "openDeliveryBook";
            this.openDeliveryBook.Size = new System.Drawing.Size(61, 23);
            this.openDeliveryBook.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelDelivery;
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backup,
            this.restore,
            this.export,
            this.import});
            this.toolsMenuItem.Name = "toolsMenuItem";
            this.toolsMenuItem.Size = new System.Drawing.Size(47, 23);
            this.toolsMenuItem.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelTools;
            this.toolsMenuItem.Visible = false;
            // 
            // backup
            // 
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(181, 22);
            this.backup.Text = global::Codisa.InterwayDocs.Properties.Resources.ToolsBackupLabel;
            // 
            // restore
            // 
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(181, 22);
            this.restore.Text = global::Codisa.InterwayDocs.Properties.Resources.ToolsRestoreLabel;
            // 
            // export
            // 
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(181, 22);
            this.export.Text = global::Codisa.InterwayDocs.Properties.Resources.ToolsExportlabel;
            // 
            // import
            // 
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(181, 22);
            this.import.Text = global::Codisa.InterwayDocs.Properties.Resources.ToolsImportLabel;
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Left;
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about,
            this.pdfManual});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpMenuItem.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelHelp;
            // 
            // languageLabel
            // 
            this.languageLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(71, 23);
            this.languageLabel.Text = global::Codisa.InterwayDocs.Properties.Resources.Language;
            // 
            // language
            // 
            this.language.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(121, 23);
            this.language.SelectedIndexChanged += new System.EventHandler(this.language_SelectedIndexChanged);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(181, 22);
            this.about.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelAboutApplication;
            // 
            // pdfManual
            // 
            this.pdfManual.Name = "pdfManual";
            this.pdfManual.Size = new System.Drawing.Size(181, 22);
            this.pdfManual.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelDocumentation;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 667);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1008, 22);
            this.statusBar.TabIndex = 1;
            // 
            // activeItem
            // 
            this.activeItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeItem.Location = new System.Drawing.Point(0, 27);
            this.activeItem.Name = "activeItem";
            this.activeItem.Size = new System.Drawing.Size(1008, 640);
            this.activeItem.TabIndex = 2;
            // 
            // busyIndicator
            // 
            this.busyIndicator.BackColor = System.Drawing.SystemColors.Window;
            this.busyIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.busyIndicator.BusyContent = "Message";
            this.busyIndicator.IsBusy = false;
            this.busyIndicator.Location = new System.Drawing.Point(407, 303);
            this.busyIndicator.Name = "busyIndicator";
            this.busyIndicator.Size = new System.Drawing.Size(193, 114);
            this.busyIndicator.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 689);
            this.Controls.Add(this.busyIndicator);
            this.Controls.Add(this.activeItem);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 728);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem openIncomingBook;
        private System.Windows.Forms.ToolStripMenuItem openOutgoingBook;
        private System.Windows.Forms.ToolStripMenuItem openDeliveryBook;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backup;
        private System.Windows.Forms.ToolStripMenuItem restore;
        private System.Windows.Forms.ToolStripMenuItem export;
        private System.Windows.Forms.ToolStripMenuItem import;
        private System.Windows.Forms.ToolStripMenuItem languageLabel;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripComboBox language;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem pdfManual;
        private MvvmFx.CaliburnMicro.ContentContainer activeItem;
        private Framework.BusyIndicator busyIndicator;
    }
}