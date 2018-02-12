using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Business.Tools
{
    /// <summary>
    /// BackupDatabase Command.<br/>
    /// </summary>
    [Serializable]
    public class BackupDatabase : CommandBase<BackupDatabase>
    {
        #region Constants

        const string BackupQuery =
        "IF DB_ID('InterwayDocs') IS NULL\r\n" +
        "BEGIN\r\n" +
        "    RAISERROR ('Backup failed. Database ''InterwayDocs'' not found.', 16, 1)\r\n" +
        "    RETURN\r\n" +
        "END\r\n" +

        "BACKUP DATABASE [InterwayDocs]\r\n" +
        "TO DISK = @FullPathFilename\r\n" +
        "WITH NOFORMAT, INIT, NAME = N'InterwayDocs-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, NO_COMPRESSION, STATS = 10\r\n" +

        "DECLARE @backupSetId AS INT\r\n" +

        "SELECT @backupSetId = position\r\n" +
        "FROM msdb..backupset\r\n" +
        "WHERE\r\n" +
        "    database_name=N'InterwayDocs' AND\r\n" +
        "    backup_set_id=\r\n" +
        "    (\r\n" +
        "        SELECT MAX(backup_set_id) FROM msdb..backupset WHERE database_name=N'InterwayDocs'\r\n" +
        "    )\r\n" +

        "IF @backupSetId IS NULL\r\n" +
        "    BEGIN\r\n" +
        "    RAISERROR(N'Verify failed. Backup information for database ''InterwayDocs'' not found.', 16, 1)\r\n" +
        "    END\r\n" +

        "RESTORE VERIFYONLY\r\n" +
        "    FROM DISK = @FullPathFilename\r\n" +
        "    WITH FILE = @backupSetId, NOUNLOAD, NOREWIND";

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="FullPathFilename"/> property.
        /// </summary>
        [NotUndoable]
        public static readonly PropertyInfo<string> FullPathFilenameProperty = RegisterProperty<string>(p => p.FullPathFilename);
        /// <summary>
        /// Gets the FullPathFilename.
        /// </summary>
        /// <value>The FullPathFilename.</value>
        public string FullPathFilename
        {
            get { return ReadProperty(FullPathFilenameProperty); }
            set { LoadProperty(FullPathFilenameProperty, value); }
        }

        #endregion

        #region Factory Methods

        public static BackupDatabase DoBackup(string fullPathFilename)
        {
            BackupDatabase cmd = new BackupDatabase {FullPathFilename = fullPathFilename};
            cmd = DataPortal.Execute(cmd);
            return cmd;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupDatabase"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public BackupDatabase()
        {
            // Use factory methods and do not use direct creation.
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="BackupDatabase"/> object from the database, based on given criteria.
        /// </summary>
        protected override void DataPortal_Execute()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand(BackupQuery, ctx.Connection))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@FullPathFilename", ReadProperty(FullPathFilenameProperty)).DbType = DbType.String;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion
    }
}