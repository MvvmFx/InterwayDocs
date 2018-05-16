/****** Object:  StoredProcedure [dbo].[GetLanguageColl] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetLanguageColl]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetLanguageColl]
GO

CREATE PROCEDURE [dbo].[GetLanguageColl]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get Language from table */
        SELECT
            [Languages].[UICulture],
            RTRIM([Languages].[Name]) AS [Name]
        FROM [dbo].[Languages]

    END
GO

