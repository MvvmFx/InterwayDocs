/*
   19 de julho de 201615:32:30
   User: sa
   Server: .\
   Database: InterwayDocs
   Application:
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_OutgoingRegisters
	(
	RegisterId int NOT NULL IDENTITY (1, 1),
	RegisterDate date NOT NULL,
	DocumentType varchar(25) NOT NULL,
	DocumentReference varchar(20) NOT NULL,
	DocumentEntity varchar(50) NOT NULL,
	DocumentDept varchar(50) NOT NULL,
	DocumentClass varchar(50) NOT NULL,
	DocumentDate date NOT NULL,
	Subject varchar(500) NOT NULL,
	SendDate date NOT NULL,
	RecipientName varchar(50) NOT NULL,
	RecipientTown varchar(50) NOT NULL,
	Notes varchar(500) NOT NULL,
	ArchiveLocation varchar(50) NOT NULL,
	CreateDate datetime2(7) NOT NULL,
	ChangeDate datetime2(7) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_OutgoingRegisters SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_OutgoingRegisters ON
GO
IF EXISTS(SELECT * FROM dbo.OutgoingRegisters)
	 EXEC('INSERT INTO dbo.Tmp_OutgoingRegisters (RegisterId, RegisterDate, DocumentType, DocumentReference, DocumentEntity, DocumentDept, DocumentClass, DocumentDate, Subject, SendDate, RecipientName, RecipientTown, Notes, ArchiveLocation, CreateDate, ChangeDate)
		SELECT RegisterId, RegisterDate, DocumentType, DocumentReference, CONVERT(varchar(50), DocumentEntity), CONVERT(varchar(50), DocumentDept), DocumentClass, DocumentDate, Subject, SendDate, CONVERT(varchar(50), RecipientName), RecipientTown, Notes, ArchiveLocation, CreateDate, ChangeDate FROM dbo.OutgoingRegisters WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_OutgoingRegisters OFF
GO
DROP TABLE dbo.OutgoingRegisters
GO
EXECUTE sp_rename N'dbo.Tmp_OutgoingRegisters', N'OutgoingRegisters', 'OBJECT'
GO
ALTER TABLE dbo.OutgoingRegisters ADD CONSTRAINT
	PK_OutgoingRegisters PRIMARY KEY CLUSTERED
	(
	RegisterId
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX IX_OutgoingRegisters ON dbo.OutgoingRegisters
	(
	RegisterDate,
	DocumentDate,
	SendDate,
	ArchiveLocation,
	DocumentType,
	DocumentReference,
	DocumentEntity,
	DocumentDept,
	DocumentClass,
	RecipientName,
	RecipientTown
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX IX_OutgoingRegisters_Notes ON dbo.OutgoingRegisters
	(
	Notes
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX IX_OutgoingRegisters_Subject ON dbo.OutgoingRegisters
	(
	Subject
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
COMMIT

