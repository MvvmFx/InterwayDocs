USE [InterwayDocs]
GO

-- 1 a 5

UPDATE DeliveryRegisters
SET RegisterDate = GETDATE()-100, DocumentDate = GETDATE()-105, ReceptionDate = GETDATE()-100, CreateDate = GETDATE()-100, ChangeDate = GETDATE()-101
WHERE RegisterId >= 1 AND RegisterId <= 5

UPDATE OutgoingRegisters
SET RegisterDate = GETDATE()-100, DocumentDate = GETDATE()-105, SendDate = GETDATE()-100, CreateDate = GETDATE()-100, ChangeDate = GETDATE()-101
WHERE RegisterId >= 1 AND RegisterId <= 5

UPDATE IncomingRegisters
SET RegisterDate = GETDATE()-100, DocumentDate = GETDATE()-105, ReceptionDate = GETDATE()-53, CreateDate = GETDATE()-100, ChangeDate = GETDATE()-101
WHERE RegisterId >= 1 AND RegisterId <= 5

-- 6 a 10

UPDATE DeliveryRegisters
SET RegisterDate = GETDATE()-80, DocumentDate = GETDATE()-85, ReceptionDate = GETDATE()-80, CreateDate = GETDATE()-80, ChangeDate = GETDATE()-81
WHERE RegisterId >= 6 AND RegisterId <= 10

UPDATE OutgoingRegisters
SET RegisterDate = GETDATE()-80, DocumentDate = GETDATE()-85, SendDate = GETDATE()-80, CreateDate = GETDATE()-80, ChangeDate = GETDATE()-81
WHERE RegisterId >= 6 AND RegisterId <= 10

UPDATE IncomingRegisters
SET RegisterDate = GETDATE()-80, DocumentDate = GETDATE()-85, ReceptionDate = GETDATE()-53, CreateDate = GETDATE()-80, ChangeDate = GETDATE()-81
WHERE RegisterId >= 6 AND RegisterId <= 10

-- 11 a 20

UPDATE DeliveryRegisters
SET RegisterDate = GETDATE()-70, DocumentDate = GETDATE()-75, ReceptionDate = GETDATE()-70, CreateDate = GETDATE()-70, ChangeDate = GETDATE()-71
WHERE RegisterId >= 11 AND RegisterId <= 20

UPDATE OutgoingRegisters
SET RegisterDate = GETDATE()-70, DocumentDate = GETDATE()-75, SendDate = GETDATE()-70, CreateDate = GETDATE()-70, ChangeDate = GETDATE()-71
WHERE RegisterId >= 11 AND RegisterId <= 20

UPDATE IncomingRegisters
SET RegisterDate = GETDATE()-70, DocumentDate = GETDATE()-75, ReceptionDate = GETDATE()-53, CreateDate = GETDATE()-70, ChangeDate = GETDATE()-71
WHERE RegisterId >= 11 AND RegisterId <= 20

-- 21 a 30

UPDATE DeliveryRegisters
SET RegisterDate = GETDATE()-60, DocumentDate = GETDATE()-65, ReceptionDate = GETDATE()-60, CreateDate = GETDATE()-60, ChangeDate = GETDATE()-61
WHERE RegisterId >= 21 AND RegisterId <= 30

UPDATE OutgoingRegisters
SET RegisterDate = GETDATE()-60, DocumentDate = GETDATE()-65, SendDate = GETDATE()-60, CreateDate = GETDATE()-60, ChangeDate = GETDATE()-61
WHERE RegisterId >= 21 AND RegisterId <= 30

UPDATE IncomingRegisters
SET RegisterDate = GETDATE()-60, DocumentDate = GETDATE()-65, ReceptionDate = GETDATE()-53, CreateDate = GETDATE()-60, ChangeDate = GETDATE()-61
WHERE RegisterId >= 21 AND RegisterId <= 30

-- 31 a 40

UPDATE DeliveryRegisters
SET RegisterDate = GETDATE()-50, DocumentDate = GETDATE()-55, ReceptionDate = GETDATE()-50, CreateDate = GETDATE()-50, ChangeDate = GETDATE()-51
WHERE RegisterId >= 31 AND RegisterId <= 40

UPDATE OutgoingRegisters
SET RegisterDate = GETDATE()-50, DocumentDate = GETDATE()-55, SendDate = GETDATE()-50, CreateDate = GETDATE()-50, ChangeDate = GETDATE()-51
WHERE RegisterId >= 31 AND RegisterId <= 40

UPDATE IncomingRegisters
SET RegisterDate = GETDATE()-50, DocumentDate = GETDATE()-55, ReceptionDate = GETDATE()-53, CreateDate = GETDATE()-50, ChangeDate = GETDATE()-51
WHERE RegisterId >= 31 AND RegisterId <= 40

