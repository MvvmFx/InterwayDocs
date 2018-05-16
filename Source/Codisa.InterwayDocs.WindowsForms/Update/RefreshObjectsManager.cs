using System;
using System.Collections.Generic;
using System.IO;
using Codisa.InterwayDocs.Business.Update;
using Codisa.InterwayDocs.Framework;

namespace Codisa.InterwayDocs.Update
{
    public class RefreshObjectsManager
    {
        #region Fields

        private UpdateViewModel _parent;
        private string _appVersion;

        #endregion

        #region Constructors

        private RefreshObjectsManager()
        {
            // force to use the parametrized constructor
        }

        public RefreshObjectsManager(string appVersion, UpdateViewModel parent)
        {
            _appVersion = appVersion;
            _parent = parent;

            LogRefreshigDbObjects();

            var filenames = GetFilenames();
            foreach (var filename in filenames)
            {
                var shortFilename = filename.Substring(filename.LastIndexOf(@"\", StringComparison.InvariantCulture) + 1);
                LogApplyingQueryFile(shortFilename);
                UpdateByBatch(filename);
            }

            parent.WriteNewSchemaVersion(appVersion);
        }

        #endregion

        #region Private methods

        private static List<string> GetFilenames()
        {
            var result = new List<string>();
            var files = Directory.GetFiles(UpdateViewModel.ScriptFolderPath);

            foreach (var file in files)
            {
                var filename = new FileInfo(file).Name;
                var searchPrefix = UpdateViewModel.ApplyQuery.Replace("-<version>.sql", string.Empty);
                if (filename.IndexOf(searchPrefix, StringComparison.InvariantCulture) < 0)
                    result.Add(file);
            }

            return result;
        }

        #endregion

        #region Update core

        public void UpdateByBatch(string filename)
        {
            var upgradeScript = File.ReadAllText(filename);

            var batches = upgradeScript.Split(new[] {"GO" + Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var batch in batches)
            {
                BatchCommand.RunBatch(batch);
            }
        }

        #endregion

        #region Write Logs

        private void LogRefreshigDbObjects()
        {
            AppLogger.GetLogger().Info(string.Format("RefreshigDbObjects".GetUiTranslation(), _appVersion));
        }

        private void LogApplyingQueryFile(string shortFilename)
        {
            AppLogger.GetLogger().Info(string.Format("ApplyingQueryFile".GetUiTranslation(), shortFilename));
        }

        #endregion
    }
}