using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using Codisa.InterwayDocs.Framework;
using Codisa.InterwayDocs.Properties;

namespace Codisa.InterwayDocs
{
    public partial class AboutForm : Form, IRefreshTranslation
    {
        private string _fileVersion;
        private string _legalCopyright;
        private string _path;

        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            _fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            _legalCopyright = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).LegalCopyright;
            _path = Application.StartupPath.Replace(" ", "%20");

            RefreshTranslation();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Translations

        public void RefreshTranslation()
        {
            Text = Resources.LabelAboutApplication;
            okButton.Text = DialogResult.OK.ToString();

            versionLabel.Text = string.Format("{0} {1}  -  {2}", Resources.AboutFormVersionLabel, _fileVersion,
                _legalCopyright);

            var urlString = string.Format("file:///{0}/{1}.html", _path, Resources.AboutFormHtmlFileName);

            webBrowser1.Url = new Uri(urlString);
        }

        #endregion
    }
}