-- 41 a 50

UPDATE DeliveryRegisters
SET RegisterDate = GETDATE()-40, DocumentDate = GETDATE()-45, ReceptionDate = GETDATE()-40, CreateDate = GETDATE()-40, ChangeDate = GETDATE()-41
WHERE RegisterId >= 41 AND RegisterId <= 50

UPDATE OutgoingRegisters
SET RegisterDate = GETDATE()-40, DocumentDate = GETDATE()-45, SendDate = GETDATE()-40, CreateDate = GETDATE()-40, ChangeDate = GETDATE()-41
WHERE RegisterId >= 41 AND RegisterId <= 50

UPDATE IncomingRegisters
SET RegisterDate = GETDATE()-40, DocumentDate = GETDATE()-45, ReceptionDate = GETDATE()-43, CreateDate = GETDATE()-40, ChangeDate = GETDATE()-41
WHERE RegisterId >= 41 AND RegisterId <= 50

-- 51 a 60

UPDATE DeliveryRegisters
SET RegisterDate = GETDATE()-30, DocumentDate = GETDATE()-35, ReceptionDate = GETDATE()-30, CreateDate = GETDATE()-30, ChangeDate = GETDATE()-31
WHERE RegisterId >= 51 AND RegisterId <= 60

UPDATE OutgoingRegisters
SET RegisterDate = GETDATE()-30, DocumentDate = GETDATE()-35, SendDate = GETDATE()-30, CreateDate = GETDATE()-30, ChangeDate = GETDATE()-31
WHERE RegisterId >= 51 AND RegisterId <= 60

UPDATE IncomingRegisters
SET RegisterDate = GETDATE()-30, DocumentDate = GETDATE()-35, ReceptionDate = GETDATE()-33, CreateDate = GETDATE()-30, ChangeDate = GETDATE()-31
WHERE RegisterId >= 51 AND RegisterId <= 60

-- 61 a 70

UPDATE DeliveryRegisters
SET RegisterDate = GETDATE()-20, DocumentDate = GETDATE()-25, ReceptionDate = GETDATE()-20, CreateDate = GETDATE()-20, ChangeDate = GETDATE()-21
WHERE RegisterId >= 61 AND RegisterId <= 70

UPDATE OutgoingRegisters
SET RegisterDate = GETDATE()-20, DocumentDate = GETDATE()-25, SendDate = GETDATE()-20, CreateDate = GETDATE()-20, ChangeDate = GETDATE()-21
WHERE RegisterId >= 61 AND RegisterId <= 70

UPDATE IncomingRegisters
SET RegisterDate = GETDATE()-20, DocumentDate = GETDATE()-25, ReceptionDate = GETDATE()-23, CreateDate = GETDATE()-20, ChangeDate = GETDATE()-21
WHERE RegisterId >= 61 AND RegisterId <= 70

-- 71 a 80

UPDATE DeliveryRegisters
SET RegisterDate = GETDATE()-10, DocumentDate = GETDATE()-15, ReceptionDate = GETDATE()-10, CreateDate = GETDATE()-10, ChangeDate = GETDATE()-11
WHERE RegisterId >= 71 AND RegisterId <= 80

UPDATE OutgoingRegisters
SET RegisterDate = GETDATE()-10, DocumentDate = GETDATE()-15, SendDate = GETDATE()-10, CreateDate = GETDATE()-10, ChangeDate = GETDATE()-11
WHERE RegisterId >= 71 AND RegisterId <= 80

UPDATE IncomingRegisters
SET RegisterDate = GETDATE()-10, DocumentDate = GETDATE()-15, ReceptionDate = GETDATE()-13, CreateDate = GETDATE()-10, ChangeDate = GETDATE()-11
WHERE RegisterId >= 71 AND RegisterId <= 80

-- 81 a ...

UPDATE DeliveryRegisters
SET RegisterDate = GETDATE()-1, DocumentDate = GETDATE()-6, ReceptionDate = GETDATE()-1, CreateDate = GETDATE()-1, ChangeDate = GETDATE()
WHERE RegisterId >= 81

UPDATE OutgoingRegisters
SET RegisterDate = GETDATE()-1, DocumentDate = GETDATE()-6, SendDate = GETDATE()-1, CreateDate = GETDATE()-1, ChangeDate = GETDATE()
WHERE RegisterId >= 81

UPDATE IncomingRegisters
SET RegisterDate = GETDATE()-1, DocumentDate = GETDATE()-6, ReceptionDate = GETDATE()-4, CreateDate = GETDATE()-1, ChangeDate = GETDATE()
WHERE RegisterId >= 81
