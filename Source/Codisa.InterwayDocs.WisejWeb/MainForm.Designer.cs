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
            this.mainMenu = new Wisej.Web.ToolBar();
            this.openIncomingBook = new Wisej.Web.ToolBarButton();
            this.openOutgoingBook = new Wisej.Web.ToolBarButton();
            this.openDeliveryBook = new Wisej.Web.ToolBarButton();
            this.toolsMenuItem = new Wisej.Web.ToolBarButton();
            this.toolsMenu = new Wisej.Web.ContextMenu();
            this.backup = new Wisej.Web.MenuItem();
            this.restore = new Wisej.Web.MenuItem();
            this.export = new Wisej.Web.MenuItem();
            this.import = new Wisej.Web.MenuItem();
            this.helpMenuItem = new Wisej.Web.ToolBarButton();
            this.helpMenu = new Wisej.Web.ContextMenu();
            this.about = new Wisej.Web.MenuItem();
            this.pdfManual = new Wisej.Web.MenuItem();
            this.language = new Wisej.Web.ComboBox();
            this.languageLabel = new Wisej.Web.Label();
            this.statusBar = new Wisej.Web.StatusBar();
            this.activeItem = new MvvmFx.CaliburnMicro.ContentContainer();
            this.busyIndicator = new Codisa.InterwayDocs.Framework.BusyIndicator();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Dock = Wisej.Web.DockStyle.Top;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
            this.openIncomingBook,
            this.openOutgoingBook,
            this.openDeliveryBook,
            this.toolsMenuItem,
            this.helpMenuItem});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1006, 26);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.TabStop = false;
            // 
            // openIncomingBook
            // 
            this.openIncomingBook.Name = "openIncomingBook";
            this.openIncomingBook.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
            this.openIncomingBook.Text = "Incoming";
            // 
            // openOutgoingBook
            // 
            this.openOutgoingBook.Name = "openOutgoingBook";
            this.openOutgoingBook.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
            this.openOutgoingBook.Text = "Outgoing";
            // 
            // openDeliveryBook
            // 
            this.openDeliveryBook.Name = "openDeliveryBook";
            this.openDeliveryBook.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
            this.openDeliveryBook.Text = "Delivery";
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.DropDownMenu = this.toolsMenu;
            this.toolsMenuItem.Name = "toolsMenuItem";
            this.toolsMenuItem.Style = Wisej.Web.ToolBarButtonStyle.DropDownButton;
            this.toolsMenuItem.Text = "Tools";
            this.toolsMenuItem.Visible = false;
            // 
            // toolsMenu
            // 
            this.toolsMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.backup,
            this.restore,
            this.export,
            this.import});
            this.toolsMenu.Name = "toolsMenu";
            // 
            // backup
            // 
            this.backup.Index = 0;
            this.backup.Name = "backup";
            this.backup.Text = "Make a data backup";
            // 
            // restore
            // 
            this.restore.Index = 1;
            this.restore.Name = "restore";
            this.restore.Text = "Restore data backup";
            // 
            // export
            // 
            this.export.Index = 2;
            this.export.Name = "export";
            this.export.Text = "Export data";
            // 
            // import
            // 
            this.import.Index = 3;
            this.import.Name = "import";
            this.import.Text = "Import data";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownMenu = this.helpMenu;
            this.helpMenuItem.Style = Wisej.Web.ToolBarButtonStyle.DropDownButton;
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Text = "Help";
            // 
            // helpMenu
            // 
            this.helpMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.about,
            this.pdfManual});
            this.helpMenu.Name = "helpMenu";
            // 
            // about
            // 
            this.about.Index = 0;
            this.about.Name = "about";
            this.about.Text = "About InterwayDocs";
            // 
            // pdfManual
            // 
            this.pdfManual.Index = 1;
            this.pdfManual.Name = "pdfManual";
            this.pdfManual.Text = "Show Manual (PDF)";
            // 
            // language
            // 
            this.language.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.language.Location = new System.Drawing.Point(886, 1);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(120, 20);
            this.language.TabIndex = 5;
            this.language.SelectedIndexChanged += new System.EventHandler(this.language_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.languageLabel.Location = new System.Drawing.Point(774, 5);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(100, 13);
            this.languageLabel.TabIndex = 4;
            this.languageLabel.Text = "Language";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 590);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1006, 22);
            this.statusBar.TabIndex = 1;
            // 
            // activeItem
            // 
            this.activeItem.Dock = Wisej.Web.DockStyle.Fill;
            this.activeItem.Location = new System.Drawing.Point(0, 22);
            this.activeItem.Name = "activeItem";
            this.activeItem.Size = new System.Drawing.Size(1006, 568);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1006, 545);
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.language);
            this.Controls.Add(this.busyIndicator);
            this.Controls.Add(this.activeItem);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.ToolBar mainMenu;
        private Wisej.Web.StatusBar statusBar;
        private Wisej.Web.ToolBarButton openIncomingBook;
        private Wisej.Web.ToolBarButton openOutgoingBook;
        private Wisej.Web.ToolBarButton openDeliveryBook;
        private Wisej.Web.ToolBarButton toolsMenuItem;
        private Wisej.Web.ContextMenu toolsMenu;
        private Wisej.Web.MenuItem backup;
        private Wisej.Web.MenuItem restore;
        private Wisej.Web.MenuItem export;
        private Wisej.Web.MenuItem import;
        private Wisej.Web.ToolBarButton helpMenuItem;
        private Wisej.Web.ContextMenu helpMenu;
        private Wisej.Web.MenuItem about;
        private Wisej.Web.MenuItem pdfManual;
        private MvvmFx.CaliburnMicro.ContentContainer activeItem;
        private Framework.BusyIndicator busyIndicator;
        private Wisej.Web.Label languageLabel;
        private Wisej.Web.ComboBox language;
    }
}