namespace Codisa.InterwayDocs.Setup
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
            this.openDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.openObjectProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.openOtherCustomizations = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.activeItem = new MvvmFx.CaliburnMicro.ContentContainer();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDatabase,
            this.openObjectProperties,
            this.openOtherCustomizations,
            this.helpMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1008, 24);
            this.mainMenu.TabIndex = 0;
            // 
            // openDatabase
            // 
            this.openDatabase.Name = "openDatabase";
            this.openDatabase.Size = new System.Drawing.Size(67, 20);
            this.openDatabase.Text = "Base de dados";
            // 
            // openObjectProperties
            // 
            this.openObjectProperties.Name = "openObjectProperties";
            this.openObjectProperties.Size = new System.Drawing.Size(66, 20);
            this.openObjectProperties.Text = "Lista e formulários";
            // 
            // openOtherCustomizations
            // 
            this.openOtherCustomizations.Name = "openOtherCustomizations";
            this.openOtherCustomizations.Size = new System.Drawing.Size(71, 20);
            this.openOtherCustomizations.Text = "Outras configurações";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(50, 20);
            this.helpMenuItem.Text = "Ajuda";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.aboutToolStripMenuItem.Text = "Sobre o InterwayDocs Setup";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.about_Click);
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
            this.activeItem.Location = new System.Drawing.Point(0, 24);
            this.activeItem.Name = "activeItem";
            this.activeItem.Size = new System.Drawing.Size(1008, 643);
            this.activeItem.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 689);
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
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem openDatabase;
        private System.Windows.Forms.ToolStripMenuItem openObjectProperties;
        private System.Windows.Forms.ToolStripMenuItem openOtherCustomizations;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private MvvmFx.CaliburnMicro.ContentContainer activeItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}