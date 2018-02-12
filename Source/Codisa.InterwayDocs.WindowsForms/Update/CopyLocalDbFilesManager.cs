using System;
using System.IO;
using Codisa.InterwayDocs.Properties;

namespace Codisa.InterwayDocs.Update
{
    public static class CopyLocalDbFilesManager
    {
        public static void DoCopy(string baseFilename, UpdateViewModel parent)
        {
            var dbFile = string.Format("{0}.mdf", baseFilename);
            var logFile = string.Format("{0}_log.ldf", baseFilename);

            var dbFileExists = CopyLocalDbFile(dbFile, true);
            var logFileExists = CopyLocalDbFile(logFile, true);

            if (dbFileExists && logFileExists)
            {
                LogCopyDatabaseFiles();
                CopyLocalDbFile(dbFile);
                CopyLocalDbFile(logFile);
            }
            else
            {
                if (!dbFileExists)
                    LogMissingDbFile(dbFile);
                if (!logFileExists)
                    LogMissingDbFile(logFile);
            }
        }

        private static void CopyLocalDbFile(string filename)
        {
            CopyLocalDbFile(filename, false);
        }

        private static bool CopyLocalDbFile(string filename, bool checkExists)
        {
            var source = AppDomain.CurrentDomain.BaseDirectory + filename;
            if (checkExists)
                return File.Exists(source);

            var dest = AppDomain.CurrentDomain.BaseDirectory + @"Backups\" + filename;
            File.Copy(source, dest, true);

            return true;
        }

        #region Write Logs

        private static void LogCopyDatabaseFiles()
        {
            AppLogger.GetLogger().Info(Resources.CopyDatabaseFiles);
        }

        private static void LogMissingDbFile(string filePath)
        {
            AppLogger.GetLogger().Info(string.Format(Resources.MissingDatabaseFile, filePath));
        }

        #endregion
    }
}