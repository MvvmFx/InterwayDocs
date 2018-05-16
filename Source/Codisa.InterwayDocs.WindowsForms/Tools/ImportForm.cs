using System;
using System.Windows.Forms;
using Codisa.InterwayDocs.Framework;

namespace Codisa.InterwayDocs.Tools
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            Text = "ToolsImportLabel".GetUiTranslation();
            okButton.Text = DialogResult.OK.ToString();
        }
    }
}