UPDATE DeliveryRegisters
SET ChangeDate = CreateDate

UPDATE DeliveryRegisters
SET ChangeDate = DATEADD (MINUTE, 10, CreateDate) WHERE DocumentClass <> ''

UPDATE DeliveryRegisters
SET ChangeDate = DATEADD (DAY, 1, CreateDate) WHERE ExpeditorName = 'Mateus'


UPDATE IncomingRegisters
SET ChangeDate = CreateDate

UPDATE IncomingRegisters
SET ChangeDate = DATEADD (MINUTE, 10, CreateDate) WHERE DocumentClass <> ''

UPDATE IncomingRegisters
SET ChangeDate = DATEADD (DAY, 1, CreateDate) WHERE ArchiveLocation <> ''


UPDATE OutgoingRegisters
SET ChangeDate = CreateDate

UPDATE OutgoingRegisters
SET ChangeDate = DATEADD (MINUTE, 10, CreateDate) WHERE DocumentClass <> ''

UPDATE OutgoingRegisters
SET ChangeDate = DATEADD (DAY, 1, CreateDate) WHERE ArchiveLocation <> ''
