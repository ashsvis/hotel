USE [Hotel]
GO
/****** Object:  Table [dbo].[Transfers]    Script Date: 03/16/2019 11:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transfers](
	[IdTransfer] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[IdReservation] [uniqueidentifier] NOT NULL,
	[FeedAddress] [nvarchar](max) NOT NULL,
	[FeedDateTime] [nvarchar](max) NOT NULL,
	[NumberSeat] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Transfers] PRIMARY KEY CLUSTERED 
(
	[IdTransfer] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 03/16/2019 11:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[IdService] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[NameService] [nvarchar](max) NOT NULL,
	[PriceDay] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[IdService] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomServices]    Script Date: 03/16/2019 11:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomServices](
	[IdRoom] [uniqueidentifier] NOT NULL,
	[IdService] [uniqueidentifier] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 03/16/2019 11:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[IdRoom] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[IdCategory] [uniqueidentifier] NOT NULL,
	[NumberSeat] [nvarchar](max) NOT NULL,
	[Floor] [nvarchar](max) NOT NULL,
	[PriceDay] [nvarchar](max) NOT NULL,
	[RoomNumber] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[IdRoom] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomPayChannels]    Script Date: 03/16/2019 11:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomPayChannels](
	[IdAccordancePayChannel] [uniqueidentifier] NOT NULL,
	[IdPayChannel] [uniqueidentifier] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 03/16/2019 11:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[IdReservation] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[IdClient] [uniqueidentifier] NOT NULL,
	[IdRoom] [uniqueidentifier] NOT NULL,
	[ArrivalDate] [nvarchar](max) NOT NULL,
	[DepartureDate] [nvarchar](max) NOT NULL,
	[IdEmployee] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Reservations] PRIMARY KEY CLUSTERED 
(
	[IdReservation] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegistryStaff]    Script Date: 03/16/2019 11:00:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegistryStaff](
	[IdEmployee] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[IdEmployeeRole] [uniqueidentifier] NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_RegistryStaff] PRIMARY KEY CLUSTERED 
(
	[IdEmployee] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayChannels]    Script Date: 03/16/2019 11:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayChannels](
	[IdPayChannel] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[NameChannel] [nvarchar](max) NOT NULL,
	[PriceHour] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_PayChannels] PRIMARY KEY CLUSTERED 
(
	[IdPayChannel] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeRoles]    Script Date: 03/16/2019 11:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeRoles](
	[IdEmployeeRole] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[NameRole] [nvarchar](max) NOT NULL,
	[Salary] [nvarchar](max) NOT NULL,
	[AllowedOperations] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_IdEmployeeRoles] PRIMARY KEY CLUSTERED 
(
	[IdEmployeeRole] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 03/16/2019 11:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[IdClient] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Birthday] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[Passport] [nvarchar](max) NOT NULL,
	[NumberChild] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 03/16/2019 11:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[IdCategory] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[NameCategory] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[IdCategory] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccordancePayChannels]    Script Date: 03/16/2019 11:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccordancePayChannels](
	[IdAccordancePayChannel] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[IdReservation] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AccordancePayChannels] PRIMARY KEY CLUSTERED 
(
	[IdAccordancePayChannel] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_Transfers_IdTransfer]    Script Date: 03/16/2019 11:00:07 ******/
ALTER TABLE [dbo].[Transfers] ADD  CONSTRAINT [DF_Transfers_IdTransfer]  DEFAULT (newid()) FOR [IdTransfer]
GO
/****** Object:  Default [DF_Services_IdService]    Script Date: 03/16/2019 11:00:07 ******/
ALTER TABLE [dbo].[Services] ADD  CONSTRAINT [DF_Services_IdService]  DEFAULT (newid()) FOR [IdService]
GO
/****** Object:  Default [DF_Rooms_IdRoom]    Script Date: 03/16/2019 11:00:07 ******/
ALTER TABLE [dbo].[Rooms] ADD  CONSTRAINT [DF_Rooms_IdRoom]  DEFAULT (newid()) FOR [IdRoom]
GO
/****** Object:  Default [DF_Reservations_IdReservation]    Script Date: 03/16/2019 11:00:07 ******/
ALTER TABLE [dbo].[Reservations] ADD  CONSTRAINT [DF_Reservations_IdReservation]  DEFAULT (newid()) FOR [IdReservation]
GO
/****** Object:  Default [DF_RegistryStaff_IdEmployee]    Script Date: 03/16/2019 11:00:08 ******/
ALTER TABLE [dbo].[RegistryStaff] ADD  CONSTRAINT [DF_RegistryStaff_IdEmployee]  DEFAULT (newid()) FOR [IdEmployee]
GO
/****** Object:  Default [DF_PayChannels_IdPayChannel]    Script Date: 03/16/2019 11:00:08 ******/
ALTER TABLE [dbo].[PayChannels] ADD  CONSTRAINT [DF_PayChannels_IdPayChannel]  DEFAULT (newid()) FOR [IdPayChannel]
GO
/****** Object:  Default [DF_IdEmployeeRoles_IdEmployeeRole]    Script Date: 03/16/2019 11:00:08 ******/
ALTER TABLE [dbo].[EmployeeRoles] ADD  CONSTRAINT [DF_IdEmployeeRoles_IdEmployeeRole]  DEFAULT (newid()) FOR [IdEmployeeRole]
GO
/****** Object:  Default [DF_Clients_IdClient]    Script Date: 03/16/2019 11:00:08 ******/
ALTER TABLE [dbo].[Clients] ADD  CONSTRAINT [DF_Clients_IdClient]  DEFAULT (newid()) FOR [IdClient]
GO
/****** Object:  Default [DF_Categories_IdCategory]    Script Date: 03/16/2019 11:00:08 ******/
ALTER TABLE [dbo].[Categories] ADD  CONSTRAINT [DF_Categories_IdCategory]  DEFAULT (newid()) FOR [IdCategory]
GO
/****** Object:  Default [DF_AccordancePayChannels_IdAccordancePayChannel]    Script Date: 03/16/2019 11:00:08 ******/
ALTER TABLE [dbo].[AccordancePayChannels] ADD  CONSTRAINT [DF_AccordancePayChannels_IdAccordancePayChannel]  DEFAULT (newid()) FOR [IdAccordancePayChannel]
GO
