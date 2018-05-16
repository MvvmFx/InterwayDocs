using System;
using System.Diagnostics;
using System.Reflection;
#if WISEJ
using Wisej.Web;
#else
using System.Windows.Forms;
#endif
using Codisa.InterwayDocs.Business.Update;
using Codisa.InterwayDocs.Framework;

namespace Codisa.InterwayDocs.Update
{
    public class UpdateViewModel
    {
        #region Constants

        public const string ApplyQuery = "ApplyTo-<version>.sql";

        #endregion

        public static string ScriptFolderPath { get; private set; }

        public UpdateViewModel()
        {
            /*ScriptFolderPath = AppDomain.CurrentDomain.BaseDirectory + @"Scripts-1.3.7\";

            CopyLocalDbFilesManager.DoCopy("InterwayDocs", this);

            var appVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            var schemaVersion = string.Empty;
            var updatingToVersion = string.Empty;

            UpdateSchemaManager updateSchemaManager = null;

            Exception exception = null;

            while (true)
            {
                try
                {
                    var command = GetSchemaVersion.DoGetVersion();
                    schemaVersion = command.SchemaVersion;
                    updatingToVersion = command.UpdatingToVersion;
                }
                catch (Exception ex)
                {
                    exception = ex;
                }

                if (exception != null)
                    LogExceptionAndQuit(exception.Message);

                if (appVersion == updatingToVersion)
                    break;

                updateSchemaManager = new UpdateSchemaManager(schemaVersion, appVersion, this);
            }

            if (updateSchemaManager != null && updateSchemaManager.SchemaUpdated)
            {
                var refreshObjectsManager = new RefreshObjectsManager(appVersion, this);
            }*/
        }

        internal void WriteNewSchemaVersion(string appVersion)
        {
            var updateSchemaVersion =
                string.Format("UPDATE dbo.Configuration SET ConfigValue = N'{0}' WHERE ConfigKey = N'Version'",
                    appVersion);

            BatchCommand.RunBatch(updateSchemaVersion);
        }

        private void LogExceptionAndQuit(string message)
        {
            AppLogger.GetLogger().Error(message);
            ShowFatalErrorAndQuit(message);
        }

        private void ShowFatalErrorAndQuit(string errorMessage)
        {
            MessageBox.Show(errorMessage, "FatalError".GetUiTranslation(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
            throw new Exception("Exit");
        }
    }
}