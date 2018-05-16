/****** Object:  StoredProcedure [dbo].[AddLanguage] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddLanguage]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[AddLanguage]
GO

CREATE PROCEDURE [dbo].[AddLanguage]
    @UICulture varchar(5),
    @Name nchar(10)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.Languages */
        INSERT INTO [dbo].[Languages]
        (
            [UICulture],
            [Name]
        )
        VALUES
        (
            @UICulture,
            @Name
        )

    END
GO

/****** Object:  StoredProcedure [dbo].[UpdateLanguage] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateLanguage]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[UpdateLanguage]
GO

CREATE PROCEDURE [dbo].[UpdateLanguage]
    @UICulture varchar(5),
    @Name nchar(10)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [UICulture] FROM [dbo].[Languages]
            WHERE
                [UICulture] = @UICulture
        )
        BEGIN
            RAISERROR ('''dbo.Language'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.Languages */
        UPDATE [dbo].[Languages]
        SET
            [Name] = @Name
        WHERE
            [UICulture] = @UICulture

    END
GO

/****** Object:  StoredProcedure [dbo].[DeleteLanguage] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteLanguage]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DeleteLanguage]
GO

CREATE PROCEDURE [dbo].[DeleteLanguage]
    @UICulture varchar(5)
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [UICulture] FROM [dbo].[Languages]
            WHERE
                [UICulture] = @UICulture
        )
        BEGIN
            RAISERROR ('''dbo.Language'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Delete Language object from Languages */
        DELETE
        FROM [dbo].[Languages]
        WHERE
            [dbo].[Languages].[UICulture] = @UICulture

    END
GO
