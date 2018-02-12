using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Business.Update
{
    /// <summary>
    /// GetSchemaVersion.<br/>
    /// </summary>
    [Serializable]
    public class GetSchemaVersion : CommandBase<GetSchemaVersion>
    {
        #region Constants

        const string GetSchemaQuery =
            "IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Configuration]') AND type in (N'U'))\r\n" +
            "    BEGIN\r\n" +
            "    DECLARE @updatingToVersion VARCHAR(MAX)\r\n" +
            "\r\n" +
            "    SET @updatingToVersion =\r\n" +
            "        (SELECT [ConfigValue] FROM [dbo].[Configuration]\r\n" +
            "        WHERE [Configuration].[ConfigKey] = 'UpdatingToVersion')\r\n" +
            "\r\n" +
            "    IF @updatingToVersion IS NULL\r\n" +
            "        INSERT dbo.Configuration (ConfigKey, ConfigValue) VALUES (N'UpdatingToVersion', N'1.3.6')\r\n" +
            "\r\n" +
            "        SELECT [ConfigKey],[ConfigValue]\r\n" +
            "        FROM [dbo].[Configuration]\r\n" +
            "        WHERE\r\n" +
            "            [Configuration].[ConfigKey] = 'Version' OR\r\n" +
            "            [Configuration].[ConfigKey] = 'UpdatingToVersion'\r\n" +
            "    END\r\n" +
            "ELSE\r\n" +
            "    BEGIN\r\n" +
            "        BEGIN TRANSACTION\r\n" +
            "            SET ANSI_NULLS ON\r\n" +
            "            SET QUOTED_IDENTIFIER ON\r\n" +
            "            SET ANSI_PADDING ON\r\n" +
            "            CREATE TABLE dbo.Configuration(\r\n" +
            "                ConfigKey varchar(20) NOT NULL,\r\n" +
            "                ConfigValue varchar(max) NOT NULL,\r\n" +
            "             CONSTRAINT PK_Configuration PRIMARY KEY CLUSTERED\r\n" +
            "            (\r\n" +
            "                ConfigKey ASC\r\n" +
            "            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n" +
            "            ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]\r\n" +
            "\r\n" +
            "            SET ANSI_PADDING OFF\r\n" +
            "            INSERT dbo.Configuration (ConfigKey, ConfigValue) VALUES (N'Version', N'1.3.6')\r\n" +
            "            INSERT dbo.Configuration (ConfigKey, ConfigValue) VALUES (N'UpdatingToVersion', N'1.3.6')\r\n" +
            "        COMMIT\r\n" +
            "\r\n" +
            "        SELECT [ConfigKey],[ConfigValue]\r\n" +
            "        FROM [dbo].[Configuration]\r\n" +
            "        WHERE\r\n" +
            "            [Configuration].[ConfigKey] = 'Version' OR\r\n" +
            "            [Configuration].[ConfigKey] = 'UpdatingToVersion'\r\n" +
            "    END\r\n";

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="SchemaVersion"/> property.
        /// </summary>
        [NotUndoable]
        public static readonly PropertyInfo<string> SchemaVersionProperty = RegisterProperty<string>(p => p.SchemaVersion);
        /// <summary>
        /// Gets the SchemaVersion.
        /// </summary>
        /// <value>The SchemaVersion.</value>
        public string SchemaVersion
        {
            get { return ReadProperty(SchemaVersionProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="UpdatingToVersion"/> property.
        /// </summary>
        [NotUndoable]
        public static readonly PropertyInfo<string> UpdatingToVersionProperty = RegisterProperty<string>(p => p.UpdatingToVersion);
        /// <summary>
        /// Gets the UpdatingToVersion.
        /// </summary>
        /// <value>The UpdatingToVersion.</value>
        public string UpdatingToVersion
        {
            get { return ReadProperty(UpdatingToVersionProperty); }
        }

        #endregion

        #region Factory Methods

        public static GetSchemaVersion DoGetVersion()
        {
            GetSchemaVersion cmd = new GetSchemaVersion();
            cmd = DataPortal.Execute(cmd);
            return cmd;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSchemaVersion"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public GetSchemaVersion()
        {
            // Use factory methods and do not use direct creation.
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="GetSchemaVersion"/> object from the database, based on given criteria.
        /// </summary>
        protected override void DataPortal_Execute()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand(GetSchemaQuery, ctx.Connection))
                {
                    cmd.CommandType = CommandType.Text;
                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        while (dr.Read())
                        {
                            var configValue = dr.GetString("ConfigKey");
                            switch (configValue)
                            {
                                case "UpdatingToVersion":
                                    LoadProperty(UpdatingToVersionProperty, dr.GetString("ConfigValue"));
                                    break;
                                case "Version":
                                    LoadProperty(SchemaVersionProperty, dr.GetString("ConfigValue"));
                                    break;
                            }
                        }
                    }
                }
            }
        }

        #endregion
    }
}