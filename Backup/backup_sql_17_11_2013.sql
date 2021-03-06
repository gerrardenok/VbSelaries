USE [master]
GO
/****** Object:  Database [Зарплаты]    Script Date: 11/17/2013 18:58:50 ******/
CREATE DATABASE [Зарплаты] ON  PRIMARY 
( NAME = N'Зарплаты', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Зарплаты.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Зарплаты_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Зарплаты_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Зарплаты] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Зарплаты].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Зарплаты] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Зарплаты] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Зарплаты] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Зарплаты] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Зарплаты] SET ARITHABORT OFF
GO
ALTER DATABASE [Зарплаты] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Зарплаты] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Зарплаты] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Зарплаты] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Зарплаты] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Зарплаты] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Зарплаты] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Зарплаты] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Зарплаты] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Зарплаты] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Зарплаты] SET  DISABLE_BROKER
GO
ALTER DATABASE [Зарплаты] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Зарплаты] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Зарплаты] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Зарплаты] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Зарплаты] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Зарплаты] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Зарплаты] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Зарплаты] SET  READ_WRITE
GO
ALTER DATABASE [Зарплаты] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Зарплаты] SET  MULTI_USER
GO
ALTER DATABASE [Зарплаты] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Зарплаты] SET DB_CHAINING OFF
GO
USE [Зарплаты]
GO
/****** Object:  Table [dbo].[Вычет_ЗП]    Script Date: 11/17/2013 18:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Вычет_ЗП](
	[Код_вычета] [bigint] IDENTITY(1,1) NOT NULL,
	[Название] [varchar](100) NOT NULL,
	[Сумма_вычета] [decimal](18, 0) NOT NULL,
	[Код_зарплаты] [bigint] NOT NULL,
 CONSTRAINT [PK_Вычет_ЗП] PRIMARY KEY CLUSTERED 
(
	[Код_вычета] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Вычет_ЗП] ON
INSERT [dbo].[Вычет_ЗП] ([Код_вычета], [Название], [Сумма_вычета], [Код_зарплаты]) VALUES (1, N'Прогулы', CAST(15000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Вычет_ЗП] ([Код_вычета], [Название], [Сумма_вычета], [Код_зарплаты]) VALUES (2, N'Прогулы', CAST(15000000 AS Decimal(18, 0)), 4)
INSERT [dbo].[Вычет_ЗП] ([Код_вычета], [Название], [Сумма_вычета], [Код_зарплаты]) VALUES (3, N'Вычет за прогулы по не уважительной причине', CAST(2419350 AS Decimal(18, 0)), 55)
INSERT [dbo].[Вычет_ЗП] ([Код_вычета], [Название], [Сумма_вычета], [Код_зарплаты]) VALUES (4, N'Вычет за прогулы по не уважительной причине', CAST(80645 AS Decimal(18, 0)), 56)
SET IDENTITY_INSERT [dbo].[Вычет_ЗП] OFF
/****** Object:  Table [dbo].[Прибавка_ЗП]    Script Date: 11/17/2013 18:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Прибавка_ЗП](
	[Код_прибавки] [bigint] IDENTITY(1,1) NOT NULL,
	[Название] [varchar](100) NOT NULL,
	[Сумма_прибавки] [decimal](18, 0) NOT NULL,
	[Код_зарплаты] [bigint] NOT NULL,
 CONSTRAINT [PK_Прибавка_ЗП] PRIMARY KEY CLUSTERED 
(
	[Код_прибавки] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Прибавка_ЗП] ON
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (1, N'Премия', CAST(500000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (2, N'Премия', CAST(500000 AS Decimal(18, 0)), 2)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (3, N'Премия', CAST(500000 AS Decimal(18, 0)), 3)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (4, N'Премия', CAST(500000 AS Decimal(18, 0)), 4)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (5, N'Премия', CAST(500000 AS Decimal(18, 0)), 5)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (6, N'Премия', CAST(500000 AS Decimal(18, 0)), 6)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (7, N'Премия', CAST(500000 AS Decimal(18, 0)), 7)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (8, N'Премия', CAST(500000 AS Decimal(18, 0)), 8)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (9, N'Премия', CAST(500000 AS Decimal(18, 0)), 9)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (10, N'Премия', CAST(500000 AS Decimal(18, 0)), 10)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (11, N'Прогулы', CAST(150000 AS Decimal(18, 0)), 1)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (12, N'Прогулы', CAST(150000 AS Decimal(18, 0)), 4)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (46, N'Надбавка за Стаж', CAST(0 AS Decimal(18, 0)), 50)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (48, N'Надбавка за Стаж', CAST(375000 AS Decimal(18, 0)), 52)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (49, N'Надбавка за Стаж', CAST(375000 AS Decimal(18, 0)), 53)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (50, N'Надбавка за Стаж', CAST(125000 AS Decimal(18, 0)), 54)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (51, N'Надбавка за Стаж', CAST(250000 AS Decimal(18, 0)), 55)
INSERT [dbo].[Прибавка_ЗП] ([Код_прибавки], [Название], [Сумма_прибавки], [Код_зарплаты]) VALUES (52, N'Надбавка за Стаж', CAST(250000 AS Decimal(18, 0)), 56)
SET IDENTITY_INSERT [dbo].[Прибавка_ЗП] OFF
/****** Object:  Table [dbo].[Отдел]    Script Date: 11/17/2013 18:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Отдел](
	[Код_отдела] [bigint] IDENTITY(1,1) NOT NULL,
	[Название] [varchar](50) NOT NULL,
	[Описание] [text] NULL,
	[Фонд_ЗП] [decimal](30, 0) NOT NULL,
 CONSTRAINT [PK_Отдел] PRIMARY KEY CLUSTERED 
(
	[Код_отдела] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Название_отдела] UNIQUE NONCLUSTERED 
(
	[Название] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Отдел] ON
INSERT [dbo].[Отдел] ([Код_отдела], [Название], [Описание], [Фонд_ЗП]) VALUES (1, N'Производственный отдел', N'В этом отделе работают столяры, слесари, специалисты по отделачным работам и т.д.', CAST(50000000 AS Decimal(30, 0)))
INSERT [dbo].[Отдел] ([Код_отдела], [Название], [Описание], [Фонд_ЗП]) VALUES (2, N'Финансовый отдел', N'В этом отделе работают бухгалтера', CAST(20000000 AS Decimal(30, 0)))
INSERT [dbo].[Отдел] ([Код_отдела], [Название], [Описание], [Фонд_ЗП]) VALUES (3, N'Кадровый отдел', N'В этом отделе работают специалисты по кадрам, инжинеры по охране труда и т.д.', CAST(20000000 AS Decimal(30, 0)))
INSERT [dbo].[Отдел] ([Код_отдела], [Название], [Описание], [Фонд_ЗП]) VALUES (4, N'Начальство', N'Директор и его замы', CAST(80000000 AS Decimal(30, 0)))
SET IDENTITY_INSERT [dbo].[Отдел] OFF
/****** Object:  Table [dbo].[Ставка]    Script Date: 11/17/2013 18:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ставка](
	[Код_ставки] [bigint] IDENTITY(1,1) NOT NULL,
	[Название] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Ставка] PRIMARY KEY CLUSTERED 
(
	[Код_ставки] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Ставка] ON
INSERT [dbo].[Ставка] ([Код_ставки], [Название]) VALUES (1, N'Полная ставка')
INSERT [dbo].[Ставка] ([Код_ставки], [Название]) VALUES (2, N'0.5 ставка')
INSERT [dbo].[Ставка] ([Код_ставки], [Название]) VALUES (3, N'0.25 ставка')
SET IDENTITY_INSERT [dbo].[Ставка] OFF
/****** Object:  Table [dbo].[Специальность]    Script Date: 11/17/2013 18:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Специальность](
	[Код_специальности] [bigint] IDENTITY(1,1) NOT NULL,
	[Название] [varchar](50) NOT NULL,
	[Описание] [text] NULL,
 CONSTRAINT [PK_Специальность] PRIMARY KEY CLUSTERED 
(
	[Код_специальности] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Название_специальности] ON [dbo].[Специальность] 
(
	[Название] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Специальность] ON
INSERT [dbo].[Специальность] ([Код_специальности], [Название], [Описание]) VALUES (1, N'Столяр 4-ого разряда', N'')
INSERT [dbo].[Специальность] ([Код_специальности], [Название], [Описание]) VALUES (2, N'Столяр 5-ого разряда', N'')
INSERT [dbo].[Специальность] ([Код_специальности], [Название], [Описание]) VALUES (3, N'Столяр 6-ого разряда', N'')
INSERT [dbo].[Специальность] ([Код_специальности], [Название], [Описание]) VALUES (4, N'Слесарь 4-ого разряда', N'')
INSERT [dbo].[Специальность] ([Код_специальности], [Название], [Описание]) VALUES (5, N'Слесарь 5-ого разряда', N'')
INSERT [dbo].[Специальность] ([Код_специальности], [Название], [Описание]) VALUES (6, N'Слесарь 6-ого разряда', N'')
INSERT [dbo].[Специальность] ([Код_специальности], [Название], [Описание]) VALUES (7, N'Главный бухгатер', N'')
INSERT [dbo].[Специальность] ([Код_специальности], [Название], [Описание]) VALUES (8, N'Бухгалтер', N'')
INSERT [dbo].[Специальность] ([Код_специальности], [Название], [Описание]) VALUES (9, N'Специалист по кадрам', N'')
INSERT [dbo].[Специальность] ([Код_специальности], [Название], [Описание]) VALUES (10, N'Главный Директор', N'')
SET IDENTITY_INSERT [dbo].[Специальность] OFF
/****** Object:  Table [dbo].[Работник]    Script Date: 11/17/2013 18:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Работник](
	[Код_работника] [bigint] IDENTITY(1,1) NOT NULL,
	[Имя] [nchar](50) NOT NULL,
	[Фамилия] [nchar](50) NOT NULL,
	[Отчество] [nchar](50) NOT NULL,
	[Дата_приёма] [date] NOT NULL,
	[Телефон] [varchar](50) NOT NULL,
	[Номер_пасспорта] [varchar](50) NOT NULL,
	[Стаж]  AS (datepart(year,getdate())-datepart(year,[Дата_приёма])),
	[Код_ставки] [bigint] NOT NULL,
	[Код_отдела] [bigint] NOT NULL,
	[Код_специальности] [bigint] NOT NULL,
	[Дата_увольнения] [date] NULL,
 CONSTRAINT [PK_Работник] PRIMARY KEY CLUSTERED 
(
	[Код_работника] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Работник] ON
INSERT [dbo].[Работник] ([Код_работника], [Имя], [Фамилия], [Отчество], [Дата_приёма], [Телефон], [Номер_пасспорта], [Код_ставки], [Код_отдела], [Код_специальности], [Дата_увольнения]) VALUES (1, N'Иван                                              ', N'Иванов                                            ', N'Иванович                                          ', CAST(0x0F350B00 AS Date), N'+375 (29) 111-11-11', N'MP1111111', 1, 1, 2, NULL)
INSERT [dbo].[Работник] ([Код_работника], [Имя], [Фамилия], [Отчество], [Дата_приёма], [Телефон], [Номер_пасспорта], [Код_ставки], [Код_отдела], [Код_специальности], [Дата_увольнения]) VALUES (2, N'Петр                                              ', N'Петров                                            ', N'Петрович                                          ', CAST(0x9A330B00 AS Date), N'+375 (29) 222-22-22', N'MP2222222', 1, 1, 4, NULL)
INSERT [dbo].[Работник] ([Код_работника], [Имя], [Фамилия], [Отчество], [Дата_приёма], [Телефон], [Номер_пасспорта], [Код_ставки], [Код_отдела], [Код_специальности], [Дата_увольнения]) VALUES (3, N'Василий                                           ', N'Васильев                                          ', N'Васильевич                                        ', CAST(0x75360B00 AS Date), N'+375 (29) 333-33-33', N'MP333333', 1, 1, 3, NULL)
INSERT [dbo].[Работник] ([Код_работника], [Имя], [Фамилия], [Отчество], [Дата_приёма], [Телефон], [Номер_пасспорта], [Код_ставки], [Код_отдела], [Код_специальности], [Дата_увольнения]) VALUES (4, N'Михаил                                            ', N'Михаилов                                          ', N'Михилович                                         ', CAST(0x57360B00 AS Date), N'+375 (29) 444-44-44', N'MP4444444', 1, 1, 1, NULL)
INSERT [dbo].[Работник] ([Код_работника], [Имя], [Фамилия], [Отчество], [Дата_приёма], [Телефон], [Номер_пасспорта], [Код_ставки], [Код_отдела], [Код_специальности], [Дата_увольнения]) VALUES (5, N'Филип                                             ', N'Филипов                                           ', N'Филипвич                                          ', CAST(0x7A360B00 AS Date), N'+375 (29) 555-55-55', N'MP555555', 1, 1, 5, NULL)
INSERT [dbo].[Работник] ([Код_работника], [Имя], [Фамилия], [Отчество], [Дата_приёма], [Телефон], [Номер_пасспорта], [Код_ставки], [Код_отдела], [Код_специальности], [Дата_увольнения]) VALUES (6, N'Александр                                         ', N'Александров                                       ', N'Александрович                                     ', CAST(0x77360B00 AS Date), N'+375 (29) 666-66-66', N'MP666666', 1, 1, 6, NULL)
INSERT [dbo].[Работник] ([Код_работника], [Имя], [Фамилия], [Отчество], [Дата_приёма], [Телефон], [Номер_пасспорта], [Код_ставки], [Код_отдела], [Код_специальности], [Дата_увольнения]) VALUES (7, N'Алексей                                           ', N'Алексеев                                          ', N'Алексеевич                                        ', CAST(0x57360B00 AS Date), N'+375 (29) 777-77-77', N'MP7777777', 1, 2, 7, NULL)
INSERT [dbo].[Работник] ([Код_работника], [Имя], [Фамилия], [Отчество], [Дата_приёма], [Телефон], [Номер_пасспорта], [Код_ставки], [Код_отдела], [Код_специальности], [Дата_увольнения]) VALUES (8, N'Татьяна                                           ', N'Татьянова                                         ', N'Ивановна                                          ', CAST(0x57360B00 AS Date), N'+375 (29) 888-88-88', N'MP8888888', 1, 2, 8, NULL)
INSERT [dbo].[Работник] ([Код_работника], [Имя], [Фамилия], [Отчество], [Дата_приёма], [Телефон], [Номер_пасспорта], [Код_ставки], [Код_отдела], [Код_специальности], [Дата_увольнения]) VALUES (9, N'Марина                                            ', N'Маринова                                          ', N'Ивановна                                          ', CAST(0x57360B00 AS Date), N'+375 (29) 999-99-99', N'MP9999999', 1, 3, 9, NULL)
INSERT [dbo].[Работник] ([Код_работника], [Имя], [Фамилия], [Отчество], [Дата_приёма], [Телефон], [Номер_пасспорта], [Код_ставки], [Код_отдела], [Код_специальности], [Дата_увольнения]) VALUES (10, N'Дмитрий                                           ', N'Дритриев                                          ', N'Дмитриевич                                        ', CAST(0x38360B00 AS Date), N'+375 (29) 100-00-00', N'MP100000', 1, 4, 10, NULL)
SET IDENTITY_INSERT [dbo].[Работник] OFF
/****** Object:  Table [dbo].[Зарплата]    Script Date: 11/17/2013 18:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Зарплата](
	[Месяц] [tinyint] NOT NULL,
	[Оклад] [decimal](18, 0) NOT NULL,
	[На_руки] [decimal](18, 0) NULL,
	[Год] [int] NOT NULL,
	[Код_зарплаты] [bigint] IDENTITY(1,1) NOT NULL,
	[Дата_выдачи] [datetime] NOT NULL,
	[Код_работника] [bigint] NOT NULL,
 CONSTRAINT [PK_Зарплата] PRIMARY KEY CLUSTERED 
(
	[Код_зарплаты] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Зарплата] SET (LOCK_ESCALATION = DISABLE)
GO
SET IDENTITY_INSERT [dbo].[Зарплата] ON
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(2500000 AS Decimal(18, 0)), CAST(2985000 AS Decimal(18, 0)), 2013, 1, CAST(0x0000A17900000000 AS DateTime), 1)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(3500000 AS Decimal(18, 0)), CAST(4000000 AS Decimal(18, 0)), 2013, 2, CAST(0x0000A17900000000 AS DateTime), 2)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(1500000 AS Decimal(18, 0)), CAST(2500000 AS Decimal(18, 0)), 2013, 3, CAST(0x0000A17400000000 AS DateTime), 3)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(3500000 AS Decimal(18, 0)), CAST(-12500000 AS Decimal(18, 0)), 2013, 4, CAST(0x0000A17900000000 AS DateTime), 4)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(2500000 AS Decimal(18, 0)), CAST(3000000 AS Decimal(18, 0)), 2013, 5, CAST(0x0000A17900000000 AS DateTime), 5)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(3500000 AS Decimal(18, 0)), CAST(4000000 AS Decimal(18, 0)), 2013, 6, CAST(0x0000A17900000000 AS DateTime), 6)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(1500000 AS Decimal(18, 0)), CAST(2500000 AS Decimal(18, 0)), 2013, 7, CAST(0x0000A17900000000 AS DateTime), 7)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(3500000 AS Decimal(18, 0)), CAST(4000000 AS Decimal(18, 0)), 2013, 8, CAST(0x0000A17900000000 AS DateTime), 8)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(2500000 AS Decimal(18, 0)), CAST(3000000 AS Decimal(18, 0)), 2013, 9, CAST(0x0000A17900000000 AS DateTime), 9)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(3500000 AS Decimal(18, 0)), CAST(4000000 AS Decimal(18, 0)), 2013, 10, CAST(0x0000A17900000000 AS DateTime), 1)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(1500000 AS Decimal(18, 0)), CAST(2500000 AS Decimal(18, 0)), 2013, 11, CAST(0x0000A17900000000 AS DateTime), 2)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(3500000 AS Decimal(18, 0)), CAST(4000000 AS Decimal(18, 0)), 2013, 12, CAST(0x0000A17900000000 AS DateTime), 3)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(200000 AS Decimal(18, 0)), CAST(200000 AS Decimal(18, 0)), 2013, 50, CAST(0x0000A17900000000 AS DateTime), 3)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(2500000 AS Decimal(18, 0)), CAST(2875000 AS Decimal(18, 0)), 2013, 52, CAST(0x0000A17900000000 AS DateTime), 2)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(2500000 AS Decimal(18, 0)), CAST(2875000 AS Decimal(18, 0)), 2013, 53, CAST(0x0000A17900000000 AS DateTime), 2)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(2500000 AS Decimal(18, 0)), CAST(2625000 AS Decimal(18, 0)), 2013, 54, CAST(0x0000A25800000000 AS DateTime), 10)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(2500000 AS Decimal(18, 0)), CAST(330650 AS Decimal(18, 0)), 2013, 55, CAST(0x0000A25800000000 AS DateTime), 1)
INSERT [dbo].[Зарплата] ([Месяц], [Оклад], [На_руки], [Год], [Код_зарплаты], [Дата_выдачи], [Код_работника]) VALUES (10, CAST(2500000 AS Decimal(18, 0)), CAST(2669355 AS Decimal(18, 0)), 2013, 56, CAST(0x0000A25800000000 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Зарплата] OFF
/****** Object:  Table [dbo].[Пропуск]    Script Date: 11/17/2013 18:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Пропуск](
	[Код_пропуска] [bigint] IDENTITY(1,1) NOT NULL,
	[Причина] [text] NOT NULL,
	[Оплата] [tinyint] NOT NULL,
	[Код_работника] [bigint] NOT NULL,
	[Месяц] [tinyint] NOT NULL,
	[Год] [int] NOT NULL,
 CONSTRAINT [PK_Пропуск] PRIMARY KEY CLUSTERED 
(
	[Код_пропуска] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Пропуск] ON
INSERT [dbo].[Пропуск] ([Код_пропуска], [Причина], [Оплата], [Код_работника], [Месяц], [Год]) VALUES (1, N'Болезнь', 1, 9, 10, 2013)
INSERT [dbo].[Пропуск] ([Код_пропуска], [Причина], [Оплата], [Код_работника], [Месяц], [Год]) VALUES (2, N'Уход за больным ребёнком', 1, 10, 10, 2013)
INSERT [dbo].[Пропуск] ([Код_пропуска], [Причина], [Оплата], [Код_работника], [Месяц], [Год]) VALUES (3, N'Нет уважительной причины', 0, 1, 10, 2013)
INSERT [dbo].[Пропуск] ([Код_пропуска], [Причина], [Оплата], [Код_работника], [Месяц], [Год]) VALUES (4, N'Уход за родителями пенсионерами', 1, 2, 10, 2013)
SET IDENTITY_INSERT [dbo].[Пропуск] OFF
/****** Object:  Check [Ограничение_на_фонд]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Отдел]  WITH CHECK ADD  CONSTRAINT [Ограничение_на_фонд] CHECK  (([Фонд_ЗП]>(0)))
GO
ALTER TABLE [dbo].[Отдел] CHECK CONSTRAINT [Ограничение_на_фонд]
GO
/****** Object:  Check [CK_Ограничение_на_дату]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Работник]  WITH CHECK ADD  CONSTRAINT [CK_Ограничение_на_дату] CHECK  (([Дата_приёма]<=getdate()))
GO
ALTER TABLE [dbo].[Работник] CHECK CONSTRAINT [CK_Ограничение_на_дату]
GO
/****** Object:  Check [Ограничение_на_год]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Зарплата]  WITH CHECK ADD  CONSTRAINT [Ограничение_на_год] CHECK  (([Год]<=datepart(year,getdate())))
GO
ALTER TABLE [dbo].[Зарплата] CHECK CONSTRAINT [Ограничение_на_год]
GO
/****** Object:  Check [Ограничение_на_дату]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Зарплата]  WITH CHECK ADD  CONSTRAINT [Ограничение_на_дату] CHECK  (([Дата_выдачи]<=getdate()))
GO
ALTER TABLE [dbo].[Зарплата] CHECK CONSTRAINT [Ограничение_на_дату]
GO
/****** Object:  Check [Ограничение_на_месяц]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Зарплата]  WITH CHECK ADD  CONSTRAINT [Ограничение_на_месяц] CHECK  (([Месяц]>(0) AND [Месяц]<(13)))
GO
ALTER TABLE [dbo].[Зарплата] CHECK CONSTRAINT [Ограничение_на_месяц]
GO
/****** Object:  Check [Ограничение_на_оклад]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Зарплата]  WITH CHECK ADD  CONSTRAINT [Ограничение_на_оклад] CHECK  (([Оклад]>(0)))
GO
ALTER TABLE [dbo].[Зарплата] CHECK CONSTRAINT [Ограничение_на_оклад]
GO
/****** Object:  Check [CK_Дата_пропуска]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Пропуск]  WITH CHECK ADD  CONSTRAINT [CK_Дата_пропуска] CHECK  (([Год]<=datepart(year,getdate()) AND ([Месяц]>(0) AND [Месяц]<(13))))
GO
ALTER TABLE [dbo].[Пропуск] CHECK CONSTRAINT [CK_Дата_пропуска]
GO
/****** Object:  ForeignKey [FK_Вычет_ЗП_Зарплата]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Вычет_ЗП]  WITH CHECK ADD  CONSTRAINT [FK_Вычет_ЗП_Зарплата] FOREIGN KEY([Код_зарплаты])
REFERENCES [dbo].[Зарплата] ([Код_зарплаты])
GO
ALTER TABLE [dbo].[Вычет_ЗП] CHECK CONSTRAINT [FK_Вычет_ЗП_Зарплата]
GO
/****** Object:  ForeignKey [FK_Прибавка_ЗП_Зарплата]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Прибавка_ЗП]  WITH CHECK ADD  CONSTRAINT [FK_Прибавка_ЗП_Зарплата] FOREIGN KEY([Код_зарплаты])
REFERENCES [dbo].[Зарплата] ([Код_зарплаты])
GO
ALTER TABLE [dbo].[Прибавка_ЗП] CHECK CONSTRAINT [FK_Прибавка_ЗП_Зарплата]
GO
/****** Object:  ForeignKey [FK_Специальность_Специальность]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Специальность]  WITH CHECK ADD  CONSTRAINT [FK_Специальность_Специальность] FOREIGN KEY([Код_специальности])
REFERENCES [dbo].[Специальность] ([Код_специальности])
GO
ALTER TABLE [dbo].[Специальность] CHECK CONSTRAINT [FK_Специальность_Специальность]
GO
/****** Object:  ForeignKey [FK_Работник_Отдел]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Работник]  WITH CHECK ADD  CONSTRAINT [FK_Работник_Отдел] FOREIGN KEY([Код_отдела])
REFERENCES [dbo].[Отдел] ([Код_отдела])
GO
ALTER TABLE [dbo].[Работник] CHECK CONSTRAINT [FK_Работник_Отдел]
GO
/****** Object:  ForeignKey [FK_Работник_Специальность]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Работник]  WITH CHECK ADD  CONSTRAINT [FK_Работник_Специальность] FOREIGN KEY([Код_специальности])
REFERENCES [dbo].[Специальность] ([Код_специальности])
GO
ALTER TABLE [dbo].[Работник] CHECK CONSTRAINT [FK_Работник_Специальность]
GO
/****** Object:  ForeignKey [FK_Работник_Ставка]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Работник]  WITH CHECK ADD  CONSTRAINT [FK_Работник_Ставка] FOREIGN KEY([Код_ставки])
REFERENCES [dbo].[Ставка] ([Код_ставки])
GO
ALTER TABLE [dbo].[Работник] CHECK CONSTRAINT [FK_Работник_Ставка]
GO
/****** Object:  ForeignKey [FK_Зарплата_Работник]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Зарплата]  WITH CHECK ADD  CONSTRAINT [FK_Зарплата_Работник] FOREIGN KEY([Код_работника])
REFERENCES [dbo].[Работник] ([Код_работника])
GO
ALTER TABLE [dbo].[Зарплата] CHECK CONSTRAINT [FK_Зарплата_Работник]
GO
/****** Object:  ForeignKey [FK_Пропуск_Работник]    Script Date: 11/17/2013 18:58:51 ******/
ALTER TABLE [dbo].[Пропуск]  WITH CHECK ADD  CONSTRAINT [FK_Пропуск_Работник] FOREIGN KEY([Код_работника])
REFERENCES [dbo].[Работник] ([Код_работника])
GO
ALTER TABLE [dbo].[Пропуск] CHECK CONSTRAINT [FK_Пропуск_Работник]
GO
