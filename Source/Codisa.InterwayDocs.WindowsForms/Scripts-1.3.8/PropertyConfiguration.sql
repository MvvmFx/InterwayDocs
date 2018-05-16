/****** Object:  StoredProcedure [dbo].[UpdatePropertyConfiguration] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdatePropertyConfiguration]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[UpdatePropertyConfiguration]
GO

CREATE PROCEDURE [dbo].[UpdatePropertyConfiguration]
    @ConfigurationId int,
    @IsRequired bit,
    @IsReadOnly bit,
    @IsVisible bit,
    @ListOrder int
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [ConfigurationId] FROM [dbo].[PropertyConfiguration]
            WHERE
                [ConfigurationId] = @ConfigurationId
        )
        BEGIN
            RAISERROR ('''dbo.PropertyConfiguration'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.PropertyConfiguration */
        UPDATE [dbo].[PropertyConfiguration]
        SET
            [IsRequired] = @IsRequired,
            [IsReadOnly] = @IsReadOnly,
            [IsVisible] = @IsVisible,
            [ListOrder] = @ListOrder
        WHERE
            [ConfigurationId] = @ConfigurationId

    END
GO

