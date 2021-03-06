USE [QuanLyKyTucXa]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 10/31/2017 9:43:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[UserName] [varchar](30) NOT NULL,
	[Password] [varchar](30) NOT NULL,
 CONSTRAINT [PK_ACCOUNT] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 10/31/2017 9:43:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[CustomerID] [varchar](20) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Sex] [bit] NULL,
	[Addres] [nvarchar](200) NULL,
	[Phone] [varchar](20) NULL,
	[RoomID] [varchar](10) NULL,
	[Vehicle] [nvarchar](50) NULL,
 CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[INVOICE]    Script Date: 10/31/2017 9:43:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE](
	[InvoiceID] [varchar](20) NOT NULL,
	[CustomerID] [varchar](20) NULL,
	[Month] [int] NULL,
	[Year] [int] NULL,
	[Payment] [int] NULL,
	[Description] [nvarchar](100) NULL,
 CONSTRAINT [PK_INVOICE] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[INVOICE_DETAIL]    Script Date: 10/31/2017 9:43:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE_DETAIL](
	[InvoiceID] [varchar](20) NULL,
	[ServiceID] [varchar](20) NULL,
	[Fee] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RESERVATION]    Script Date: 10/31/2017 9:43:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RESERVATION](
	[ReservationID] [varchar](30) NOT NULL,
	[CustomerID] [varchar](20) NOT NULL,
	[RoomID] [varchar](10) NOT NULL,
	[RentType] [nvarchar](50) NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NULL,
 CONSTRAINT [PK__RESERVAT__B7EE5F04162F6CED] PRIMARY KEY CLUSTERED 
(
	[ReservationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ROOM]    Script Date: 10/31/2017 9:43:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROOM](
	[RoomID] [varchar](10) NOT NULL,
	[StatusRoom] [nvarchar](50) NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK__ROOM__32863919655B1175] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SERVICE_FEE]    Script Date: 10/31/2017 9:43:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICE_FEE](
	[ServiceID] [varchar](20) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Price] [int] NULL,
	[Unit] [nvarchar](50) NULL,
 CONSTRAINT [PK__SERVICE___C51BB0EA4B0C1667] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ACCOUNT] ([UserName], [Password]) VALUES (N'admin', N'admin')
