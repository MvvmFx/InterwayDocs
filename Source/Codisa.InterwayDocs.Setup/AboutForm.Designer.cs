namespace Codisa.InterwayDocs.Setup
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable. </summary>
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
            this.OK = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.imageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OK.Location = new System.Drawing.Point(175, 130);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTextBox.BackColor = System.Drawing.Color.White;
            this.InfoTextBox.Location = new System.Drawing.Point(12, 20);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.Size = new System.Drawing.Size(410, 74);
            this.InfoTextBox.TabIndex = 1;
            this.InfoTextBox.TabStop = false;
            // 
            // imageLabel
            // 
            this.imageLabel.Image = global::Codisa.InterwayDocs.Setup.Properties.Resources.SplashImage;
            this.imageLabel.Location = new System.Drawing.Point(350, 25);
            this.imageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(64, 64);
            this.imageLabel.TabIndex = 2;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 165);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.InfoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About InterwayDocs Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InfoTextBox;
        internal System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label imageLabel;
    }
}