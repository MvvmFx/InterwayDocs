using System;
using Wisej.Web;

namespace Codisa.InterwayDocs.Framework
{
    public interface IBusyIndicator
    {
        bool IsBusy { get; set; }
        string BusyContent { get; set; }
    }

    public partial class BusyIndicator : UserControl, IBusyIndicator
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
    }
}
