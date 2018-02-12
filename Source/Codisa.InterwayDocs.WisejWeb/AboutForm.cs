using System;
using System.Diagnostics;
using System.Reflection;
using Wisej.Web;
using Codisa.InterwayDocs.Properties;

namespace Codisa.InterwayDocs
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            Text = Resources.LabelAboutApplication;
            okButton.Text = DialogResult.OK.ToString();

            versionLabel.Text = string.Format("{0} {1}  -  {2}",
                Resources.AboutFormVersionLabel,
                FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion,
                FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).LegalCopyright);

            var path = Application.StartupPath.Replace(" ", "%20");

            var urlString = string.Format("file:///{0}/{1}.html", path, Resources.AboutFormHtmlFileName);

            webBrowser1.Url = new Uri(urlString);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}