using System;
using System.Diagnostics;
using System.Reflection;
using Codisa.InterwayDocs.Framework;
using Codisa.InterwayDocs.Properties;
using Wisej.Base;
using Wisej.Web;

namespace Codisa.InterwayDocs
{
    public partial class AboutForm : Form, IRefreshTranslation
    {
        private string _fileVersion;
        private string _legalCopyright;

        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            _fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            _legalCopyright = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).LegalCopyright;

            RefreshTranslation();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Translations

        public void RefreshTranslation()
        {
            string timestamp = DateTime.Now.ToString();

            Text = Resources.LabelAboutApplication;
            okButton.Text = DialogResult.OK.ToString();

            versionLabel.Text = string.Format("{0} {1}  -  {2}", Resources.AboutFormVersionLabel, _fileVersion,
                _legalCopyright);

            var urlString = ApplicationBase.StartupUri + Resources.AboutFormHtmlFileName + ".html";

            webBrowser1.Url = new Uri(urlString + "?v=" + timestamp);
        }

        #endregion
    }
}