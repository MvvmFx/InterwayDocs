/****** Object:  StoredProcedure [dbo].[GetResourceList] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetResourceList]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetResourceList]
GO

CREATE PROCEDURE [dbo].[GetResourceList]
    @ResourceType varchar(50),
    @UICulture varchar(5)
AS
    BEGIN

        SET NOCOUNT ON

        /* Get ResourceInfo from table */
        SELECT
            [Resources].[ResourceType],
            [Resources].[ResourceName],
            [ResourceTranslations].[UICulture],
            [ResourceTranslations].[Translation]
        FROM [dbo].[ResourceTranslations]
            INNER JOIN [dbo].[Resources] ON [ResourceTranslations].[ResourceId] = [Resources].[ResourceId]
        WHERE
            [Resources].[ResourceType] = @ResourceType AND
            [ResourceTranslations].[UICulture] = @UICulture
        ORDER BY
            [Resources].[ResourceName]

    END
GO

