/****** Object:  StoredProcedure [dbo].[AddResourceCulture] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddResourceCulture]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[AddResourceCulture]
GO

CREATE PROCEDURE [dbo].[AddResourceCulture]
    @ResourceId int,
    @UICulture varchar(5),
    @Translation varchar(500)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.ResourceTranslations */
        INSERT INTO [dbo].[ResourceTranslations]
        (
            [ResourceId],
            [UICulture],
            [Translation]
        )
        VALUES
        (
            @ResourceId,
            @UICulture,
            @Translation
        )

    END
GO

/****** Object:  StoredProcedure [dbo].[UpdateResourceCulture] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateResourceCulture]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[UpdateResourceCulture]
GO

CREATE PROCEDURE [dbo].[UpdateResourceCulture]
    @UICulture varchar(5),
    @Translation varchar(500)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [UICulture] FROM [dbo].[ResourceTranslations]
            WHERE
                [UICulture] = @UICulture
        )
        BEGIN
            RAISERROR ('''dbo.ResourceCulture'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.ResourceTranslations */
        UPDATE [dbo].[ResourceTranslations]
        SET
            [Translation] = @Translation
        WHERE
            [UICulture] = @UICulture

    END
GO

/****** Object:  StoredProcedure [dbo].[DeleteResourceCulture] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteResourceCulture]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DeleteResourceCulture]
GO

CREATE PROCEDURE [dbo].[DeleteResourceCulture]
    @UICulture varchar(5)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [UICulture] FROM [dbo].[ResourceTranslations]
            WHERE
                [UICulture] = @UICulture
        )
        BEGIN
            RAISERROR ('''dbo.ResourceCulture'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete ResourceCulture object from ResourceTranslations */
        DELETE
        FROM [dbo].[ResourceTranslations]
        WHERE
            [dbo].[ResourceTranslations].[UICulture] = @UICulture

    END
GO
