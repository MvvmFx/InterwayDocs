using System;
using System.Windows.Forms;
using Codisa.InterwayDocs.Framework;

namespace Codisa.InterwayDocs.Tools
{
    public partial class RestoreForm : Form
    {
        public RestoreForm()
        {
            InitializeComponent();
        }

        private void RestoreForm_Load(object sender, EventArgs e)
        {
            Text = "ToolsRestoreLabel".GetUiTranslation();
            okButton.Text = DialogResult.OK.ToString();
        }
    }
}