/****** Object:  StoredProcedure [dbo].[GetPropertyConfigurationList] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPropertyConfigurationList]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetPropertyConfigurationList]
GO

CREATE PROCEDURE [dbo].[GetPropertyConfigurationList]
    @ObjectName varchar(50),
    @UICulture varchar(5)
AS
    BEGIN

        SET NOCOUNT ON

        /* Get PropertyConfigurationInfo from table */
        SELECT
            [PropertyConfiguration].[ObjectName],
            [PropertyConfiguration].[Name],
            [PropertyFriendyName].[UICulture],
            [PropertyFriendyName].[FriendlyName],
            [PropertyConfiguration].[IsRequired],
            [PropertyConfiguration].[IsReadOnly],
            [PropertyConfiguration].[IsVisible]
        FROM [dbo].[PropertyFriendyName]
            INNER JOIN [dbo].[PropertyConfiguration] ON [PropertyFriendyName].[ConfigurationId] = [PropertyConfiguration].[ConfigurationId]
        WHERE
            [PropertyConfiguration].[ObjectName] = @ObjectName AND
            [PropertyFriendyName].[UICulture] = @UICulture

    END
GO

