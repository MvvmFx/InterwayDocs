﻿namespace Codisa.InterwayDocs
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
            this.mainMenu = new Wisej.Web.MenuBar();
            this.openIncomingBook = new Wisej.Web.MenuItem();
            this.openOutgoingBook = new Wisej.Web.MenuItem();
            this.openDeliveryBook = new Wisej.Web.MenuItem();
            this.toolsMenuItem = new Wisej.Web.MenuItem();
            this.backup = new Wisej.Web.MenuItem();
            this.restore = new Wisej.Web.MenuItem();
            this.export = new Wisej.Web.MenuItem();
            this.import = new Wisej.Web.MenuItem();
            this.helpMenuItem = new Wisej.Web.MenuItem();
            this.about = new Wisej.Web.MenuItem();
            this.pdfManual = new Wisej.Web.MenuItem();
            this.statusBar = new Wisej.Web.StatusBar();
            this.placeHolder = new Wisej.Web.StatusBarPanel();
            this.activeItem = new MvvmFx.CaliburnMicro.ContentContainer();
            this.busyIndicator = new Codisa.InterwayDocs.Framework.BusyIndicator();
            //this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Dock = Wisej.Web.DockStyle.Top;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.openIncomingBook,
            this.openOutgoingBook,
            this.openDeliveryBook,
            this.toolsMenuItem,
            this.helpMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1008, 22);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.TabStop = false;
            // 
            // openIncomingBook
            // 
            this.openIncomingBook.Name = "openIncomingBook";
            this.openIncomingBook.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelIncoming;
            // 
            // openOutgoingBook
            // 
            this.openOutgoingBook.Name = "openOutgoingBook";
            this.openOutgoingBook.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelOutgoing;
            // 
            // openDeliveryBook
            // 
            this.openDeliveryBook.Name = "openDeliveryBook";
            this.openDeliveryBook.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelDelivery;
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.backup,
            this.restore,
            this.export,
            this.import});
            this.toolsMenuItem.Name = "toolsMenuItem";
            this.toolsMenuItem.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelTools;
            this.toolsMenuItem.Visible = false;
            // 
            // backup
            // 
            this.backup.Name = "backup";
            this.backup.Text = global::Codisa.InterwayDocs.Properties.Resources.ToolsBackupLabel;
            // 
            // restore
            // 
            this.restore.Name = "restore";
            this.restore.Text = global::Codisa.InterwayDocs.Properties.Resources.ToolsRestoreLabel;
            // 
            // export
            // 
            this.export.Name = "export";
            this.export.Text = global::Codisa.InterwayDocs.Properties.Resources.ToolsExportlabel;
            // 
            // import
            // 
            this.import.Name = "import";
            this.import.Text = global::Codisa.InterwayDocs.Properties.Resources.ToolsImportLabel;
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.about,
            this.pdfManual});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelHelp;
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelAboutApplication;
            // 
            // pdfManual
            // 
            this.pdfManual.Name = "pdfManual";
            this.pdfManual.Text = global::Codisa.InterwayDocs.Properties.Resources.LabelDocumentation;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 667);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new Wisej.Web.StatusBarPanel[] {
            this.placeHolder});
            this.statusBar.Size = new System.Drawing.Size(1008, 22);
            this.statusBar.TabIndex = 1;
            // 
            // placeHolder
            // 
            this.placeHolder.AutoSize = Wisej.Web.StatusBarPanelAutoSize.Spring;
            this.placeHolder.Name = "placeHolder";
            // 
            // activeItem
            // 
            this.activeItem.Dock = Wisej.Web.DockStyle.Fill;
            this.activeItem.Location = new System.Drawing.Point(0, 24);
            this.activeItem.Name = "activeItem";
            this.activeItem.Size = new System.Drawing.Size(1008, 643);
            this.activeItem.TabIndex = 2;
            // 
            // busyIndicator
            // 
            this.busyIndicator.BackColor = System.Drawing.SystemColors.Window;
            this.busyIndicator.BorderStyle = Wisej.Web.BorderStyle.Solid;
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
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 689);
            this.Controls.Add(this.busyIndicator);
            this.Controls.Add(this.activeItem);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            //this.DoubleBuffered = true;
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            //this.MainMenu = this.mainMenu;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 728);
            this.Name = "MainForm";
            //this.mainMenu.ResumeLayout(false);
            //this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.MenuBar mainMenu;
        private Wisej.Web.StatusBar statusBar;
        private Wisej.Web.StatusBarPanel placeHolder;
        private Wisej.Web.MenuItem openIncomingBook;
        private Wisej.Web.MenuItem openOutgoingBook;
        private Wisej.Web.MenuItem openDeliveryBook;
        private Wisej.Web.MenuItem toolsMenuItem;
        private Wisej.Web.MenuItem backup;
        private Wisej.Web.MenuItem restore;
        private Wisej.Web.MenuItem export;
        private Wisej.Web.MenuItem import;
        private Wisej.Web.MenuItem helpMenuItem;
        private Wisej.Web.MenuItem about;
        private Wisej.Web.MenuItem pdfManual;
        private MvvmFx.CaliburnMicro.ContentContainer activeItem;
        private Framework.BusyIndicator busyIndicator;
    }
}