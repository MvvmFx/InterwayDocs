USE [master]
GO
/****** Object:  Database [InterwayDocs]    Script Date: 01/01/2016 15:00:00 ******/
CREATE DATABASE [InterwayDocs] ON  PRIMARY
( NAME = N'InterwayDocs', FILENAME = N'C:\MYDB\InterwayDocs.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON
( NAME = N'InterwayDocs_log', FILENAME = N'C:\MYDB\InterwayDocs_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [InterwayDocs] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InterwayDocs].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InterwayDocs] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [InterwayDocs] SET ANSI_NULLS OFF
GO
ALTER DATABASE [InterwayDocs] SET ANSI_PADDING OFF
GO
ALTER DATABASE [InterwayDocs] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [InterwayDocs] SET ARITHABORT OFF
GO
ALTER DATABASE [InterwayDocs] SET AUTO_CLOSE ON
GO
ALTER DATABASE [InterwayDocs] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [InterwayDocs] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [InterwayDocs] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [InterwayDocs] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [InterwayDocs] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [InterwayDocs] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [InterwayDocs] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [InterwayDocs] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [InterwayDocs] SET  DISABLE_BROKER
GO
ALTER DATABASE [InterwayDocs] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [InterwayDocs] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [InterwayDocs] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [InterwayDocs] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [InterwayDocs] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [InterwayDocs] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [InterwayDocs] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [InterwayDocs] SET RECOVERY SIMPLE
GO
ALTER DATABASE [InterwayDocs] SET  MULTI_USER
GO
ALTER DATABASE [InterwayDocs] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [InterwayDocs] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'InterwayDocs', N'ON'
GO
USE [InterwayDocs]
GO
/****** Object:  Table [dbo].[DeliveryRegisters]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DeliveryRegisters](
	[RegisterId] [int] IDENTITY(1,1) NOT NULL,
	[RegisterDate] [date] NOT NULL,
	[DocumentType] [varchar](25) NOT NULL,
	[DocumentReference] [varchar](20) NOT NULL,
	[DocumentEntity] [varchar](50) NOT NULL,
	[DocumentDept] [varchar](50) NOT NULL,
	[DocumentClass] [varchar](50) NOT NULL,
	[DocumentDate] [date] NOT NULL,
	[RecipientName] [varchar](50) NOT NULL,
	[ExpeditorName] [varchar](50) NULL,
	[ReceptionName] [varchar](50) NULL,
	[ReceptionDate] [date] NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[ChangeDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_DeliveryRegisters] PRIMARY KEY CLUSTERED
(
	[RegisterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IncomingRegisters]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IncomingRegisters](
	[RegisterId] [int] IDENTITY(1,1) NOT NULL,
	[RegisterDate] [date] NOT NULL,
	[DocumentType] [varchar](25) NOT NULL,
	[DocumentReference] [varchar](20) NOT NULL,
	[DocumentEntity] [varchar](50) NOT NULL,
	[DocumentDept] [varchar](50) NOT NULL,
	[DocumentClass] [varchar](50) NOT NULL,
	[DocumentDate] [date] NOT NULL,
	[Subject] [varchar](500) NOT NULL,
	[SenderName] [varchar](50) NOT NULL,
	[ReceptionDate] [date] NOT NULL,
	[RoutedTo] [varchar](50) NOT NULL,
	[Notes] [varchar](500) NOT NULL,
	[ArchiveLocation] [varchar](50) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[ChangeDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_IncomingRegisters] PRIMARY KEY CLUSTERED
(
	[RegisterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OutgoingRegisters]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OutgoingRegisters](
	[RegisterId] [int] IDENTITY(1,1) NOT NULL,
	[RegisterDate] [date] NOT NULL,
	[DocumentType] [varchar](25) NOT NULL,
	[DocumentReference] [varchar](20) NOT NULL,
	[DocumentEntity] [varchar](50) NOT NULL,
	[DocumentDept] [varchar](50) NOT NULL,
	[DocumentClass] [varchar](50) NOT NULL,
	[DocumentDate] [date] NOT NULL,
	[Subject] [varchar](500) NOT NULL,
	[SendDate] [date] NOT NULL,
	[RecipientName] [varchar](50) NOT NULL,
	[RecipientTown] [varchar](50) NOT NULL,
	[Notes] [varchar](500) NOT NULL,
	[ArchiveLocation] [varchar](50) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[ChangeDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_OutgoingRegisters] PRIMARY KEY CLUSTERED
(
	[RegisterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[DeliveryView]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[DeliveryView]
AS
SELECT     RegisterId, CAST(RegisterId AS VARCHAR(max)) + DocumentType + DocumentReference + DocumentEntity + DocumentDept + DocumentClass + RecipientName + ExpeditorName + ReceptionName AS FullText
FROM       dbo.DeliveryRegisters

GO
/****** Object:  View [dbo].[IncomingView]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[IncomingView]
AS
SELECT     RegisterId, CAST(RegisterId AS VARCHAR(max)) + DocumentType + DocumentReference + DocumentEntity + DocumentDept + DocumentClass + Subject + SenderName + RoutedTo + Notes AS FullText
FROM       dbo.IncomingRegisters

GO
/****** Object:  View [dbo].[OutgoingView]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[OutgoingView]
AS
SELECT     RegisterId, CAST(RegisterId AS VARCHAR(max)) + DocumentType + DocumentReference + DocumentEntity + DocumentDept + DocumentClass + Subject + RecipientName + RecipientTown + Notes AS FullText
FROM       dbo.OutgoingRegisters

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_DeliveryRegisters]    Script Date: 01/01/2016 15:00:00 ******/
CREATE NONCLUSTERED INDEX [IX_DeliveryRegisters] ON [dbo].[DeliveryRegisters]
(
	[RegisterDate] ASC,
	[DocumentDate] ASC,
	[ReceptionDate] ASC,
	[DocumentType] ASC,
	[DocumentReference] ASC,
	[DocumentEntity] ASC,
	[DocumentDept] ASC,
	[DocumentClass] ASC,
	[RecipientName] ASC,
	[ExpeditorName] ASC,
	[ReceptionName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_IncomingRegisters]    Script Date: 01/01/2016 15:00:00 ******/
CREATE NONCLUSTERED INDEX [IX_IncomingRegisters] ON [dbo].[IncomingRegisters]
(
	[RegisterDate] ASC,
	[DocumentDate] ASC,
	[ReceptionDate] ASC,
	[ArchiveLocation] ASC,
	[DocumentType] ASC,
	[DocumentReference] ASC,
	[DocumentEntity] ASC,
	[DocumentDept] ASC,
	[DocumentClass] ASC,
	[SenderName] ASC,
	[RoutedTo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_IncomingRegisters_Notes]    Script Date: 01/01/2016 15:00:00 ******/
CREATE NONCLUSTERED INDEX [IX_IncomingRegisters_Notes] ON [dbo].[IncomingRegisters]
(
	[Notes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_IncomingRegisters_Subject]    Script Date: 01/01/2016 15:00:00 ******/
CREATE NONCLUSTERED INDEX [IX_IncomingRegisters_Subject] ON [dbo].[IncomingRegisters]
(
	[Subject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_OutgoingRegisters]    Script Date: 01/01/2016 15:00:00 ******/
CREATE NONCLUSTERED INDEX [IX_OutgoingRegisters] ON [dbo].[OutgoingRegisters]
(
	[RegisterDate] ASC,
	[DocumentDate] ASC,
	[SendDate] ASC,
	[ArchiveLocation] ASC,
	[DocumentType] ASC,
	[DocumentReference] ASC,
	[DocumentEntity] ASC,
	[DocumentDept] ASC,
	[DocumentClass] ASC,
	[RecipientName] ASC,
	[RecipientTown] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_OutgoingRegisters_Notes]    Script Date: 01/01/2016 15:00:00 ******/
CREATE NONCLUSTERED INDEX [IX_OutgoingRegisters_Notes] ON [dbo].[OutgoingRegisters]
(
	[Notes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_OutgoingRegisters_Subject]    Script Date: 01/01/2016 15:00:00 ******/
CREATE NONCLUSTERED INDEX [IX_OutgoingRegisters_Subject] ON [dbo].[OutgoingRegisters]
(
	[Subject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[AddDeliveryRegister]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddDeliveryRegister]
    @RegisterId int OUTPUT,
    @RegisterDate date,
    @DocumentType varchar(25),
    @DocumentReference varchar(20),
    @DocumentEntity varchar(50),
    @DocumentDept varchar(50),
    @DocumentClass varchar(50),
    @DocumentDate date,
    @RecipientName varchar(50),
    @ExpeditorName varchar(50),
    @ReceptionName varchar(50),
    @ReceptionDate date,
    @CreateDate datetime2,
    @ChangeDate datetime2
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.DeliveryRegisters */
        INSERT INTO [dbo].[DeliveryRegisters]
        (
            [RegisterDate],
            [DocumentType],
            [DocumentReference],
            [DocumentEntity],
            [DocumentDept],
            [DocumentClass],
            [DocumentDate],
            [RecipientName],
            [ExpeditorName],
            [ReceptionName],
            [ReceptionDate],
            [CreateDate],
            [ChangeDate]
        )
        VALUES
        (
            @RegisterDate,
            @DocumentType,
            @DocumentReference,
            @DocumentEntity,
            @DocumentDept,
            @DocumentClass,
            @DocumentDate,
            @RecipientName,
            @ExpeditorName,
            @ReceptionName,
            @ReceptionDate,
            @CreateDate,
            @ChangeDate
        )

        /* Return new primary key */
        SET @RegisterId = SCOPE_IDENTITY()

    END

GO
/****** Object:  StoredProcedure [dbo].[AddIncomingRegister]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddIncomingRegister]
    @RegisterId int OUTPUT,
    @RegisterDate date,
    @DocumentType varchar(25),
    @DocumentReference varchar(20),
    @DocumentEntity varchar(50),
    @DocumentDept varchar(50),
    @DocumentClass varchar(50),
    @DocumentDate date,
    @Subject varchar(500),
    @SenderName varchar(50),
    @ReceptionDate date,
    @RoutedTo varchar(50),
    @Notes varchar(500),
    @ArchiveLocation varchar(50),
    @CreateDate datetime2,
    @ChangeDate datetime2
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.IncomingRegisters */
        INSERT INTO [dbo].[IncomingRegisters]
        (
            [RegisterDate],
            [DocumentType],
            [DocumentReference],
            [DocumentEntity],
            [DocumentDept],
            [DocumentClass],
            [DocumentDate],
            [Subject],
            [SenderName],
            [ReceptionDate],
            [RoutedTo],
            [Notes],
            [ArchiveLocation],
            [CreateDate],
            [ChangeDate]
        )
        VALUES
        (
            @RegisterDate,
            @DocumentType,
            @DocumentReference,
            @DocumentEntity,
            @DocumentDept,
            @DocumentClass,
            @DocumentDate,
            @Subject,
            @SenderName,
            @ReceptionDate,
            @RoutedTo,
            @Notes,
            @ArchiveLocation,
            @CreateDate,
            @ChangeDate
        )

        /* Return new primary key */
        SET @RegisterId = SCOPE_IDENTITY()

    END

GO
/****** Object:  StoredProcedure [dbo].[AddOutgoingRegister]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddOutgoingRegister]
    @RegisterId int OUTPUT,
    @RegisterDate date,
    @DocumentType varchar(25),
    @DocumentReference varchar(20),
    @DocumentEntity varchar(50),
    @DocumentDept varchar(50),
    @DocumentClass varchar(50),
    @DocumentDate date,
    @Subject varchar(500),
    @SendDate date,
    @RecipientName varchar(50),
    @RecipientTown varchar(50),
    @Notes varchar(500),
    @ArchiveLocation varchar(50),
    @CreateDate datetime2,
    @ChangeDate datetime2
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.OutgoingRegisters */
        INSERT INTO [dbo].[OutgoingRegisters]
        (
            [RegisterDate],
            [DocumentType],
            [DocumentReference],
            [DocumentEntity],
            [DocumentDept],
            [DocumentClass],
            [DocumentDate],
            [Subject],
            [SendDate],
            [RecipientName],
            [RecipientTown],
            [Notes],
            [ArchiveLocation],
            [CreateDate],
            [ChangeDate]
        )
        VALUES
        (
            @RegisterDate,
            @DocumentType,
            @DocumentReference,
            @DocumentEntity,
            @DocumentDept,
            @DocumentClass,
            @DocumentDate,
            @Subject,
            @SendDate,
            @RecipientName,
            @RecipientTown,
            @Notes,
            @ArchiveLocation,
            @CreateDate,
            @ChangeDate
        )

        /* Return new primary key */
        SET @RegisterId = SCOPE_IDENTITY()

    END

GO
/****** Object:  StoredProcedure [dbo].[GetDeliveryRegister]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetDeliveryRegister]
    @RegisterId int
AS
    BEGIN

        SET NOCOUNT ON

        /* Get DeliveryRegister from table */
        SELECT
            [DeliveryRegisters].[RegisterId],
            [DeliveryRegisters].[RegisterDate],
            [DeliveryRegisters].[DocumentType],
            [DeliveryRegisters].[DocumentReference],
            [DeliveryRegisters].[DocumentEntity],
            [DeliveryRegisters].[DocumentDept],
            [DeliveryRegisters].[DocumentClass],
            [DeliveryRegisters].[DocumentDate],
            [DeliveryRegisters].[RecipientName],
            [DeliveryRegisters].[ExpeditorName],
            [DeliveryRegisters].[ReceptionName],
            [DeliveryRegisters].[ReceptionDate],
            [DeliveryRegisters].[CreateDate],
            [DeliveryRegisters].[ChangeDate]
        FROM [dbo].[DeliveryRegisters]
        WHERE
            [DeliveryRegisters].[RegisterId] = @RegisterId

    END

GO
/****** Object:  StoredProcedure [dbo].[GetIncomingRegister]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetIncomingRegister]
    @RegisterId int
AS
    BEGIN

        SET NOCOUNT ON

        /* Get IncomingRegister from table */
        SELECT
            [IncomingRegisters].[RegisterId],
            [IncomingRegisters].[RegisterDate],
            [IncomingRegisters].[DocumentType],
            [IncomingRegisters].[DocumentReference],
            [IncomingRegisters].[DocumentEntity],
            [IncomingRegisters].[DocumentDept],
            [IncomingRegisters].[DocumentClass],
            [IncomingRegisters].[DocumentDate],
            [IncomingRegisters].[Subject],
            [IncomingRegisters].[SenderName],
            [IncomingRegisters].[ReceptionDate],
            [IncomingRegisters].[RoutedTo],
            [IncomingRegisters].[Notes],
            [IncomingRegisters].[ArchiveLocation],
            [IncomingRegisters].[CreateDate],
            [IncomingRegisters].[ChangeDate]
        FROM [dbo].[IncomingRegisters]
        WHERE
            [IncomingRegisters].[RegisterId] = @RegisterId

    END

GO
/****** Object:  StoredProcedure [dbo].[GetOutgoingRegister]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetOutgoingRegister]
    @RegisterId int
AS
    BEGIN

        SET NOCOUNT ON

        /* Get OutgoingRegister from table */
        SELECT
            [OutgoingRegisters].[RegisterId],
            [OutgoingRegisters].[RegisterDate],
            [OutgoingRegisters].[DocumentType],
            [OutgoingRegisters].[DocumentReference],
            [OutgoingRegisters].[DocumentEntity],
            [OutgoingRegisters].[DocumentDept],
            [OutgoingRegisters].[DocumentClass],
            [OutgoingRegisters].[DocumentDate],
            [OutgoingRegisters].[Subject],
            [OutgoingRegisters].[SendDate],
            [OutgoingRegisters].[RecipientName],
            [OutgoingRegisters].[RecipientTown],
            [OutgoingRegisters].[Notes],
            [OutgoingRegisters].[ArchiveLocation],
            [OutgoingRegisters].[CreateDate],
            [OutgoingRegisters].[ChangeDate]
        FROM [dbo].[OutgoingRegisters]
        WHERE
            [OutgoingRegisters].[RegisterId] = @RegisterId

    END

GO
/****** Object:  StoredProcedure [dbo].[UpdateDeliveryRegister]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateDeliveryRegister]
    @RegisterId int,
    @RegisterDate date,
    @DocumentType varchar(25),
    @DocumentReference varchar(20),
    @DocumentEntity varchar(50),
    @DocumentDept varchar(50),
    @DocumentClass varchar(50),
    @DocumentDate date,
    @RecipientName varchar(50),
    @ExpeditorName varchar(50),
    @ReceptionName varchar(50),
    @ReceptionDate date,
    @ChangeDate datetime2
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [RegisterId] FROM [dbo].[DeliveryRegisters]
            WHERE
                [RegisterId] = @RegisterId
        )
        BEGIN
            RAISERROR ('''dbo.DeliveryRegister'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.DeliveryRegisters */
        UPDATE [dbo].[DeliveryRegisters]
        SET
            [RegisterDate] = @RegisterDate,
            [DocumentType] = @DocumentType,
            [DocumentReference] = @DocumentReference,
            [DocumentEntity] = @DocumentEntity,
            [DocumentDept] = @DocumentDept,
            [DocumentClass] = @DocumentClass,
            [DocumentDate] = @DocumentDate,
            [RecipientName] = @RecipientName,
            [ExpeditorName] = @ExpeditorName,
            [ReceptionName] = @ReceptionName,
            [ReceptionDate] = @ReceptionDate,
            [ChangeDate] = @ChangeDate
        WHERE
            [RegisterId] = @RegisterId

    END

GO
/****** Object:  StoredProcedure [dbo].[UpdateIncomingRegister]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateIncomingRegister]
    @RegisterId int,
    @RegisterDate date,
    @DocumentType varchar(25),
    @DocumentReference varchar(20),
    @DocumentEntity varchar(50),
    @DocumentDept varchar(50),
    @DocumentClass varchar(50),
    @DocumentDate date,
    @Subject varchar(500),
    @SenderName varchar(50),
    @ReceptionDate date,
    @RoutedTo varchar(50),
    @Notes varchar(500),
    @ArchiveLocation varchar(50),
    @ChangeDate datetime2
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [RegisterId] FROM [dbo].[IncomingRegisters]
            WHERE
                [RegisterId] = @RegisterId
        )
        BEGIN
            RAISERROR ('''dbo.IncomingRegister'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.IncomingRegisters */
        UPDATE [dbo].[IncomingRegisters]
        SET
            [RegisterDate] = @RegisterDate,
            [DocumentType] = @DocumentType,
            [DocumentReference] = @DocumentReference,
            [DocumentEntity] = @DocumentEntity,
            [DocumentDept] = @DocumentDept,
            [DocumentClass] = @DocumentClass,
            [DocumentDate] = @DocumentDate,
            [Subject] = @Subject,
            [SenderName] = @SenderName,
            [ReceptionDate] = @ReceptionDate,
            [RoutedTo] = @RoutedTo,
            [Notes] = @Notes,
            [ArchiveLocation] = @ArchiveLocation,
            [ChangeDate] = @ChangeDate
        WHERE
            [RegisterId] = @RegisterId

    END

GO
/****** Object:  StoredProcedure [dbo].[UpdateOutgoingRegister]    Script Date: 01/01/2016 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateOutgoingRegister]
    @RegisterId int,
    @RegisterDate date,
    @DocumentType varchar(25),
    @DocumentReference varchar(20),
    @DocumentEntity varchar(50),
    @DocumentDept varchar(50),
    @DocumentClass varchar(50),
    @DocumentDate date,
    @Subject varchar(500),
    @SendDate date,
    @RecipientName varchar(50),
    @RecipientTown varchar(50),
    @Notes varchar(500),
    @ArchiveLocation varchar(50),
    @ChangeDate datetime2
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [RegisterId] FROM [dbo].[OutgoingRegisters]
            WHERE
                [RegisterId] = @RegisterId
        )
        BEGIN
            RAISERROR ('''dbo.OutgoingRegister'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object in dbo.OutgoingRegisters */
        UPDATE [dbo].[OutgoingRegisters]
        SET
            [RegisterDate] = @RegisterDate,
            [DocumentType] = @DocumentType,
            [DocumentReference] = @DocumentReference,
            [DocumentEntity] = @DocumentEntity,
            [DocumentDept] = @DocumentDept,
            [DocumentClass] = @DocumentClass,
            [DocumentDate] = @DocumentDate,
            [Subject] = @Subject,
            [SendDate] = @SendDate,
            [RecipientName] = @RecipientName,
            [RecipientTown] = @RecipientTown,
            [Notes] = @Notes,
            [ArchiveLocation] = @ArchiveLocation,
            [ChangeDate] = @ChangeDate
        WHERE
            [RegisterId] = @RegisterId

    END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties =
   Begin PaneConfigurations =
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane =
      Begin Origin =
         Top = 0
         Left = 0
      End
      Begin Tables =
         Begin Table = "DeliveryRegisters"
            Begin Extent =
               Top = 6
               Left = 38
               Bottom = 213
               Right = 334
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane =
   End
   Begin DataPane =
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane =
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DeliveryView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DeliveryView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties =
   Begin PaneConfigurations =
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane =
      Begin Origin =
         Top = 0
         Left = 0
      End
      Begin Tables =
         Begin Table = "IncomingRegisters"
            Begin Extent =
               Top = 6
               Left = 38
               Bottom = 213
               Right = 308
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane =
   End
   Begin DataPane =
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane =
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IncomingView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IncomingView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties =
   Begin PaneConfigurations =
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane =
      Begin Origin =
         Top = 0
         Left = 0
      End
      Begin Tables =
         Begin Table = "OutgoingRegisters"
            Begin Extent =
               Top = 6
               Left = 38
               Bottom = 213
               Right = 345
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane =
   End
   Begin DataPane =
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane =
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1560
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OutgoingView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OutgoingView'
GO
USE [master]
GO
ALTER DATABASE [InterwayDocs] SET  READ_WRITE
GO
