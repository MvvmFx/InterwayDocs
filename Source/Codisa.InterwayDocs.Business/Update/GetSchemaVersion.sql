IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Configuration]') AND type in (N'U'))
    BEGIN
        DECLARE @updatingToVersion VARCHAR(MAX)

        SET @updatingToVersion =
            (SELECT [ConfigValue] FROM [dbo].[Configuration]
            WHERE [Configuration].[ConfigKey] = 'UpdatingToVersion')

        IF @updatingToVersion IS NULL
            INSERT dbo.Configuration (ConfigKey, ConfigValue) VALUES (N'UpdatingToVersion', N'1.3.6')

        SELECT [ConfigKey],[ConfigValue]
        FROM [dbo].[Configuration]
        WHERE
            [Configuration].[ConfigKey] = 'Version' OR
            [Configuration].[ConfigKey] = 'UpdatingToVersion'
    END
ELSE
    BEGIN
        BEGIN TRANSACTION
            SET ANSI_NULLS ON
            SET QUOTED_IDENTIFIER ON
            SET ANSI_PADDING ON
            CREATE TABLE dbo.Configuration(
                ConfigKey varchar(20) NOT NULL,
                ConfigValue varchar(max) NOT NULL,
             CONSTRAINT PK_Configuration PRIMARY KEY CLUSTERED
            (
                ConfigKey ASC
            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
            ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

            SET ANSI_PADDING OFF
            INSERT dbo.Configuration (ConfigKey, ConfigValue) VALUES (N'Version', N'1.3.6')
            INSERT dbo.Configuration (ConfigKey, ConfigValue) VALUES (N'UpdatingToVersion', N'1.3.6')
        COMMIT

        SELECT [ConfigKey],[ConfigValue]
        FROM [dbo].[Configuration]
        WHERE
            [Configuration].[ConfigKey] = 'Version' OR
            [Configuration].[ConfigKey] = 'UpdatingToVersion'
    END\r\n";