/****** Object:  StoredProcedure [dbo].[GetPropertyRequiredList] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPropertyRequiredList]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetPropertyRequiredList]
GO

CREATE PROCEDURE [dbo].[GetPropertyRequiredList]
AS
    BEGIN

        SET NOCOUNT ON

        /* Get PropertyRequiredInfo from table */
        SELECT
            [PropertyConfiguration].[ObjectName],
            [PropertyConfiguration].[Name],
            [PropertyConfiguration].[IsRequired]
        FROM [dbo].[PropertyConfiguration]

    END
GO

