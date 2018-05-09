/****** Object:  StoredProcedure [dbo].[MigrationAddResource] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MigrationAddResource]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[MigrationAddResource]
GO

CREATE PROCEDURE [dbo].[MigrationAddResource]
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

/****** Object:  StoredProcedure [dbo].[MigrationAddResourceTranslation] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MigrationAddResourceTranslation]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[MigrationAddResourceTranslation]
GO

CREATE PROCEDURE [dbo].[MigrationAddResourceTranslation]
    @ResourceId int,
    @UICulture varchar(5),
    @Translation varchar(500)
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.Resources */
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

/****** Object:  StoredProcedure [dbo].[UpdateResource] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateResource]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[UpdateResource]
GO
