using System;
using System.Windows.Forms;
using Codisa.InterwayDocs.Business.Tools;
using Codisa.InterwayDocs.Framework;

namespace Codisa.InterwayDocs.Tools
{
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            Text = "ToolsBackupLabel".GetUiTranslation();
            okButton.Text = DialogResult.OK.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var path = @"C:\MYDB\Backups\";
            var filename = string.Format("InterwayDocs-{0}.bak",
                DateTime.Now.ToString("s").Replace(":", string.Empty).Replace("T", "-"));
            BackupDatabase.DoBackup(path + filename);
        }
    }
}