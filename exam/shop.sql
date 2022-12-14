USE [master]
GO
/****** Object:  Database [db_music]    Script Date: 24.08.2022 6:42:25 ******/
CREATE DATABASE [db_music]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_music', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_music.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_music_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_music_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_music] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_music].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_music] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_music] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_music] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_music] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_music] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_music] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_music] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_music] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_music] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_music] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_music] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_music] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_music] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_music] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_music] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_music] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_music] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_music] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_music] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_music] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_music] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_music] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_music] SET RECOVERY FULL 
GO
ALTER DATABASE [db_music] SET  MULTI_USER 
GO
ALTER DATABASE [db_music] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_music] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_music] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_music] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_music] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_music] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_music', N'ON'
GO
ALTER DATABASE [db_music] SET QUERY_STORE = OFF
GO
USE [db_music]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 24.08.2022 6:42:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](20) NULL,
	[Phone] [nvarchar](20) NULL,
	[TotalSum] [money] NULL,
	[Discount]  AS (([TotalSum]/(10000))*(0.1)) PERSISTED,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genres]    Script Date: 24.08.2022 6:42:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genres](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GenreName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 24.08.2022 6:42:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[SellerId] [int] NULL,
	[RecordId] [int] NULL,
	[ProductCount] [int] NULL,
	[CustomerId] [int] NULL,
	[SaleId] [int] NULL,
	[Price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Records]    Script Date: 24.08.2022 6:42:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Records](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateAdd] [datetime] NULL,
	[RecordName] [nvarchar](50) NOT NULL,
	[TeamdName] [nvarchar](50) NULL,
	[PublisherName] [nvarchar](50) NULL,
	[CountTracks] [int] NULL,
	[GenreId] [int] NULL,
	[Year] [int] NULL,
	[CostPrice] [money] NULL,
	[SellPrice] [money] NULL,
	[RecordsCount] [int] NULL,
	[Prodano] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 24.08.2022 6:42:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[GenreId] [int] NULL,
	[Discount] [int] NULL,
	[DateBegin] [datetime] NOT NULL,
	[DateEnd] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sellers]    Script Date: 24.08.2022 6:42:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sellers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](20) NULL,
	[Login] [varchar](30) NOT NULL,
	[Password] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (1, N'default', N'default', N'+86 (122) 840-3705', 0.0000)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (2, N'Morgen', N'Corley', N'+7(57 ) 405- 426', 1511.6000)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (3, N'Lil', N'Lamba', N'+98 (710) 425-7717', 907.7900)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (4, N'Bill', N'Gilpillan', N'+52 (920) 811-0927', 1560.5400)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (5, N'Gilli', N'Luna', N'+62 (861) 321-5822', 1254.6200)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (6, N'Chloe', N'Horche', N'+7 (122) 411-3591', 564.0400)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (7, N'Taite', N'Keepe', N'+420 (824) 795-7144', 1961.0500)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (8, N'Paige', N'Verriour', N'+1 (504) 313-3292', 278.8100)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (9, N'Waverly', N'Frangione', N'+269 (808) 237-9735', 195.1800)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (10, N'Noella', N'Petschel', N'+63 (616) 337-0151', 699.0100)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (11, N'Thomasin', N'McComiskie', N'+237 (114) 948-1576', 147.7200)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (12, N'Guilbert', N'Hazell', N'+86 (802) 145-1101', 456.6900)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (13, N'Edmon', N'Teasdale', N'+351 (309) 490-7614', 895.7200)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (14, N'Celeste', N'Clemmow', N'+689 (383) 794-4196', 362.4200)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (15, N'Dominica', N'Deme', N'+381 (492) 619-0184', 962.0800)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (16, N'Daven', N'Roark', N'+86 (190) 930-8164', 799.3900)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (17, N'Orlan', N'Tewelson', N'+1 (713) 843-4056', 688.2100)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (18, N'Meade', N'Whifen', N'+49 (956) 900-8545', 1290.8300)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (19, N'Emmet', N'Petlyura', N'+84 (693) 424-9339', 1869.2300)
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [Phone], [TotalSum]) VALUES (20, N'Dulcie', N'Canadine', N'+420 (471) 451-7169', 1591.9800)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Genres] ON 

INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (1, N'Comedy11')
INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (7, N'Documentary')
INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (10, N'Drama')
INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (8, N'Fantasy')
INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (4, N'Sci-Fi')
INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (9, N'Thriller')
INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (5, N'War')
INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (11, N'тест')
SET IDENTITY_INSERT [dbo].[Genres] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (2, CAST(N'2021-09-09T00:00:00.000' AS DateTime), 12, 88, 46, 1, 2, 14.0700)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (4, CAST(N'2021-09-11T00:00:00.000' AS DateTime), 11, 17, 43, 13, 1, 1333.1200)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (5, CAST(N'2022-04-06T00:00:00.000' AS DateTime), 16, 74, 85, 1, 6, 1953.5500)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (11, CAST(N'2022-08-23T00:46:39.937' AS DateTime), 11, 12, 12, 2, 2, 1555.0000)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (12, CAST(N'2022-08-23T11:27:44.367' AS DateTime), 11, 12, 12, 1, 2, 1555.0000)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (13, CAST(N'2022-08-23T11:27:52.073' AS DateTime), 5, 12, 55, 1, 1, 25555.0000)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (14, CAST(N'2022-08-23T12:01:06.603' AS DateTime), 3, 12, 1, 1, 1, 1555.0000)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (15, CAST(N'2022-08-23T13:58:58.147' AS DateTime), 3, 5, 4, 4, 4, 555.0000)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (21, CAST(N'2022-08-24T01:59:31.827' AS DateTime), 11, 5, 2, 5, 4, 147.6128)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (22, CAST(N'2022-08-24T02:43:05.797' AS DateTime), 11, 14, 10, 7, 4, 11522.7479)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (23, CAST(N'2022-08-24T03:55:32.307' AS DateTime), 11, 10, 1, 8, 4, 780.9996)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (24, CAST(N'2022-08-24T04:11:58.137' AS DateTime), 11, 6, 1, 19, 4, 800.8277)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (25, CAST(N'2022-08-24T04:13:52.007' AS DateTime), 11, 12, 1, 7, 4, 1190.7227)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [SellerId], [RecordId], [ProductCount], [CustomerId], [SaleId], [Price]) VALUES (26, CAST(N'2022-08-24T04:34:55.040' AS DateTime), 11, 5, 1, 2, 3, 73.8045)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Records] ON 

INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (1, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Lake of Fire', N'Pixonyx', N'Great Elm Capital Corp.', 9, 4, 2016, 9127.8387, 1086.4380, 0, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (2, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Backstage', N'Camido', N'Retrophin, Inc.', 8, 1, 2007, 14136.2062, 218.8474, 23, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (3, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Resident Evil: Retribution', N'Stag Industrial, Inc.', N'Stag Industrial, Inc.', 4, 4, 1997, 6771.4886, 11111.0000, 1, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (4, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Far Horizons, The', N'Avavee', N'Summit Hotel Properties, Inc.', 1, 8, 1994, 2525.1381, 1254.9279, 65, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (5, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'2:22', N'Yodo', N'FutureFuel Corp.', 8, 1, 2014, 6044.8198, 73.8157, 39, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (6, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Reel Rock 8 ', N'Jaxspan', N'Micronet Enertec Technologies, Inc.', 7, 4, 2002, 9418.1570, 800.9775, 9, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (7, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Neverwhere', N'Cogibox', N'Pebblebrook Hotel Trust', 7, 7, 1999, 7648.8183, 785.2199, 89, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (9, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Rafa', N'Brainverse', N'LeMaitre Vascular, Inc.', 1, 8, 1998, 13194.8006, 550.9076, 99, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (10, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Tall Man, The', N'Oyonder', N'Rightside Group, Ltd.', 10, 1, 2009, 13850.6189, 781.0214, 56, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (11, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Sex and the City', N'Leexo', N'Till Capital Ltd.', 10, 4, 2004, 8208.2028, 850.9376, 86, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (12, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Bon Voyage', N'Photofeed', N'TriplePoint Venture Growth BDC Corp.', 5, 5, 2013, 11458.8447, 1190.9563, 98, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (13, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Alphabet', N'Eire', N'NetSol Technologies Inc.', 9, 9, 2007, 354.2239, 363.4401, 59, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (14, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Six Days', N'Skiptube', N'Cowen Inc.', 4, 1, 2012, 6708.0552, 1152.5008, 100, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (15, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Herbie: Fully Loaded', N'Agimba', N'Altria Group', 4, 4, 2019, 437.6687, 113.3640, 57, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (16, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Trouble with the Truth, The', N'Browsedrive', N'Franklin Resources, Inc.', 3, 8, 2014, 3823.5810, 646.5473, 52, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (17, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Muppets, The', N'Avavee', N'Net Element, Inc.', 1, 8, 2019, 7838.0030, 1157.6420, 84, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (18, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Movie Crazy', N'Wikizz', N'Chatham Lodging Trust (REIT)', 8, 10, 2010, 5090.8249, 86.8895, 57, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (19, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Sound City', N'JumpXS', N'Sohu.com Inc.', 8, 10, 1997, 8799.7114, 358.8913, 41, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (20, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Passion of Anna, The (Passion, En)', N'Gabtype', N'Aircastle Limited', 8, 1, 1995, 2864.5760, 538.7344, 37, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (21, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Dawn Patrol, The (Flight Commander)', N'Skippad', N'Unity Bancorp, Inc.', 2, 1, 1998, 4120.7289, 1283.4463, 28, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (22, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Celebration, The (Festen)', N'Browsetype', N'NiSource, Inc', 2, 8, 2018, 9438.7427, 219.5763, 24, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (23, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Nobody Loves Me (Keiner liebt mich)', N'Centizu', N'National Research Corporation', 7, 8, 2007, 12732.1013, 402.5659, 44, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (24, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Promised Land', N'Realbuzz', N'Global Ship Lease, Inc.', 8, 1, 1984, 5389.4662, 1368.3751, 45, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (25, CAST(N'2022-08-22T23:41:24.560' AS DateTime), N'Cousin Bette', N'Browsebug', N'Pfizer, Inc.', 3, 1, 2005, 1994.5635, 206.3769, 59, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (26, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Invisible Ray, The', N'Photojam', N'Bank of America Corporation', 9, 7, 1993, 10792.2659, 1276.1235, 11, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (27, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Small Soldiers', N'Fivespan', N'Brainstorm Cell Therapeutics Inc.', 5, 8, 2007, 7676.9941, 1300.9483, 17, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (28, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'View from the Top, A', N'Yakijo', N'MicroStrategy Incorporated', 8, 4, 1982, 8867.0436, 796.9847, 79, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (29, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'I Shot Andy Warhol', N'Katz', N'GP Strategies Corporation', 7, 7, 2015, 4541.0193, 1006.6266, 85, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (30, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Grand Seduction, The', N'Topiclounge', N'LSC Communications, Inc.', 1, 4, 2006, 1949.8813, 457.2142, 67, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (32, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Stomp the Yard', N'Voonyx', N'Green Plains Partners LP', 7, 8, 1995, 13837.4091, 362.3206, 58, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (33, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Splice', N'Skynoodle', N'Star Bulk Carriers Corp.', 1, 4, 2005, 9918.8199, 695.0025, 59, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (34, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Sea Fog', N'Zooxo', N'Orange', 3, 5, 1995, 3808.9750, 773.8280, 72, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (35, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Star Wars: The Clone Wars', N'Omba', N'Essex Property Trust, Inc.', 1, 1, 1998, 13019.0017, 1295.9551, 52, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (37, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Ravenous', N'Jamia', N'Anthera Pharmaceuticals, Inc.', 3, 7, 1982, 1715.6964, 463.1404, 99, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (38, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Trouble Man', N'Realblab', N'Southern Company (The)', 3, 1, 1984, 4635.7038, 1124.4001, 31, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (39, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Gardenia', N'Jatri', N'Everbridge, Inc.', 2, 10, 2004, 5000.4291, 283.2211, 45, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (40, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Wish You Were Here', N'Photojam', N'NRG Yield, Inc.', 8, 8, 2002, 2822.0105, 818.9268, 72, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (41, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Secret Beyond the Door', N'Fiveclub', N'XG Technology, Inc', 8, 5, 1985, 1306.6458, 1158.6334, 52, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (42, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Macbeth', N'Browsebug', N'Enzymotec Ltd.', 2, 4, 2013, 2551.5312, 283.0807, 94, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (43, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Glimmer Man, The', N'Buzzbean', N'Scana Corporation', 4, 9, 2011, 12627.5856, 368.9670, 34, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (44, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'All Fall Down', N'Agivu', N'Ruby Tuesday, Inc.', 3, 8, 2007, 7536.1834, 561.8559, 56, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (45, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Step Up Revolution', N'Quatz', N'Constellation Brands Inc', 10, 10, 2021, 6869.4543, 447.8140, 68, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (46, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Fred Claus', N'Gabcube', N'National General Holdings Corp', 7, 7, 2022, 6916.9756, 1346.7366, 78, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (47, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Disorder', N'Brainverse', N'NCR Corporation', 4, 7, 2000, 1922.3230, 36.4344, 70, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (48, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Oliver Twist', N'Feedbug', N'Versum Materials, Inc.', 9, 8, 1990, 9004.7774, 558.0263, 19, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (49, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'In Search of a Midnight Kiss', N'Twitterworks', N'Aegon NV', 5, 10, 2003, 9976.1008, 684.0839, 18, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (50, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Transformers: The Movie', N'Yoveo', N'Telefonica SA', 8, 10, 1985, 342.8370, 501.8958, 38, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (51, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Spider''s Stratagem, The (Strategia del ragno)', N'Edgewire', N'Empire State Realty Trust, Inc.', 4, 1, 2012, 14506.3070, 1103.3309, 86, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (52, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Incredibles, The', N'Wordtune', N'PIMCO New York Municipal Income Fund III', 9, 11, 2020, 3197.1999, 581.6107, 17, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (53, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'My Blue Heaven', N'Blognation', N'ProQR Therapeutics N.V.', 7, 1, 1999, 10434.0786, 54.0762, 21, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (54, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Scorched', N'Twimbo', N'Westwood Holdings Group Inc', 3, 5, 2010, 3802.7289, 647.3881, 44, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (55, CAST(N'2022-08-22T23:41:24.563' AS DateTime), N'Darling', N'Skilith', N'Aegon NV', 4, 5, 1987, 4038.2981, 1191.2840, 16, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (56, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Inside (A l''interieur)', N'Kaymbo', N'Clear Channel Outdoor Holdings, Inc.', 1, 1, 2016, 7654.1836, 1438.8126, 93, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (57, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Sue', N'Aivee', N'ADOMANI, Inc.', 10, 8, 2006, 105.1522, 748.1197, 37, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (59, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'OKA!', N'Zoonder', N'Lake Shore Bancorp, Inc.', 10, 10, 2018, 8163.6371, 1267.1138, 25, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (60, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Immortal Sergeant', N'Shuffletag', N'Lifetime Brands, Inc.', 2, 5, 1999, 6435.6440, 1184.1544, 65, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (61, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Ex-Girlfriends', N'Mycat', N'Philip Morris International Inc', 8, 7, 2010, 7626.9858, 1274.3552, 10, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (62, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Fever', N'Wikizz', N'Fidelity National Financial, Inc.', 6, 5, 2013, 3815.8885, 1078.7483, 15, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (63, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Carousel', N'Jayo', N'Mirati Therapeutics, Inc.', 8, 4, 1989, 10826.0991, 586.4141, 59, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (64, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Naughty Room, The', N'Wordware', N'TransUnion', 3, 4, 2014, 1208.3550, 669.9686, 36, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (66, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Toronto Stories', N'Kwinu', N'ING Group, N.V.', 5, 7, 2006, 10668.2868, 1389.6157, 62, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (67, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Burning Palms', N'Blognation', N'Bellicum Pharmaceuticals, Inc.', 5, 10, 1986, 2504.3520, 144.0138, 55, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (68, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Leviathan', N'Geba', N'Prana Biotechnology Ltd', 2, 8, 2014, 875.4542, 846.1862, 33, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (69, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Brick Lane', N'Dablist', N'Mastercard Incorporated', 2, 7, 2007, 8624.8962, 19.9597, 50, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (70, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Dominion: Prequel to the Exorcist', N'Skivee', N'Applied DNA Sciences Inc', 5, 4, 2015, 14464.9336, 491.3119, 1, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (71, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Leontine', N'Wordware', N'Northrim BanCorp Inc', 2, 7, 1981, 6917.9066, 221.8884, 18, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (72, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Under the Domim Tree (Etz Hadomim Tafus)', N'Twimbo', N'PS Business Parks, Inc.', 6, 4, 1986, 2194.6464, 996.8821, 48, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (73, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Gray''s Anatomy', N'Mymm', N'Maxim Integrated Products, Inc.', 2, 9, 2019, 3773.5516, 675.4591, 70, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (74, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Devil in a Blue Dress', N'Yotz', N'Geo Group Inc (The)', 6, 7, 2010, 3155.7016, 159.8673, 92, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (75, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Cose da pazzi', N'JumpXS', N'CBS Corporation', 8, 9, 2006, 4612.6990, 1228.9161, 28, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (76, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Supermen of Malegaon', N'Devbug', N'Petroquest Energy Inc', 6, 5, 2007, 3547.0349, 263.3437, 96, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (77, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Hey, Happy!', N'Topicstorm', N'Xenith Bankshares, Inc.', 9, 1, 1990, 11774.3159, 1319.3269, 87, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (78, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Perfect Family, The', N'Babbleopia', N'Helios and Matheson Analytics Inc', 9, 1, 1987, 5880.4086, 921.3401, 4, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (80, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Boudu Saved From Drowning (Boudu sauve des eaux)', N'Jayo', N'DTE Energy Company', 5, 9, 2007, 1309.0112, 1088.6000, 10, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (81, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Country Bears, The', N'Wikido', N'The ONE Group Hospitality, Inc.', 9, 5, 2008, 2635.6955, 791.5760, 65, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (82, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Top Dog', N'Shufflebeat', N'Voya Financial, Inc.', 5, 1, 1997, 12979.5489, 476.3971, 48, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (83, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Far Off Place, A', N'Quire', N'Wheaton Precious Metals Corp.', 2, 4, 1995, 701.4752, 914.8068, 12, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (84, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Summer School', N'Topicware', N'FinTech Acquisition Corp. II', 7, 5, 2010, 3136.2889, 884.9829, 45, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (85, CAST(N'2022-08-22T23:41:24.567' AS DateTime), N'Murder She Said', N'Kwideo', N'Paycom Software, Inc.', 2, 1, 1980, 11195.7597, 632.6404, 26, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (86, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'Niagara Motel', N'Skalith', N'Anheuser-Busch Inbev SA', 8, 9, 1984, 504.6661, 742.7741, 49, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (87, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'Souper, Le (Supper, The)', N'Mydeo', N'BanColombia S.A.', 2, 4, 2010, 620.5468, 80.3053, 30, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (88, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'Rent-A-Cop', N'Livetube', N'Oxford Lane Capital Corp.', 4, 5, 2010, 7379.3302, 718.0142, 87, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (89, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'The Tree, the Mayor and the Mediatheque', N'Feedbug', N'Donnelley Financial Solutions, Inc.', 5, 7, 1984, 8915.9269, 919.7357, 1, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (90, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'High Time (Big Daddy)', N'Eazzy', N'Stone Harbor Emerging Markets Income Fund', 9, 1, 2018, 10097.8914, 20.7077, 82, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (92, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'Pusher II: With Blood on My Hands', N'Yotz', N'Blackrock Enhanced Government Fund, Inc', 7, 4, 1982, 12232.7053, 468.1193, 75, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (93, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'Under the Same Moon (Misma luna, La)', N'Tazz', N'Momo Inc.', 7, 10, 2008, 3829.5806, 484.8191, 55, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (94, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'Color of Friendship, The', N'Jaxnation', N'Mesoblast Limited', 3, 1, 1987, 9285.4809, 530.0389, 14, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (95, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'Anna: 6-18 (Anna: Ot shesti do vosemnadtsati)', N'Flashset', N'Atento S.A.', 2, 8, 2021, 5224.3060, 1218.5866, 35, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (96, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'Citizen Gangster ', N'Aimbu', N'Houston Wire & Cable Company', 1, 8, 1999, 14062.0941, 172.8432, 12, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (97, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'Bite the Bullet', N'Browseblab', N'Simon Property Group, Inc.', 6, 9, 2006, 4884.8779, 1230.2611, 83, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (98, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'Talking Picture, A (Um Filme Falado)', N'Tekfly', N'Prudential Public Limited Company', 2, 8, 1992, 2373.6929, 1178.0171, 64, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (99, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'Match Point', N'Brainverse', N'China Green Agriculture, Inc.', 9, 1, 2005, 11221.7882, 1228.9520, 33, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (100, CAST(N'2022-08-22T23:41:24.570' AS DateTime), N'State of Things, The (Stand der Dinge, Der)', N'Jabbersphere', N'CVR Refining, LP', 5, 5, 2009, 992.0130, 526.4764, 71, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (101, NULL, N'Logingggg', N'LoginLogin', N'LoginLogin', 4, 9, 1987, 20.0000, 225.0000, 1, NULL)
INSERT [dbo].[Records] ([Id], [DateAdd], [RecordName], [TeamdName], [PublisherName], [CountTracks], [GenreId], [Year], [CostPrice], [SellPrice], [RecordsCount], [Prodano]) VALUES (107, CAST(N'2022-08-24T06:23:37.253' AS DateTime), N'dd', N'ddd', N'd', 4, 7, 4, 4.0000, 4.0000, 4, NULL)
SET IDENTITY_INSERT [dbo].[Records] OFF
GO
SET IDENTITY_INSERT [dbo].[Sales] ON 

INSERT [dbo].[Sales] ([Id], [Name], [GenreId], [Discount], [DateBegin], [DateEnd]) VALUES (1, N'Mayer, Gleichner and Kihn', 7, 2, CAST(N'2022-08-22T23:42:32.700' AS DateTime), CAST(N'2022-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Sales] ([Id], [Name], [GenreId], [Discount], [DateBegin], [DateEnd]) VALUES (2, N'Rowe-Marquardt', NULL, 7, CAST(N'2022-08-22T23:42:32.707' AS DateTime), CAST(N'2021-06-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Sales] ([Id], [Name], [GenreId], [Discount], [DateBegin], [DateEnd]) VALUES (3, N'Kerluke Group', 7, 1, CAST(N'2022-08-22T23:42:32.707' AS DateTime), CAST(N'2022-02-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Sales] ([Id], [Name], [GenreId], [Discount], [DateBegin], [DateEnd]) VALUES (4, N'Schmeler, Torphy and Stehr', 4, 6, CAST(N'2022-08-22T23:42:32.707' AS DateTime), CAST(N'2022-01-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Sales] ([Id], [Name], [GenreId], [Discount], [DateBegin], [DateEnd]) VALUES (6, N'Deckow Group', 5, 9, CAST(N'2022-08-22T23:42:32.707' AS DateTime), CAST(N'2022-04-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Sales] ([Id], [Name], [GenreId], [Discount], [DateBegin], [DateEnd]) VALUES (14, N'without', 1, 0, CAST(N'2022-08-22T00:00:00.000' AS DateTime), CAST(N'2023-12-31T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Sales] OFF
GO
SET IDENTITY_INSERT [dbo].[Sellers] ON 

INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (1, N'Garrek', N'Senyard', N'gsenyard0', N'KhtXVME')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (2, N'Trip', N'Vatini', N'tvatini1', N'ST5nB5lOtswM')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (3, N'Zacherie', N'Curwood', N'zcurwood2', N'b5jDfpUS')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (4, N'Barbette', N'Devereux', N'bdevereux3', N'tIMQZgNyhK')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (5, N'Sansone', N'Artus', N'sartus4', N'R7l8r0UgdzBG')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (6, N'Lazarus', N'Feldon', N'lfeldon5', N'U3DOG6')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (7, N'Dorian', N'Everett', N'deverett6', N'v7Z4Sgaic')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (8, N'Sadella', N'Westfalen', N'swestfalen7', N'DLHzHyue')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (9, N'Read', N'Doale', N'rdoale8', N'TTW3M8Ps')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (10, N'Fanechka', N'Hutcheons', N'fhutcheons9', N'LuGdt1Ccl6')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (11, N'ertt', N'123123123', N'123', N'123')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (12, N'Dell', N'Viveash', N'dviveashb', N'YeYQ34rp7eN')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (13, N'Lizabeth', N'Welsby', N'lwelsbyc', N'0IplggK')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (14, N'Cos', N'Filyaev', N'cfilyaevd', N'0BxuFP')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (15, N'Matelda', N'Alan', N'malane', N'saD40FaAHs')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (16, N'Tiffany', N'Langtry', N'tlangtryf', N'7Ugx7yt')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (17, N'Pebrook', N'Smalley', N'psmalleyg', N'EtXJFtguges')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (18, N'Niels', N'Chadbourn', N'nchadbournh', N'tlgQd7iAqTmH')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (19, N'Baudoin', N'Janas', N'bjanasi', N'TIZs44k')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (27, N'', N'', N'', N'')
INSERT [dbo].[Sellers] ([Id], [FirstName], [LastName], [Login], [Password]) VALUES (28, N'ddd', N'dd', N'd', N'd')
SET IDENTITY_INSERT [dbo].[Sellers] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Customer__5C7E359EF4987124]    Script Date: 24.08.2022 6:42:26 ******/
ALTER TABLE [dbo].[Customers] ADD UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Genres__BBE1C33938427652]    Script Date: 24.08.2022 6:42:26 ******/
ALTER TABLE [dbo].[Genres] ADD UNIQUE NONCLUSTERED 
(
	[GenreName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Sellers__5E55825B7AA85B34]    Script Date: 24.08.2022 6:42:26 ******/
ALTER TABLE [dbo].[Sellers] ADD UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ((1)) FOR [ProductCount]
GO
ALTER TABLE [dbo].[Records] ADD  DEFAULT (getdate()) FOR [DateAdd]
GO
ALTER TABLE [dbo].[Records] ADD  DEFAULT ((1)) FOR [RecordsCount]
GO
ALTER TABLE [dbo].[Sales] ADD  DEFAULT (getdate()) FOR [DateBegin]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([RecordId])
REFERENCES [dbo].[Records] ([Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([SaleId])
REFERENCES [dbo].[Sales] ([Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([SellerId])
REFERENCES [dbo].[Sellers] ([Id])
GO
ALTER TABLE [dbo].[Records]  WITH CHECK ADD FOREIGN KEY([GenreId])
REFERENCES [dbo].[Genres] ([Id])
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD FOREIGN KEY([GenreId])
REFERENCES [dbo].[Genres] ([Id])
GO
USE [master]
GO
ALTER DATABASE [db_music] SET  READ_WRITE 
GO
