/****** Object:  StoredProcedure [dbo].[GetlResourceTranslationsByCulture] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetlResourceTranslationsByCulture]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetlResourceTranslationsByCulture]
GO

CREATE PROCEDURE [dbo].[GetlResourceTranslationsByCulture]
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
            [ResourceTranslations].[UICulture] LIKE @UICulture
        ORDER BY
            [Resources].[ResourceType], [Resources].[ResourceName]

    END
GO

/****** Object:  StoredProcedure [dbo].[GetAllResources] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllResources]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetAllResources]
GO

CREATE PROCEDURE [dbo].[GetAllResources]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get Resource from table */
        SELECT
            [Resources].[ResourceId],
            [Resources].[ResourceType],
            [Resources].[ResourceName]
        FROM [dbo].[Resources]
        ORDER BY
            [Resources].[ResourceType], [Resources].[ResourceName]

    END
GO

/****** Object:  StoredProcedure [dbo].[GetResourceTranslations] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetResourceTranslations]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetResourceTranslations]
GO

CREATE PROCEDURE [dbo].[GetResourceTranslations]
    @ResourceId int
AS
    BEGIN

        SET NOCOUNT ON

        /* Get ResourceTranslation from table */
        SELECT
            [ResourceTranslations].[UICulture],
            [ResourceTranslations].[Translation]
        FROM [dbo].[ResourceTranslations]
        WHERE
            [ResourceTranslations].[ResourceId] LIKE @ResourceId
        ORDER BY
            [ResourceTranslations].[UICulture]

    END
GO

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

/****** Object:  StoredProcedure [dbo].[AddResourceTranslation] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddResourceTranslation]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[AddResourceTranslation]
GO

CREATE PROCEDURE [dbo].[AddResourceTranslation]
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

CREATE PROCEDURE [dbo].[UpdateResource]
    @ResourceId int,
    @ResourceType varchar(50),
    @ResourceName varchar(50)
AS
    BEGIN

        SET NOCOUNT ON

        /* Update object in dbo.Resources */
        UPDATE [dbo].[Resources]
        SET
            [ResourceType] = @ResourceType,
            [ResourceName] = @ResourceName
        WHERE
            [ResourceId] = @ResourceId

    END
GO

/****** Object:  StoredProcedure [dbo].[UpdateResourceTranslation] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateResourceTranslation]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[UpdateResourceTranslation]
GO

CREATE PROCEDURE [dbo].[UpdateResourceTranslation]
    @ResourceId int,
    @UICulture varchar(5),
    @Translation varchar(500)
AS
    BEGIN

        SET NOCOUNT ON

        /* Update object in dbo.Resources */
        UPDATE [dbo].[ResourceTranslations]
        SET
            [Translation] = @Translation
        WHERE
            [ResourceId] = @ResourceId AND
            [UICulture] = @UICulture

    END
GO

