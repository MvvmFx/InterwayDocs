USE InterwayDocs

TRUNCATE TABLE DeliveryRegisters
TRUNCATE TABLE IncomingRegisters
TRUNCATE TABLE OutgoingRegisters

DBCC CHECKIDENT ('DeliveryRegisters', RESEED, 1)
DBCC CHECKIDENT ('IncomingRegisters', RESEED, 1)
DBCC CHECKIDENT ('OutgoingRegisters', RESEED, 1)