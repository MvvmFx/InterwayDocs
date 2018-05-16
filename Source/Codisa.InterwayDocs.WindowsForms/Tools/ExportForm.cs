using System;
using System.Windows.Forms;
using Codisa.InterwayDocs.Framework;

namespace Codisa.InterwayDocs.Tools
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            Text = "ToolsExportlabel".GetUiTranslation();
            okButton.Text = DialogResult.OK.ToString();
        }
    }
}