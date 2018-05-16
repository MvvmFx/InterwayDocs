using System;
using System.IO;
#if WISEJ
using Wisej.Web;
#else
using System.Windows.Forms;
#endif
using Codisa.InterwayDocs.Business.Update;
using Codisa.InterwayDocs.Framework;

namespace Codisa.InterwayDocs.Update
{
    public class UpdateSchemaManager
    {
        #region Fields & Properties

        private UpdateViewModel _parent;
        private readonly string _schemaVersion;
        private readonly string _appVersion;
        private string _filename;

        public bool SchemaUpdated { get; private set; }

        #endregion

        #region Constructors

        private UpdateSchemaManager()
        {
            // force to use the parametrized constructor
        }

        public UpdateSchemaManager(string schemaVersion, string appVersion, UpdateViewModel parent)
        {
            _schemaVersion = schemaVersion;
            _appVersion = appVersion;
            _parent = parent;

            if (CheckSchemaVersion() && CheckUpgradeFileExists())
            {
                LogUpgradingVersion();
                UpdateByBatch();
                SchemaUpdated = true;
            }
        }

        #endregion

        #region Check methods

        private bool CheckSchemaVersion()
        {
            if (_schemaVersion == string.Empty)
                LogEmptySchemaVersionAndQuit();

            var appIntVersion = Convert.ToInt32(_appVersion.Replace(".", string.Empty));
            var schemaIntVersion = -1;
            try
            {
                schemaIntVersion = Convert.ToInt32(_schemaVersion.Replace(".", string.Empty));
            }
            catch (FormatException)
            {
                LogWrongSchemaVersionAndQuit();
            }

            if (schemaIntVersion > appIntVersion)
                LogWrongSchemaVersionAndQuit();

            return true;
        }

        private bool CheckUpgradeFileExists()
        {
            _filename = UpdateViewModel.ScriptFolderPath +
                        UpdateViewModel.ApplyQuery.Replace("<version>", _schemaVersion);
            var exists = File.Exists(_filename);

            if (!exists)
                LogNoScriptForVersionAndQuit();

            return true;
        }

        #endregion

        #region Update core

        public void UpdateByBatch()
        {
            var upgradeScript = File.ReadAllText(_filename);

            var batches = upgradeScript.Split(new[] {"GO" + Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var batch in batches)
            {
                BatchCommand.RunBatch(batch);
            }
        }

        #endregion

        #region Write Logs

        private void LogUpgradingVersion()
        {
            AppLogger.GetLogger().Info(string.Format("UpgradingVersion".GetUiTranslation(), _schemaVersion, _appVersion));
        }

        private void LogEmptySchemaVersionAndQuit()
        {
            var message = "DatabaseTemperingVersionEmpty".GetUiTranslation();

            AppLogger.GetLogger().Error(message);
            ShowFatalErrorAndQuit(message);
        }

        private void LogWrongSchemaVersionAndQuit()
        {
            var message = string.Format("DatabaseTemperingWrongVersion".GetUiTranslation(), _schemaVersion);

            AppLogger.GetLogger().Error(message);
            ShowFatalErrorAndQuit(message);
        }

        private void LogNoScriptForVersionAndQuit()
        {
            var message = string.Format("NoScriptForVersion".GetUiTranslation(), _schemaVersion);

            AppLogger.GetLogger().Error(message);
            ShowFatalErrorAndQuit(message);
        }

        private void ShowFatalErrorAndQuit(string errorMessage)
        {
            MessageBox.Show(errorMessage, "FatalError".GetUiTranslation(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
            throw new Exception("Exit");
        }

        #endregion
    }
}