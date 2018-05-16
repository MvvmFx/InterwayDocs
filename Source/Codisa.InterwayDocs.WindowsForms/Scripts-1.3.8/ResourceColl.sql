/****** Object:  StoredProcedure [dbo].[GetResourceColl] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetResourceColl]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetResourceColl]
GO

CREATE PROCEDURE [dbo].[GetResourceColl]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get Resource from table */
        SELECT
            [Resources].[ResourceId],
            [Resources].[ResourceType],
            [Resources].[ResourceName]
        FROM [dbo].[Resources]

        /* Get ResourceCulture from table */
        SELECT
            [ResourceTranslations].[ResourceId],
            [ResourceTranslations].[UICulture],
            [ResourceTranslations].[Translation]
        FROM [dbo].[ResourceTranslations]

    END
GO

