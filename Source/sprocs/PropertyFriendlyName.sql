/****** Object:  StoredProcedure [dbo].[UpdatePropertyFriendlyName] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdatePropertyFriendlyName]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[UpdatePropertyFriendlyName]
GO

CREATE PROCEDURE [dbo].[UpdatePropertyFriendlyName]
    @ConfigurationId int,
    @UICulture varchar(5),
    @FriendlyName varchar(50)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [ConfigurationId], [UICulture] FROM [dbo].[PropertyFriendyName]
            WHERE
                [ConfigurationId] = @ConfigurationId AND
                [UICulture] = @UICulture
        )
        BEGIN
            RAISERROR ('''dbo.PropertyFriendlyName'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.PropertyFriendyName */
        UPDATE [dbo].[PropertyFriendyName]
        SET
            [FriendlyName] = @FriendlyName
        WHERE
            [ConfigurationId] = @ConfigurationId AND
            [UICulture] = @UICulture

    END
GO

