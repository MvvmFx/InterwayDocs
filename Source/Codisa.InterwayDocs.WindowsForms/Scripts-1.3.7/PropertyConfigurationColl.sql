/****** Object:  StoredProcedure [dbo].[GetPropertyConfigurationColl] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPropertyConfigurationColl]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetPropertyConfigurationColl]
GO

CREATE PROCEDURE [dbo].[GetPropertyConfigurationColl]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get PropertyConfiguration from table */
        SELECT
            [PropertyConfiguration].[ConfigurationId],
            [PropertyConfiguration].[ObjectName],
            [PropertyConfiguration].[Name],
            [PropertyConfiguration].[IsRequired],
            [PropertyConfiguration].[IsReadOnly],
            [PropertyConfiguration].[IsVisible],
            [PropertyConfiguration].[ListOrder]
        FROM [dbo].[PropertyConfiguration]

        /* Get PropertyFriendlyName from table */
        SELECT
            [PropertyFriendyName].[ConfigurationId],
            [PropertyFriendyName].[UICulture],
            [PropertyFriendyName].[FriendlyName]
        FROM [dbo].[PropertyFriendyName]

    END
GO

