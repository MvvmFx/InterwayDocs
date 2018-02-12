-- upgrade to 1.3.7

-- remove all Stored Procedures

/****** Object:  StoredProcedure [dbo].[AddDeliveryRegister] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddDeliveryRegister]') AND type = N'P')
    DROP PROCEDURE [dbo].[AddDeliveryRegister]

/****** Object:  StoredProcedure [dbo].[AddIncomingRegister] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddIncomingRegister]') AND type = N'P')
    DROP PROCEDURE [dbo].[AddIncomingRegister]

/****** Object:  StoredProcedure [dbo].[AddOutgoingRegister] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddOutgoingRegister]') AND type = N'P')
    DROP PROCEDURE [dbo].[AddOutgoingRegister]

/****** Object:  StoredProcedure [dbo].[DeleteDeliveryRegister] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteDeliveryRegister]') AND type = N'P')
    DROP PROCEDURE [dbo].[DeleteDeliveryRegister]

/****** Object:  StoredProcedure [dbo].[DeleteIncomingRegister] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteIncomingRegister]') AND type = N'P')
    DROP PROCEDURE [dbo].[DeleteIncomingRegister]

/****** Object:  StoredProcedure [dbo].[DeleteOutgoingRegister] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteOutgoingRegister]') AND type = N'P')
    DROP PROCEDURE [dbo].[DeleteOutgoingRegister]

/****** Object:  StoredProcedure [dbo].[GetDeliveryBook] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetDeliveryBook]') AND type = N'P')
    DROP PROCEDURE [dbo].[GetDeliveryBook]

/****** Object:  StoredProcedure [dbo].[GetDeliveryRegister] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetDeliveryRegister]') AND type = N'P')
    DROP PROCEDURE [dbo].[GetDeliveryRegister]

/****** Object:  StoredProcedure [dbo].[GetIncomingBook] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIncomingBook]') AND type = N'P')
    DROP PROCEDURE [dbo].[GetIncomingBook]

/****** Object:  StoredProcedure [dbo].[GetIncomingRegister] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetIncomingRegister]') AND type = N'P')
    DROP PROCEDURE [dbo].[GetIncomingRegister]

/****** Object:  StoredProcedure [dbo].[GetOutgoingBook] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetOutgoingBook]') AND type = N'P')
    DROP PROCEDURE [dbo].[GetOutgoingBook]

/****** Object:  StoredProcedure [dbo].[GetOutgoingRegister] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetOutgoingRegister]') AND type = N'P')
    DROP PROCEDURE [dbo].[GetOutgoingRegister]

/****** Object:  StoredProcedure [dbo].[UpdateDeliveryRegister] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateDeliveryRegister]') AND type = N'P')
    DROP PROCEDURE [dbo].[UpdateDeliveryRegister]

/****** Object:  StoredProcedure [dbo].[UpdateIncomingRegister] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateIncomingRegister]') AND type = N'P')
    DROP PROCEDURE [dbo].[UpdateIncomingRegister]

/****** Object:  StoredProcedure [dbo].[UpdateOutgoingRegister] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateOutgoingRegister]') AND type = N'P')
    DROP PROCEDURE [dbo].[UpdateOutgoingRegister]

/****** Object:  StoredProcedure [dbo].[AddPropertyConfiguration] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddPropertyConfiguration]') AND type = N'P')
    DROP PROCEDURE [dbo].[AddPropertyConfiguration]

/****** Object:  StoredProcedure [dbo].[DeletePropertyConfiguration] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeletePropertyConfiguration]') AND type = N'P')
    DROP PROCEDURE [dbo].[DeletePropertyConfiguration]

/****** Object:  StoredProcedure [dbo].[GetPropertyConfigurationColl] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPropertyConfigurationColl]') AND type = N'P')
    DROP PROCEDURE [dbo].[GetPropertyConfigurationColl]

/****** Object:  StoredProcedure [dbo].[GetPropertyConfigurationList] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPropertyConfigurationList]') AND type = N'P')
    DROP PROCEDURE [dbo].[GetPropertyConfigurationList]

/****** Object:  StoredProcedure [dbo].[UpdatePropertyConfiguration] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdatePropertyConfiguration]') AND type = N'P')
    DROP PROCEDURE [dbo].[UpdatePropertyConfiguration]

-- upgrade to new configuration tables

/****** Object:  Table [dbo].[PropertyFriendyName] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PropertyFriendyName]') AND type = N'U')
    DROP TABLE [dbo].[PropertyFriendyName]

/****** Object:  Table [dbo].[PropertyConfiguration] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PropertyConfiguration]') AND type = N'U')
    DROP TABLE [dbo].[PropertyConfiguration]

/****** Object:  Table [dbo].[Roles] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Roles]') AND type = N'U')
    DROP TABLE [dbo].[Roles]

/****** Object:  Table [dbo].[PropertyConfiguration] ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[PropertyConfiguration](
	[ConfigurationId] [int] IDENTITY(1,1) NOT NULL,
	[ObjectName] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsRequired] [bit] NOT NULL,
	[IsReadOnly] [bit] NOT NULL,
	[IsVisible] [bit] NOT NULL,
	[ListOrder] [int] NOT NULL,
 CONSTRAINT [PK_PropertyConfiguration] PRIMARY KEY CLUSTERED
(
	[ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[PropertyFriendyName] ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[PropertyFriendyName](
	[ConfigurationId] [int] NOT NULL,
	[UICulture] [varchar](5) NOT NULL,
	[FriendlyName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PropertyFriendyName] PRIMARY KEY CLUSTERED
(
	[ConfigurationId] ASC,
	[UICulture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
SET IDENTITY_INSERT [dbo].[PropertyConfiguration] ON
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (1, N'DeliveryInfo', N'DocumentClass', 0, 1, 0, 7)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (2, N'DeliveryInfo', N'DocumentDate', 0, 1, 1, 8)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (3, N'DeliveryInfo', N'DocumentDept', 0, 1, 1, 6)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (4, N'DeliveryInfo', N'DocumentEntity', 0, 1, 1, 5)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (5, N'DeliveryInfo', N'DocumentReference', 0, 1, 1, 4)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (6, N'DeliveryInfo', N'DocumentType', 0, 1, 1, 3)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (7, N'DeliveryInfo', N'ExpeditorName', 0, 1, 1, 11)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (8, N'DeliveryInfo', N'ReceptionDate', 0, 1, 1, 13)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (9, N'DeliveryInfo', N'ReceptionName', 0, 1, 1, 12)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (10, N'DeliveryInfo', N'RecipientName', 0, 1, 1, 10)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (11, N'DeliveryInfo', N'RegisterDate', 0, 1, 1, 2)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (12, N'DeliveryInfo', N'RegisterId', 0, 1, 1, 1)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (13, N'DeliveryRegister', N'DocumentClass', 0, 0, 0, 7)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (14, N'DeliveryRegister', N'DocumentDate', 1, 0, 1, 8)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (15, N'DeliveryRegister', N'DocumentDept', 0, 0, 1, 6)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (16, N'DeliveryRegister', N'DocumentEntity', 1, 0, 1, 5)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (17, N'DeliveryRegister', N'DocumentReference', 1, 0, 1, 4)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (18, N'DeliveryRegister', N'DocumentType', 1, 0, 1, 3)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (19, N'DeliveryRegister', N'ExpeditorName', 1, 0, 1, 11)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (20, N'DeliveryRegister', N'ReceptionDate', 0, 0, 1, 13)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (21, N'DeliveryRegister', N'ReceptionName', 0, 0, 1, 12)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (22, N'DeliveryRegister', N'RecipientName', 1, 0, 1, 10)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (23, N'DeliveryRegister', N'RegisterDate', 1, 0, 1, 2)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (24, N'DeliveryRegister', N'RegisterId', 0, 1, 1, 1)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (25, N'IncomingInfo', N'ArchiveLocation', 0, 1, 1, 14)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (26, N'IncomingInfo', N'DocumentClass', 0, 1, 0, 7)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (27, N'IncomingInfo', N'DocumentDate', 0, 1, 1, 8)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (28, N'IncomingInfo', N'DocumentDept', 0, 1, 1, 6)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (29, N'IncomingInfo', N'DocumentEntity', 0, 1, 1, 5)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (30, N'IncomingInfo', N'DocumentReference', 0, 1, 1, 4)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (31, N'IncomingInfo', N'DocumentType', 0, 1, 1, 3)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (32, N'IncomingInfo', N'Notes', 0, 1, 1, 13)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (33, N'IncomingInfo', N'ReceptionDate', 0, 1, 1, 11)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (34, N'IncomingInfo', N'RegisterDate', 0, 1, 1, 2)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (35, N'IncomingInfo', N'RegisterId', 0, 1, 1, 1)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (36, N'IncomingInfo', N'RoutedTo', 0, 1, 1, 12)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (37, N'IncomingInfo', N'SenderName', 0, 1, 1, 10)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (38, N'IncomingInfo', N'Subject', 0, 1, 1, 9)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (39, N'IncomingRegister', N'ArchiveLocation', 0, 0, 1, 14)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (40, N'IncomingRegister', N'DocumentClass', 0, 0, 0, 7)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (41, N'IncomingRegister', N'DocumentDate', 1, 0, 1, 8)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (42, N'IncomingRegister', N'DocumentDept', 0, 0, 1, 6)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (43, N'IncomingRegister', N'DocumentEntity', 1, 0, 1, 5)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (44, N'IncomingRegister', N'DocumentReference', 1, 0, 1, 4)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (45, N'IncomingRegister', N'DocumentType', 1, 0, 1, 3)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (46, N'IncomingRegister', N'Notes', 0, 0, 1, 13)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (47, N'IncomingRegister', N'ReceptionDate', 1, 0, 1, 11)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (48, N'IncomingRegister', N'RegisterDate', 1, 0, 1, 2)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (49, N'IncomingRegister', N'RegisterId', 0, 1, 1, 1)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (50, N'IncomingRegister', N'RoutedTo', 0, 0, 1, 12)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (51, N'IncomingRegister', N'SenderName', 0, 0, 1, 10)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (52, N'IncomingRegister', N'Subject', 1, 0, 1, 9)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (53, N'OutgoingInfo', N'ArchiveLocation', 0, 1, 1, 14)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (54, N'OutgoingInfo', N'DocumentClass', 0, 1, 0, 7)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (55, N'OutgoingInfo', N'DocumentDate', 0, 1, 1, 8)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (56, N'OutgoingInfo', N'DocumentDept', 0, 1, 1, 6)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (57, N'OutgoingInfo', N'DocumentEntity', 0, 1, 1, 5)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (58, N'OutgoingInfo', N'DocumentReference', 0, 1, 1, 4)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (59, N'OutgoingInfo', N'DocumentType', 0, 1, 1, 3)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (60, N'OutgoingInfo', N'Notes', 0, 1, 1, 13)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (61, N'OutgoingInfo', N'RecipientName', 0, 1, 1, 10)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (62, N'OutgoingInfo', N'RecipientTown', 0, 1, 1, 12)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (63, N'OutgoingInfo', N'RegisterDate', 0, 1, 1, 2)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (64, N'OutgoingInfo', N'RegisterId', 0, 1, 1, 1)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (65, N'OutgoingInfo', N'SendDate', 0, 1, 1, 11)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (66, N'OutgoingInfo', N'Subject', 0, 1, 1, 9)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (67, N'OutgoingRegister', N'ArchiveLocation', 0, 0, 1, 14)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (68, N'OutgoingRegister', N'DocumentClass', 0, 0, 0, 7)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (69, N'OutgoingRegister', N'DocumentDate', 1, 0, 1, 8)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (70, N'OutgoingRegister', N'DocumentDept', 0, 0, 1, 6)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (71, N'OutgoingRegister', N'DocumentEntity', 1, 0, 1, 5)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (72, N'OutgoingRegister', N'DocumentReference', 1, 0, 1, 4)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (73, N'OutgoingRegister', N'DocumentType', 1, 0, 1, 3)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (74, N'OutgoingRegister', N'Notes', 0, 0, 1, 13)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (75, N'OutgoingRegister', N'RecipientName', 1, 0, 1, 10)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (76, N'OutgoingRegister', N'RecipientTown', 0, 0, 1, 12)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (77, N'OutgoingRegister', N'RegisterDate', 1, 0, 1, 2)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (78, N'OutgoingRegister', N'RegisterId', 0, 1, 1, 1)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (79, N'OutgoingRegister', N'SendDate', 1, 0, 1, 11)
INSERT [dbo].[PropertyConfiguration] ([ConfigurationId], [ObjectName], [Name], [IsRequired], [IsReadOnly], [IsVisible], [ListOrder]) VALUES (80, N'OutgoingRegister', N'Subject', 1, 0, 1, 9)
SET IDENTITY_INSERT [dbo].[PropertyConfiguration] OFF
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (1, N'pt-PT', N'Classificação')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (2, N'pt-PT', N'Data doc.')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (3, N'pt-PT', N'Departamento')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (4, N'pt-PT', N'Entidade')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (5, N'pt-PT', N'Nº documento')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (6, N'pt-PT', N'Tipo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (7, N'pt-PT', N'Expedido')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (8, N'pt-PT', N'Data recepção')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (9, N'pt-PT', N'Recebido')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (10, N'pt-PT', N'Destinatário')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (11, N'pt-PT', N'Data reg.')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (12, N'pt-PT', N'Nº Registo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (13, N'pt-PT', N'Classificação')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (14, N'pt-PT', N'Data')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (15, N'pt-PT', N'Departamento')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (16, N'pt-PT', N'Entidade')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (17, N'pt-PT', N'Número')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (18, N'pt-PT', N'Tipo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (19, N'pt-PT', N'Expedido por')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (20, N'pt-PT', N'Data de recepção')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (21, N'pt-PT', N'Recebido por')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (22, N'pt-PT', N'Destinatário')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (23, N'pt-PT', N'Data de registo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (24, N'pt-PT', N'Nº Registo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (25, N'pt-PT', N'Localização')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (26, N'pt-PT', N'Classificação')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (27, N'pt-PT', N'Data doc.')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (28, N'pt-PT', N'Departamento')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (29, N'pt-PT', N'Entidade')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (30, N'pt-PT', N'Nº documento')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (31, N'pt-PT', N'Tipo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (32, N'pt-PT', N'Observações')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (33, N'pt-PT', N'Data recepção')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (34, N'pt-PT', N'Data reg.')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (35, N'pt-PT', N'Nº Registo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (36, N'pt-PT', N'Encaminhado')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (37, N'pt-PT', N'Proveniência')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (38, N'pt-PT', N'Assunto')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (39, N'pt-PT', N'Localização')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (40, N'pt-PT', N'Classificação')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (41, N'pt-PT', N'Data')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (42, N'pt-PT', N'Departamento')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (43, N'pt-PT', N'Entidade')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (44, N'pt-PT', N'Número')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (45, N'pt-PT', N'Tipo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (46, N'pt-PT', N'Observações')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (47, N'pt-PT', N'Data de recepção')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (48, N'pt-PT', N'Data de registo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (49, N'pt-PT', N'Nº Registo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (50, N'pt-PT', N'Encaminhamento')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (51, N'pt-PT', N'Proveniência')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (52, N'pt-PT', N'Assunto')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (53, N'pt-PT', N'Localização')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (54, N'pt-PT', N'Classificação')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (55, N'pt-PT', N'Data doc.')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (56, N'pt-PT', N'Departamento')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (57, N'pt-PT', N'Entidade')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (58, N'pt-PT', N'Nº documento')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (59, N'pt-PT', N'Tipo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (60, N'pt-PT', N'Observações')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (61, N'pt-PT', N'Destinatário')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (62, N'pt-PT', N'Localidade')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (63, N'pt-PT', N'Data reg.')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (64, N'pt-PT', N'Nº Registo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (65, N'pt-PT', N'Data expedição')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (66, N'pt-PT', N'Assunto')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (67, N'pt-PT', N'Localização')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (68, N'pt-PT', N'Classificação')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (69, N'pt-PT', N'Data')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (70, N'pt-PT', N'Departamento')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (71, N'pt-PT', N'Entidade')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (72, N'pt-PT', N'Número')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (73, N'pt-PT', N'Tipo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (74, N'pt-PT', N'Observações')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (75, N'pt-PT', N'Destinatário')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (76, N'pt-PT', N'Localidade')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (77, N'pt-PT', N'Data de registo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (78, N'pt-PT', N'Nº Registo')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (79, N'pt-PT', N'Data de expedição')
INSERT [dbo].[PropertyFriendyName] ([ConfigurationId], [UICulture], [FriendlyName]) VALUES (80, N'pt-PT', N'Assunto')
SET ANSI_PADDING ON

/****** Object:  Index [IX_PropertyConfiguration] ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_PropertyConfiguration] ON [dbo].[PropertyConfiguration]
(
	[ObjectName] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
ALTER TABLE [dbo].[PropertyFriendyName]  WITH CHECK ADD  CONSTRAINT [FK_PropertyFriendyName_PropertyConfiguration1] FOREIGN KEY([ConfigurationId])
REFERENCES [dbo].[PropertyConfiguration] ([ConfigurationId])
ALTER TABLE [dbo].[PropertyFriendyName] CHECK CONSTRAINT [FK_PropertyFriendyName_PropertyConfiguration1]

-- make entity fields 150 characters long

-- DeliveryRegisters

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
CREATE TABLE dbo.Tmp_DeliveryRegisters
	(
	RegisterId int NOT NULL IDENTITY (1, 1),
	RegisterDate date NOT NULL,
	DocumentType varchar(25) NOT NULL,
	DocumentReference varchar(20) NOT NULL,
	DocumentEntity varchar(150) NOT NULL,
	DocumentDept varchar(150) NOT NULL,
	DocumentClass varchar(50) NOT NULL,
	DocumentDate date NOT NULL,
	RecipientName varchar(150) NOT NULL,
	ExpeditorName varchar(50) NULL,
	ReceptionName varchar(50) NULL,
	ReceptionDate date NULL,
	CreateDate datetime2(7) NOT NULL,
	ChangeDate datetime2(7) NOT NULL
	)  ON [PRIMARY]
ALTER TABLE dbo.Tmp_DeliveryRegisters SET (LOCK_ESCALATION = TABLE)
SET IDENTITY_INSERT dbo.Tmp_DeliveryRegisters ON
IF EXISTS(SELECT * FROM dbo.DeliveryRegisters)
	 EXEC('INSERT INTO dbo.Tmp_DeliveryRegisters (RegisterId, RegisterDate, DocumentType, DocumentReference, DocumentEntity, DocumentDept, DocumentClass, DocumentDate, RecipientName, ExpeditorName, ReceptionName, ReceptionDate, CreateDate, ChangeDate)
		SELECT RegisterId, RegisterDate, DocumentType, DocumentReference, DocumentEntity, DocumentDept, DocumentClass, DocumentDate, RecipientName, ExpeditorName, ReceptionName, ReceptionDate, CreateDate, ChangeDate FROM dbo.DeliveryRegisters WITH (HOLDLOCK TABLOCKX)')
SET IDENTITY_INSERT dbo.Tmp_DeliveryRegisters OFF
DROP TABLE dbo.DeliveryRegisters
EXECUTE sp_rename N'dbo.Tmp_DeliveryRegisters', N'DeliveryRegisters', 'OBJECT'
ALTER TABLE dbo.DeliveryRegisters ADD CONSTRAINT
	PK_DeliveryRegisters PRIMARY KEY CLUSTERED
	(
	RegisterId
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

CREATE NONCLUSTERED INDEX IX_DeliveryRegisters ON dbo.DeliveryRegisters
	(
	RegisterDate,
	DocumentDate,
	ReceptionDate,
	DocumentType,
	DocumentReference,
	DocumentEntity,
	DocumentDept,
	DocumentClass,
	RecipientName,
	ExpeditorName,
	ReceptionName
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
COMMIT

-- IncomingRegisters

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
CREATE TABLE dbo.Tmp_IncomingRegisters
	(
	RegisterId int NOT NULL IDENTITY (1, 1),
	RegisterDate date NOT NULL,
	DocumentType varchar(25) NOT NULL,
	DocumentReference varchar(20) NOT NULL,
	DocumentEntity varchar(150) NOT NULL,
	DocumentDept varchar(150) NOT NULL,
	DocumentClass varchar(50) NOT NULL,
	DocumentDate date NOT NULL,
	Subject varchar(500) NOT NULL,
	SenderName varchar(150) NOT NULL,
	ReceptionDate date NOT NULL,
	RoutedTo varchar(50) NOT NULL,
	Notes varchar(500) NOT NULL,
	ArchiveLocation varchar(50) NOT NULL,
	CreateDate datetime2(7) NOT NULL,
	ChangeDate datetime2(7) NOT NULL
	)  ON [PRIMARY]
ALTER TABLE dbo.Tmp_IncomingRegisters SET (LOCK_ESCALATION = TABLE)
SET IDENTITY_INSERT dbo.Tmp_IncomingRegisters ON
IF EXISTS(SELECT * FROM dbo.IncomingRegisters)
	 EXEC('INSERT INTO dbo.Tmp_IncomingRegisters (RegisterId, RegisterDate, DocumentType, DocumentReference, DocumentEntity, DocumentDept, DocumentClass, DocumentDate, Subject, SenderName, ReceptionDate, RoutedTo, Notes, ArchiveLocation, CreateDate, ChangeDate)
		SELECT RegisterId, RegisterDate, DocumentType, DocumentReference, DocumentEntity, DocumentDept, DocumentClass, DocumentDate, Subject, SenderName, ReceptionDate, RoutedTo, Notes, ArchiveLocation, CreateDate, ChangeDate FROM dbo.IncomingRegisters WITH (HOLDLOCK TABLOCKX)')
SET IDENTITY_INSERT dbo.Tmp_IncomingRegisters OFF
DROP TABLE dbo.IncomingRegisters
EXECUTE sp_rename N'dbo.Tmp_IncomingRegisters', N'IncomingRegisters', 'OBJECT'
ALTER TABLE dbo.IncomingRegisters ADD CONSTRAINT
	PK_IncomingRegisters PRIMARY KEY CLUSTERED
	(
	RegisterId
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

CREATE NONCLUSTERED INDEX IX_IncomingRegisters ON dbo.IncomingRegisters
	(
	RegisterDate,
	DocumentDate,
	ReceptionDate,
	ArchiveLocation,
	DocumentType,
	DocumentReference,
	DocumentEntity,
	DocumentDept,
	DocumentClass,
	SenderName,
	RoutedTo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
CREATE NONCLUSTERED INDEX IX_IncomingRegisters_Notes ON dbo.IncomingRegisters
	(
	Notes
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
CREATE NONCLUSTERED INDEX IX_IncomingRegisters_Subject ON dbo.IncomingRegisters
	(
	Subject
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
COMMIT

-- OutgoingRegisters

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
CREATE TABLE dbo.Tmp_OutgoingRegisters
	(
	RegisterId int NOT NULL IDENTITY (1, 1),
	RegisterDate date NOT NULL,
	DocumentType varchar(25) NOT NULL,
	DocumentReference varchar(20) NOT NULL,
	DocumentEntity varchar(150) NOT NULL,
	DocumentDept varchar(150) NOT NULL,
	DocumentClass varchar(50) NOT NULL,
	DocumentDate date NOT NULL,
	Subject varchar(500) NOT NULL,
	SendDate date NOT NULL,
	RecipientName varchar(150) NOT NULL,
	RecipientTown varchar(50) NOT NULL,
	Notes varchar(500) NOT NULL,
	ArchiveLocation varchar(50) NOT NULL,
	CreateDate datetime2(7) NOT NULL,
	ChangeDate datetime2(7) NOT NULL
	)  ON [PRIMARY]
ALTER TABLE dbo.Tmp_OutgoingRegisters SET (LOCK_ESCALATION = TABLE)
SET IDENTITY_INSERT dbo.Tmp_OutgoingRegisters ON
IF EXISTS(SELECT * FROM dbo.OutgoingRegisters)
	 EXEC('INSERT INTO dbo.Tmp_OutgoingRegisters (RegisterId, RegisterDate, DocumentType, DocumentReference, DocumentEntity, DocumentDept, DocumentClass, DocumentDate, Subject, SendDate, RecipientName, RecipientTown, Notes, ArchiveLocation, CreateDate, ChangeDate)
		SELECT RegisterId, RegisterDate, DocumentType, DocumentReference, DocumentEntity, DocumentDept, DocumentClass, DocumentDate, Subject, SendDate, RecipientName, RecipientTown, Notes, ArchiveLocation, CreateDate, ChangeDate FROM dbo.OutgoingRegisters WITH (HOLDLOCK TABLOCKX)')
SET IDENTITY_INSERT dbo.Tmp_OutgoingRegisters OFF
DROP TABLE dbo.OutgoingRegisters
EXECUTE sp_rename N'dbo.Tmp_OutgoingRegisters', N'OutgoingRegisters', 'OBJECT'
ALTER TABLE dbo.OutgoingRegisters ADD CONSTRAINT
	PK_OutgoingRegisters PRIMARY KEY CLUSTERED
	(
	RegisterId
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

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
CREATE NONCLUSTERED INDEX IX_OutgoingRegisters_Notes ON dbo.OutgoingRegisters
	(
	Notes
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
CREATE NONCLUSTERED INDEX IX_OutgoingRegisters_Subject ON dbo.OutgoingRegisters
	(
	Subject
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
COMMIT

UPDATE dbo.Configuration SET ConfigValue = N'1.3.7' WHERE ConfigKey = N'UpdatingToVersion'
