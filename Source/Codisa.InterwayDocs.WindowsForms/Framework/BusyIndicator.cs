using System;
using System.Windows.Forms;

namespace Codisa.InterwayDocs.Framework
{
    public interface IBusyIndicator
    {
        bool IsBusy { get; set; }
        string BusyContent { get; set; }
    }

    public class BusyIndicator : UserControl, IBusyIndicator
    {
        public BusyIndicator()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        private bool _isBusy = false;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                if (value != _isBusy)
                {
                    _isBusy = value;
                }

                if (_isBusy)
                    BringToFront();
                else
                    SendToBack();

                Visible = _isBusy;
            }
        }

        public string BusyContent
        {
            get { return message.Text; }
            set
            {
                if (value != message.Text)
                    message.Text = value;
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusyIndicator));
            this.message = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.message.Location = new System.Drawing.Point(10, 62);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(50, 13);
            this.message.TabIndex = 1;
            this.message.Text = "message";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture
            // 
            this.picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture.Image = ((System.Drawing.Image) (resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(11, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(48, 48);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // BusyIndicator
            // 
            this.Controls.Add(this.picture);
            this.Controls.Add(this.message);
            this.Name = "BusyIndicator";
            this.Size = new System.Drawing.Size(71, 83);
            ((System.ComponentModel.ISupportInitialize) (this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label message;
        private PictureBox picture;
    }
}