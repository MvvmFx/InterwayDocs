using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Codisa.InterwayDocs.Setup
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            InfoTextBox.Text = GetAboutInfo();
        }

        private string GetAboutInfo()
        {
            // This is the file info
            var fileName =
                FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).OriginalFilename;
            var fileVersion =
                FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            var assemblyCopyright =
                FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).LegalCopyright;
            var response =
                ProductName + " v." + ProductVersion + Environment.NewLine +
                assemblyCopyright + Environment.NewLine +
                Environment.NewLine +
                "Ficheiro: " + fileName + Environment.NewLine +
                "Versão: " + fileVersion + Environment.NewLine;

            return response;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}