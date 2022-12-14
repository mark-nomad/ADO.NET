USE [master]
GO
/****** Object:  Database [bd_Countries]    Script Date: 05.08.2022 3:08:03 ******/
CREATE DATABASE [bd_Countries]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Countries', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Countries.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Countries_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Countries_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bd_Countries] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bd_Countries].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bd_Countries] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bd_Countries] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bd_Countries] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bd_Countries] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bd_Countries] SET ARITHABORT OFF 
GO
ALTER DATABASE [bd_Countries] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bd_Countries] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bd_Countries] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bd_Countries] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bd_Countries] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bd_Countries] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bd_Countries] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bd_Countries] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bd_Countries] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bd_Countries] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bd_Countries] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bd_Countries] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bd_Countries] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bd_Countries] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bd_Countries] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bd_Countries] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bd_Countries] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bd_Countries] SET RECOVERY FULL 
GO
ALTER DATABASE [bd_Countries] SET  MULTI_USER 
GO
ALTER DATABASE [bd_Countries] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bd_Countries] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bd_Countries] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bd_Countries] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bd_Countries] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bd_Countries] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'bd_Countries', N'ON'
GO
ALTER DATABASE [bd_Countries] SET QUERY_STORE = OFF
GO
USE [bd_Countries]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 05.08.2022 3:08:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[Capital] [nvarchar](50) NOT NULL,
	[Population] [int] NULL,
	[Area] [int] NULL,
	[Continents] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (1, N'Indonesia', N'Picungbera', 354236, 193663, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (2, N'Russia', N'Ust’-Kalmanka', 112031, 6690, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (3, N'Ireland', N'Dunmanway', 449824, 150374, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (4, N'Lithuania', N'Obeliai', 299304, 315462, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (5, N'Mexico', N'Emiliano Zapata', 512873, 384211, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (6, N'Japan', N'Muko', 571846, 33773, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (7, N'Portugal', N'Casais de Revelhos', 420465, 20216, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (8, N'China', N'Changshan', 87672, 39798, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (9, N'China', N'Shaxi', 228423, 284261, N'North America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (10, N'United States', N'Saint Petersburg', 251784, 88372, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (11, N'Bosnia and Herzegovina', N'Ljubuski', 126466, 125927, N'North America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (12, N'Czech Republic', N'Vetrni', 264589, 331863, N'North America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (13, N'Mozambique', N'Manhica', 59000, 564224, N'Australia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (14, N'Dominican Republic', N'Laguna Salada', 74313, 248394, N'Australia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (15, N'Yemen', N'Al ‘Ashshah', 318852, 220822, N'South America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (16, N'Armenia', N'Tsaghkadzor', 539746, 327666, N'North America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (17, N'Latvia', N'Salacgriva', 96452, 9929, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (18, N'Micronesia', N'Faraulep', 101971, 348955, N'North America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (19, N'Peru', N'El Carmen', 266391, 394817, N'North America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (20, N'Tunisia', N'Douz', 90535, 444175, N'North America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (21, N'Slovenia', N'Lenart v Slov. Goricah', 421532, 339513, N'Antarctica')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (22, N'Sweden', N'Kristinehamn', 436260, 219551, N'North America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (23, N'Brazil', N'Araxa', 424410, 417473, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (24, N'China', N'Fumin', 394604, 97211, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (25, N'Yemen', N'Al Ghayl', 266931, 287328, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (26, N'China', N'Xiayunling', 397234, 331801, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (27, N'Russia', N'Ust’-Kut', 127404, 447373, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (28, N'Sweden', N'Bollnas', 58873, 277955, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (29, N'Russia', N'Kortkeros', 50908, 9866, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (30, N'Sweden', N'Flen', 94628, 531712, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (31, N'Armenia', N'Gavarr', 44024, 329081, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (32, N'Portugal', N'Lamoso', 335982, 32616, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (33, N'Colombia', N'Funza', 466823, 292837, N'Australia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (34, N'Greece', N'Drosato', 385359, 548800, N'Australia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (35, N'Mexico', N'San Agustin', 520404, 442608, N'Australia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (36, N'China', N'Zhetang', 137652, 242967, N'Australia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (37, N'Nigeria', N'Igbor', 233215, 106978, N'North America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (38, N'Portugal', N'Couto', 380645, 270784, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (39, N'United States', N'Houston', 472991, 457401, N'North America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (40, N'Poland', N'Cisiec', 524317, 209793, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (41, N'United States', N'Buffalo', 232700, 572765, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (42, N'Afghanistan', N'Markaz-e Woluswali-ye Achin', 36414, 524861, N'North America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (43, N'Democratic Republic of the Congo', N'Kalemie', 30767, 362205, N'North America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (44, N'Canada', N'Blainville', 39866, 355822, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (45, N'China', N'Shengping', 139358, 184821, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (46, N'Japan', N'Oyabe', 300820, 61815, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (47, N'Central African Republic', N'Carnot', 357858, 23556, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (48, N'Japan', N'Namioka', 149194, 467513, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (49, N'Sweden', N'Stockholm', 171121, 400260, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (50, N'Philippines', N'Balindong', 186491, 263152, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (51, N'Poland', N'Belsk Duzy', 419683, 69078, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (52, N'United Kingdom', N'Preston', 70676, 519318, N'Europe')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (53, N'Philippines', N'Talisay', 238008, 20308, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (54, N'Mongolia', N'Altay sumu', 599121, 331352, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (55, N'Macedonia', N'Bedinje', 255098, 98491, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (56, N'Indonesia', N'Siderejo', 394689, 226637, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (57, N'Ethiopia', N'Metahara', 295734, 51588, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (58, N'China', N'Xianghe', 246675, 524047, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (59, N'China', N'Shengli', 364935, 550027, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (60, N'Argentina', N'Tres Arroyos', 536272, 473595, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (61, N'Indonesia', N'Karangnongko', 40888, 180843, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (62, N'Sweden', N'Tungelsta', 563457, 43701, N'Asia')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (63, N'China', N'Baisangguan', 202824, 598269, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (64, N'Macedonia', N'Сарај', 225540, 51789, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (65, N'Indonesia', N'Pule', 4542, 96500, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (66, N'France', N'Orleans', 388681, 566242, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (67, N'Pakistan', N'Pasrur', 83707, 413361, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (68, N'Russia', N'Krasnogvardeyets', 365465, 234197, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (69, N'Paraguay', N'Villa Florida', 128573, 486877, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (70, N'Russia', N'Mindyak', 336049, 507727, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (71, N'Russia', N'Murom', 119512, 419555, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (72, N'Libya', N'Gialo', 340998, 133729, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (73, N'Portugal', N'A dos Negros', 530262, 294988, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (74, N'Mexico', N'Manlio Fabio Altamirano', 39064, 8358, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (75, N'China', N'Qiaoshi', 201510, 336890, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (76, N'Zambia', N'Chibombo', 340160, 105844, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (77, N'China', N'Shiniu', 365912, 296930, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (78, N'China', N'Meilong', 62491, 375968, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (79, N'Philippines', N'Subic', 463130, 236880, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (80, N'France', N'Sens', 21082, 351607, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (81, N'China', N'Hanyuan', 312608, 8917, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (82, N'Russia', N'Sysert’', 382234, 590160, N'Antarctica')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (83, N'China', N'Qiligang', 272005, 159941, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (84, N'United States', N'Provo', 292078, 141229, N'Antarctica')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (85, N'Portugal', N'Lagoa de Albufeira', 528379, 410750, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (86, N'United States', N'Milwaukee', 206094, 88006, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (87, N'Sudan', N'Wagar', 343740, 6619, N'South America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (88, N'Poland', N'Paprotnia', 589440, 40199, N'South America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (89, N'China', N'Xiahong', 268192, 142547, N'South America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (90, N'China', N'Hanjia', 3631, 271320, N'South America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (91, N'Norway', N'Kristiansund N', 333831, 373749, N'South America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (92, N'Indonesia', N'Sedayu', 56790, 138648, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (93, N'China', N'Changtan', 417865, 390961, N'Antarctica')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (94, N'Sweden', N'Jokkmokk', 592344, 177165, N'Antarctica')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (95, N'Philippines', N'San Andres', 515561, 420287, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (96, N'China', N'Erjia', 400135, 461860, N'South America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (97, N'China', N'Sanqiao', 591649, 541361, N'South America')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (98, N'Norway', N'Oslo', 434343, 302045, N'Africa')
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (99, N'Czech Republic', N'Plavy', 84413, 183093, N'South America')
GO
INSERT [dbo].[Countries] ([Id], [Country], [Capital], [Population], [Area], [Continents]) VALUES (100, N'China', N'Hengdong Chengguanzhen', 457095, 258498, N'South America')
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
USE [master]
GO
ALTER DATABASE [bd_Countries] SET  READ_WRITE 
GO
