using System;
using System.Diagnostics;
using System.Reflection;
using Codisa.InterwayDocs.Framework;
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

            Text = "LabelAboutApplication".GetUiTranslation();
            okButton.Text = DialogResult.OK.ToString();

            versionLabel.Text = string.Format("{0} {1}  -  {2}", "AboutFormVersionLabel".GetUiTranslation(),
                _fileVersion,
                _legalCopyright);

            var urlString = ApplicationBase.StartupUrl + "AboutFormHtmlFileName".GetUiTranslation() + ".html";

            webBrowser1.Url = new Uri(urlString + "?v=" + timestamp);
        }

        #endregion
    }
}