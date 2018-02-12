namespace Codisa.InterwayDocs.Framework
{
    partial class BusyIndicator
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

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusyIndicator));
            this.message = new Wisej.Web.Label();
            this.picture = new Wisej.Web.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.message.Location = new System.Drawing.Point(10, 62);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(50, 13);
            this.message.TabIndex = 1;
            this.message.Text = "message";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture
            // 
            this.picture.Anchor = (Wisej.Web.AnchorStyles.None);
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(11, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(48, 48);
            this.picture.SizeMode = (Wisej.Web.PictureBoxSizeMode.AutoSize);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // BusyIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.picture);
            this.Controls.Add(this.message);
            this.Name = "BusyIndicator";
            this.Size = new System.Drawing.Size(71, 83);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label message;
        private Wisej.Web.PictureBox picture;
    }
}
