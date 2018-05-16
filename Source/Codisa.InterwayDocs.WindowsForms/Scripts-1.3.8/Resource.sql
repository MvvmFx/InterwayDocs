/****** Object:  StoredProcedure [dbo].[AddResource] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddResource]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[AddResource]
GO

CREATE PROCEDURE [dbo].[AddResource]
    @ResourceId int OUTPUT,
    @ResourceType varchar(50),
    @ResourceName varchar(50)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.Resources */
        INSERT INTO [dbo].[Resources]
        (
            [ResourceType],
            [ResourceName]
        )
        VALUES
        (
            @ResourceType,
            @ResourceName
        )

        /* Return new primary key */
        SET @ResourceId = SCOPE_IDENTITY()

    END
GO

/****** Object:  StoredProcedure [dbo].[UpdateResource] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateResource]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[UpdateResource]
GO

CREATE PROCEDURE [dbo].[UpdateResource]
    @ResourceId int,
    @ResourceType varchar(50),
    @ResourceName varchar(50)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [ResourceId] FROM [dbo].[Resources]
            WHERE
                [ResourceId] = @ResourceId
        )
        BEGIN
            RAISERROR ('''dbo.Resource'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.Resources */
        UPDATE [dbo].[Resources]
        SET
            [ResourceType] = @ResourceType,
            [ResourceName] = @ResourceName
        WHERE
            [ResourceId] = @ResourceId

    END
GO

/****** Object:  StoredProcedure [dbo].[DeleteResource] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteResource]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DeleteResource]
GO

CREATE PROCEDURE [dbo].[DeleteResource]
    @ResourceId int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [ResourceId] FROM [dbo].[Resources]
            WHERE
                [ResourceId] = @ResourceId
        )
        BEGIN
            RAISERROR ('''dbo.Resource'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete child ResourceCulture from ResourceTranslations */
        DELETE
            [dbo].[ResourceTranslations]
        FROM [dbo].[ResourceTranslations]
            INNER JOIN [dbo].[Resources] ON [ResourceTranslations].[ResourceId] = [Resources].[ResourceId]
        WHERE
            [dbo].[Resources].[ResourceId] = @ResourceId

        /* Delete Resource object from Resources */
        DELETE
        FROM [dbo].[Resources]
        WHERE
            [dbo].[Resources].[ResourceId] = @ResourceId

    END
GO
