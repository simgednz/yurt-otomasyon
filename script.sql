USE [master]
GO
/****** Object:  Database [194603017]    Script Date: 25.01.2021 16:13:59 ******/
CREATE DATABASE [194603017]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'194603017', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\194603017.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'194603017_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\194603017_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [194603017] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [194603017].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [194603017] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [194603017] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [194603017] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [194603017] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [194603017] SET ARITHABORT OFF 
GO
ALTER DATABASE [194603017] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [194603017] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [194603017] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [194603017] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [194603017] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [194603017] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [194603017] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [194603017] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [194603017] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [194603017] SET  DISABLE_BROKER 
GO
ALTER DATABASE [194603017] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [194603017] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [194603017] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [194603017] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [194603017] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [194603017] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [194603017] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [194603017] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [194603017] SET  MULTI_USER 
GO
ALTER DATABASE [194603017] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [194603017] SET DB_CHAINING OFF 
GO
ALTER DATABASE [194603017] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [194603017] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [194603017] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [194603017] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [194603017] SET QUERY_STORE = OFF
GO
USE [194603017]
GO
/****** Object:  Table [dbo].[bolumler]    Script Date: 25.01.2021 16:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bolumler](
	[bolum_ıd] [int] IDENTITY(1,1) NOT NULL,
	[bolum_adı] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gıderler]    Script Date: 25.01.2021 16:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gıderler](
	[odeme_ıd] [smallint] IDENTITY(1,1) NOT NULL,
	[elektırık] [int] NOT NULL,
	[dogalgaz] [int] NOT NULL,
	[su] [int] NOT NULL,
	[mutfak] [int] NOT NULL,
	[temızlık] [int] NOT NULL,
	[personel] [int] NOT NULL,
	[tadılat] [int] NOT NULL,
	[dıger_odemeler] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[odalarr]    Script Date: 25.01.2021 16:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[odalarr](
	[oda_ıd] [tinyint] IDENTITY(1,1) NOT NULL,
	[oda_no] [char](3) NOT NULL,
	[oda_kapasıte] [char](1) NOT NULL,
	[oda_aktıf] [char](1) NOT NULL,
	[oda_durum] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[odemeler]    Script Date: 25.01.2021 16:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[odemeler](
	[ogrencı_ıd] [int] NOT NULL,
	[ogrencı_adı] [varchar](50) NOT NULL,
	[ogrencı_soyadı] [varchar](50) NOT NULL,
	[ogrencı_borc] [smallint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogrencı]    Script Date: 25.01.2021 16:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrencı](
	[ogrencı_ıd] [int] IDENTITY(1,1) NOT NULL,
	[ogrencı_adı] [varchar](50) NOT NULL,
	[ogrencı_soyadı] [varchar](50) NOT NULL,
	[ogrencı_tc] [bigint] NOT NULL,
	[ogrencı_odano] [char](3) NOT NULL,
	[ogrencı_tel] [varchar](20) NOT NULL,
	[ogrencı_bolum] [varchar](50) NOT NULL,
	[ogrencı_sınıf] [int] NOT NULL,
	[ogrencı_aıletel] [varchar](20) NOT NULL,
	[ogrencı_aıleadı] [varchar](50) NOT NULL,
	[ogr_aıleadres] [varchar](50) NULL,
 CONSTRAINT [PK_ogrencı] PRIMARY KEY CLUSTERED 
(
	[ogrencı_ıd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personeller]    Script Date: 25.01.2021 16:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personeller](
	[personel_ıd] [int] IDENTITY(1,1) NOT NULL,
	[personel_Ad] [varchar](50) NOT NULL,
	[personel_soyadı] [varchar](50) NOT NULL,
	[personel_tel] [varchar](50) NOT NULL,
	[personel_departman] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sınıflarr]    Script Date: 25.01.2021 16:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sınıflarr](
	[sınıflar] [varchar](5) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[bolumler] ON 

INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (1, N'yönetım bılısım s')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (2, N'elektırık elektronık')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (3, N'bılgısayar  muhendıslıgı')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (21, N'cxz')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (5, N'matematık ogretmenı')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (6, N'mekatronık muhendısı')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (8, N'işletme')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (9, N'edebıyat')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (10, N'tarıh')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (11, N'sosyolojı')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (12, N'tıp')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (13, N'dıs hekımlıgı')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (14, N'veterınerlık')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (15, N'hemsıre')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (16, N'hukuk ')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (17, N'psıkolojı')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (18, N'cografya')
INSERT [dbo].[bolumler] ([bolum_ıd], [bolum_adı]) VALUES (19, N'muhasebe')
SET IDENTITY_INSERT [dbo].[bolumler] OFF
GO
SET IDENTITY_INSERT [dbo].[gıderler] ON 

INSERT [dbo].[gıderler] ([odeme_ıd], [elektırık], [dogalgaz], [su], [mutfak], [temızlık], [personel], [tadılat], [dıger_odemeler]) VALUES (1, 100, 50, 150, 500, 1000, 5000, 150, 600)
INSERT [dbo].[gıderler] ([odeme_ıd], [elektırık], [dogalgaz], [su], [mutfak], [temızlık], [personel], [tadılat], [dıger_odemeler]) VALUES (2, 100, 50, 150, 500, 1000, 5000, 150, 600)
INSERT [dbo].[gıderler] ([odeme_ıd], [elektırık], [dogalgaz], [su], [mutfak], [temızlık], [personel], [tadılat], [dıger_odemeler]) VALUES (3, 100, 50, 150, 500, 1000, 5000, 150, 600)
SET IDENTITY_INSERT [dbo].[gıderler] OFF
GO
SET IDENTITY_INSERT [dbo].[odalarr] ON 

INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (2, N'101', N'1', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (3, N'102', N'1', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (4, N'103', N'1', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (5, N'104', N'1', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (6, N'105', N'1', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (7, N'201', N'2', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (8, N'202', N'2', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (9, N'203', N'2', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (10, N'204', N'2', N'2', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (11, N'205', N'2', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (12, N'206', N'2', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (13, N'301', N'3', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (14, N'302', N'3', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (15, N'303', N'3', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (16, N'304', N'3', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (17, N'305', N'3', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (18, N'401', N'4', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (19, N'402', N'4', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (20, N'403', N'4', N'0', 1)
INSERT [dbo].[odalarr] ([oda_ıd], [oda_no], [oda_kapasıte], [oda_aktıf], [oda_durum]) VALUES (21, N'404', N'4', N'0', 1)
SET IDENTITY_INSERT [dbo].[odalarr] OFF
GO
INSERT [dbo].[odemeler] ([ogrencı_ıd], [ogrencı_adı], [ogrencı_soyadı], [ogrencı_borc]) VALUES (1, N'mehmet', N'demir', 5000)
INSERT [dbo].[odemeler] ([ogrencı_ıd], [ogrencı_adı], [ogrencı_soyadı], [ogrencı_borc]) VALUES (2, N'demır', N'simsek', 6000)
GO
SET IDENTITY_INSERT [dbo].[ogrencı] ON 

INSERT [dbo].[ogrencı] ([ogrencı_ıd], [ogrencı_adı], [ogrencı_soyadı], [ogrencı_tc], [ogrencı_odano], [ogrencı_tel], [ogrencı_bolum], [ogrencı_sınıf], [ogrencı_aıletel], [ogrencı_aıleadı], [ogr_aıleadres]) VALUES (2, N'jh', N'gjh', 54, N'402', N'42', N'tarıh', 4, N'254', N'lkj', N'kuj')
INSERT [dbo].[ogrencı] ([ogrencı_ıd], [ogrencı_adı], [ogrencı_soyadı], [ogrencı_tc], [ogrencı_odano], [ogrencı_tel], [ogrencı_bolum], [ogrencı_sınıf], [ogrencı_aıletel], [ogrencı_aıleadı], [ogr_aıleadres]) VALUES (3, N'jh', N'gjh', 54, N'402', N'42', N'tarıh', 4, N'254', N'lkj', N'kuj')
INSERT [dbo].[ogrencı] ([ogrencı_ıd], [ogrencı_adı], [ogrencı_soyadı], [ogrencı_tc], [ogrencı_odano], [ogrencı_tel], [ogrencı_bolum], [ogrencı_sınıf], [ogrencı_aıletel], [ogrencı_aıleadı], [ogr_aıleadres]) VALUES (4, N'jh', N'gjh', 54, N'402', N'42', N'tarıh', 4, N'254', N'lkj', N'kuj')
INSERT [dbo].[ogrencı] ([ogrencı_ıd], [ogrencı_adı], [ogrencı_soyadı], [ogrencı_tc], [ogrencı_odano], [ogrencı_tel], [ogrencı_bolum], [ogrencı_sınıf], [ogrencı_aıletel], [ogrencı_aıleadı], [ogr_aıleadres]) VALUES (5, N'jh', N'gjh', 54, N'402', N'42', N'tarıh', 4, N'254', N'lkj', N'kuj')
INSERT [dbo].[ogrencı] ([ogrencı_ıd], [ogrencı_adı], [ogrencı_soyadı], [ogrencı_tc], [ogrencı_odano], [ogrencı_tel], [ogrencı_bolum], [ogrencı_sınıf], [ogrencı_aıletel], [ogrencı_aıleadı], [ogr_aıleadres]) VALUES (8, N'hyg', N'trf', 542, N'   ', N'', N'', 0, N'', N'', N'')
INSERT [dbo].[ogrencı] ([ogrencı_ıd], [ogrencı_adı], [ogrencı_soyadı], [ogrencı_tc], [ogrencı_odano], [ogrencı_tel], [ogrencı_bolum], [ogrencı_sınıf], [ogrencı_aıletel], [ogrencı_aıleadı], [ogr_aıleadres]) VALUES (9, N'sedef', N'dal', 5465, N'301', N'53454545', N'dıs hekımlıgı', 2, N'012102', N'denız', N'fsdfsd')
SET IDENTITY_INSERT [dbo].[ogrencı] OFF
GO
SET IDENTITY_INSERT [dbo].[personeller] ON 

INSERT [dbo].[personeller] ([personel_ıd], [personel_Ad], [personel_soyadı], [personel_tel], [personel_departman]) VALUES (3, N'fsd', N'dsf', N'012', N'dfsd')
INSERT [dbo].[personeller] ([personel_ıd], [personel_Ad], [personel_soyadı], [personel_tel], [personel_departman]) VALUES (7, N'mehmet', N'gol', N'5454', N'dfds')
SET IDENTITY_INSERT [dbo].[personeller] OFF
GO
INSERT [dbo].[sınıflarr] ([sınıflar]) VALUES (N'0')
INSERT [dbo].[sınıflarr] ([sınıflar]) VALUES (N'1')
INSERT [dbo].[sınıflarr] ([sınıflar]) VALUES (N'2')
INSERT [dbo].[sınıflarr] ([sınıflar]) VALUES (N'3')
INSERT [dbo].[sınıflarr] ([sınıflar]) VALUES (N'4')
GO
ALTER TABLE [dbo].[odalarr] ADD  CONSTRAINT [DF_odalarr_oda_aktıf]  DEFAULT ((0)) FOR [oda_aktıf]
GO
ALTER TABLE [dbo].[odalarr] ADD  CONSTRAINT [DF_odalarr_oda_durum]  DEFAULT ((1)) FOR [oda_durum]
GO
ALTER TABLE [dbo].[odemeler] ADD  CONSTRAINT [DF_odemeler_ogrencı_borc]  DEFAULT ((5000)) FOR [ogrencı_borc]
GO
USE [master]
GO
ALTER DATABASE [194603017] SET  READ_WRITE 
GO
