/****** Object:  StoredProcedure [dbo].[GetResourceList] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetResourceList]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetResourceList]
GO

CREATE PROCEDURE [dbo].[GetResourceList]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get ResourceInfo from table */
        SELECT
            [Resources].[ResourceId],
            [Resources].[ResourceType],
            [Resources].[ResourceName]
        FROM [dbo].[Resources]

        /* Get ResourceCultureList from table */
        SELECT
            [ResourceTranslations].[ResourceId],
            [ResourceTranslations].[UICulture],
            [ResourceTranslations].[Translation]
        FROM [dbo].[ResourceTranslations]

    END
GO