INSERT [dbo].[CUSTOMER] ([CustomerID], [Name], [Sex], [Addres], [Phone], [RoomID], [Vehicle]) VALUES (N'KH01', N'Nhan', 1, N'Da nang', N'01225447788', N'101', N'Bike')
INSERT [dbo].[CUSTOMER] ([CustomerID], [Name], [Sex], [Addres], [Phone], [RoomID], [Vehicle]) VALUES (N'KH02', N'Nhan vo', 1, N'Da nang', N'01225447788', N'101', N'None')
INSERT [dbo].[INVOICE] ([InvoiceID], [CustomerID], [Month], [Year], [Payment], [Description]) VALUES (N'171031074301', N'KH01', 10, 2017, 925000, N'')
INSERT [dbo].[INVOICE] ([InvoiceID], [CustomerID], [Month], [Year], [Payment], [Description]) VALUES (N'171031084519', N'KH01', 10, 2017, 0, N'')
INSERT [dbo].[INVOICE_DETAIL] ([InvoiceID], [ServiceID], [Fee]) VALUES (N'171031074301', N'bike', 35000)
INSERT [dbo].[INVOICE_DETAIL] ([InvoiceID], [ServiceID], [Fee]) VALUES (N'171031074301', N'water', 40000)
INSERT [dbo].[INVOICE_DETAIL] ([InvoiceID], [ServiceID], [Fee]) VALUES (N'171031074301', N'room', 500000)
INSERT [dbo].[INVOICE_DETAIL] ([InvoiceID], [ServiceID], [Fee]) VALUES (N'171031074301', N'elec', 350000)
INSERT [dbo].[RESERVATION] ([ReservationID], [CustomerID], [RoomID], [RentType], [StartDate], [EndDate]) VALUES (N'101102525KH01', N'kh01', N'101', N'Ở ghép', CAST(N'2017-10-25' AS Date), NULL)
INSERT [dbo].[RESERVATION] ([ReservationID], [CustomerID], [RoomID], [RentType], [StartDate], [EndDate]) VALUES (N'101103144KH01', N'kh01', N'101', N'Ở ghép', CAST(N'2017-09-27' AS Date), CAST(N'2017-09-30' AS Date))
INSERT [dbo].[RESERVATION] ([ReservationID], [CustomerID], [RoomID], [RentType], [StartDate], [EndDate]) VALUES (N'101103147KH01', N'kh01', N'102', N'Ở ghép', CAST(N'2017-10-31' AS Date), NULL)
INSERT [dbo].[RESERVATION] ([ReservationID], [CustomerID], [RoomID], [RentType], [StartDate], [EndDate]) VALUES (N'102103131KH01', N'kh01', N'102', N'Bao phòng', CAST(N'2017-10-31' AS Date), NULL)
INSERT [dbo].[RESERVATION] ([ReservationID], [CustomerID], [RoomID], [RentType], [StartDate], [EndDate]) VALUES (N'102103152KH01', N'kh01', N'102', N'Bao phòng', CAST(N'2017-10-31' AS Date), NULL)
INSERT [dbo].[ROOM] ([RoomID], [StatusRoom], [Price]) VALUES (N'101', N'Phòng Trống', 1000000)
INSERT [dbo].[ROOM] ([RoomID], [StatusRoom], [Price]) VALUES (N'102', N'Đủ Người', 1000000)
INSERT [dbo].[SERVICE_FEE] ([ServiceID], [Name], [Price], [Unit]) VALUES (N'bike', N'vehicle fee', 35000, N'1')
INSERT [dbo].[SERVICE_FEE] ([ServiceID], [Name], [Price], [Unit]) VALUES (N'elec', N'electric', 3500, N'1')
INSERT [dbo].[SERVICE_FEE] ([ServiceID], [Name], [Price], [Unit]) VALUES (N'motor', N'vehicle fee', 45000, NULL)
INSERT [dbo].[SERVICE_FEE] ([ServiceID], [Name], [Price], [Unit]) VALUES (N'room', N'Tiền phòng', 0, NULL)
INSERT [dbo].[SERVICE_FEE] ([ServiceID], [Name], [Price], [Unit]) VALUES (N'water', N'water', 40000, N'1')
ALTER TABLE [dbo].[INVOICE_DETAIL]  WITH CHECK ADD  CONSTRAINT [FK_Invoice Detail_INVOICE] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[INVOICE] ([InvoiceID])
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] CHECK CONSTRAINT [FK_Invoice Detail_INVOICE]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL]  WITH CHECK ADD  CONSTRAINT [FK_INVOICE_DETAIL_SERVICE_FEE] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[SERVICE_FEE] ([ServiceID])
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] CHECK CONSTRAINT [FK_INVOICE_DETAIL_SERVICE_FEE]
GO
ALTER TABLE [dbo].[RESERVATION]  WITH CHECK ADD  CONSTRAINT [FK__RESERVATI__RoomI__300424B4] FOREIGN KEY([RoomID])
REFERENCES [dbo].[ROOM] ([RoomID])
GO
ALTER TABLE [dbo].[RESERVATION] CHECK CONSTRAINT [FK__RESERVATI__RoomI__300424B4]
GO
ALTER TABLE [dbo].[RESERVATION]  WITH CHECK ADD  CONSTRAINT [FK_RESERVATION_CUSTOMER] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[CUSTOMER] ([CustomerID])
GO
ALTER TABLE [dbo].[RESERVATION] CHECK CONSTRAINT [FK_RESERVATION_CUSTOMER]
GO
