DECLARE @FullPathFilename AS VARCHAR(MAX)

SET @FullPathFilename = ''

IF DB_ID('InterwayDocs') IS NULL
BEGIN
    RAISERROR ('Backup failed. Database ''InterwayDocs'' not found.', 16, 1)
    RETURN
END

BACKUP DATABASE [InterwayDocs]
TO DISK = @FullPathFilename
WITH NOFORMAT, INIT, NAME = N'InterwayDocs-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, NO_COMPRESSION, STATS = 10

DECLARE @backupSetId AS INT

SELECT @backupSetId = position
FROM msdb..backupset
WHERE
    database_name=N'InterwayDocs' AND
    backup_set_id=
    (
        SELECT MAX(backup_set_id) FROM msdb..backupset WHERE database_name=N'InterwayDocs'
    )

IF @backupSetId IS NULL
    BEGIN
    RAISERROR(N'Verify failed. Backup information for database ''InterwayDocs'' not found.', 16, 1)
    END

RESTORE VERIFYONLY
    FROM DISK = @FullPathFilename
    WITH FILE = @backupSetId, NOUNLOAD, NOREWIND
