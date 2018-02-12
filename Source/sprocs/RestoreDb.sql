/*
USE [master]
GO

DECLARE @FullPathFilename AS VARCHAR(MAX)

SET @FullPathFilename = 'C:\MYDB\Backups\InterwayDocs-20160516-b.bak'

IF DB_ID('InterwayDocs') IS NOT NULL
BEGIN
    ALTER DATABASE [InterwayDocs] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
END

RESTORE DATABASE [InterwayDocs]
    FROM  DISK = @FullPathFilename
    WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 5

ALTER DATABASE [InterwayDocs] SET MULTI_USER

GO
*/
