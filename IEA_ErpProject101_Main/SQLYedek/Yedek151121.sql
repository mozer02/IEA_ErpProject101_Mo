USE [master]
GO
/****** Object:  Database [ErpProjectWMP]    Script Date: 15.11.2021 11:23:20 ******/
CREATE DATABASE [ErpProjectWMP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ErpProjectWMP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ErpProjectWMP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ErpProjectWMP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ErpProjectWMP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ErpProjectWMP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ErpProjectWMP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET ARITHABORT OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ErpProjectWMP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ErpProjectWMP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ErpProjectWMP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ErpProjectWMP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET RECOVERY FULL 
GO
ALTER DATABASE [ErpProjectWMP] SET  MULTI_USER 
GO
ALTER DATABASE [ErpProjectWMP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ErpProjectWMP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ErpProjectWMP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ErpProjectWMP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ErpProjectWMP] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ErpProjectWMP', N'ON'
GO
USE [ErpProjectWMP]
GO
/****** Object:  Table [dbo].[tblCariGruplari]    Script Date: 15.11.2021 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCariGruplari](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GrupAdi] [nvarchar](50) NULL,
	[isActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCariler]    Script Date: 15.11.2021 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCariler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CariNo] [nvarchar](10) NULL,
	[CariGroupId] [int] NULL,
	[CariTipId] [int] NULL,
	[CariAdi] [nvarchar](100) NULL,
	[CariUnvan] [nvarchar](max) NULL,
	[Adres1] [nvarchar](max) NULL,
	[Adres2] [nvarchar](max) NULL,
	[Vdairesi] [nvarchar](50) NULL,
	[Tc_Vn] [nvarchar](11) NULL,
	[SehirId] [int] NULL,
	[CariTel] [nvarchar](20) NULL,
	[CariMail] [nvarchar](50) NULL,
	[YetkiliAdi1] [nvarchar](50) NULL,
	[YetkiliAdi2] [nvarchar](50) NULL,
	[YetkiliAdi3] [nvarchar](50) NULL,
	[YetkiliDepartmani1] [nvarchar](50) NULL,
	[YetkiliDepartmani2] [nvarchar](50) NULL,
	[YetkiliDepartmani3] [nvarchar](50) NULL,
	[YetkiliTel1] [nvarchar](20) NULL,
	[YetkiliTel2] [nvarchar](20) NULL,
	[YetkiliTel3] [nvarchar](20) NULL,
	[YetkiliCep1] [nvarchar](20) NULL,
	[YetkiliCep2] [nvarchar](20) NULL,
	[YetkiliCep3] [nvarchar](20) NULL,
	[YetkiliMail1] [nvarchar](50) NULL,
	[YetkiliMail2] [nvarchar](50) NULL,
	[YetkiliMail3] [nvarchar](50) NULL,
	[SaveUserId] [int] NULL,
	[UpdateUserId] [int] NULL,
	[SaveDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
	[isActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDepartmanlar]    Script Date: 15.11.2021 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDepartmanlar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GrupId] [int] NULL,
	[DepartmanAdi] [nvarchar](70) NULL,
	[isActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPersonelDetay]    Script Date: 15.11.2021 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPersonelDetay](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CariId] [int] NULL,
	[IsBasiTarih] [datetime] NULL,
	[IsSonuTarih] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSehirler]    Script Date: 15.11.2021 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSehirler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sehir] [nvarchar](255) NULL,
 CONSTRAINT [PK_tblSehirler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUrunler]    Script Date: 15.11.2021 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUrunler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UrunGenelNo] [nvarchar](50) NULL,
	[UrunKodu] [nvarchar](50) NULL,
	[UrunAdi] [nvarchar](50) NULL,
	[UrunAciklama] [nvarchar](max) NULL,
	[KutuIcerik] [nvarchar](max) NULL,
	[TedarikciFirmaId] [int] NULL,
	[AlisFiyat] [decimal](11, 2) NULL,
	[SatisFiyat] [decimal](11, 2) NULL,
	[SaveDate] [datetime] NULL,
	[SaveUserId] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateUserId] [int] NULL,
	[isActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblCariGruplari] ON 

INSERT [dbo].[tblCariGruplari] ([Id], [GrupAdi], [isActive]) VALUES (1, N'Hastane', 1)
INSERT [dbo].[tblCariGruplari] ([Id], [GrupAdi], [isActive]) VALUES (2, N'Doktor', 1)
INSERT [dbo].[tblCariGruplari] ([Id], [GrupAdi], [isActive]) VALUES (3, N'Firma', 1)
INSERT [dbo].[tblCariGruplari] ([Id], [GrupAdi], [isActive]) VALUES (5, N'Müşteri', 1)
INSERT [dbo].[tblCariGruplari] ([Id], [GrupAdi], [isActive]) VALUES (6, N'Personel', 1)
SET IDENTITY_INSERT [dbo].[tblCariGruplari] OFF
GO
SET IDENTITY_INSERT [dbo].[tblCariler] ON 

INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (1, N'H00000001', 1, 1, N'Acimadem', N'Acimadem A.S', N'dfsdfsd', N'sdfcsxvxcv', N'sdfsdf', N'11111111111', 6, N'(111) 111-1111', N'info@acimadem.com', N'sdfdsf', N'werwer', N'xcvxc', N'Muhasebe', N'Muhasebe', N'Depo', N'(111) 111-1111', N'(   ) 444-4444', N'(333) 333-3333', N'(444) 444-4444', N'(111) 111-1111', N'(666) 666-6666', N'fff', N'ddd', N'ggg', 1, 1, CAST(N'2021-11-10T11:12:21.723' AS DateTime), CAST(N'2021-11-11T11:38:40.483' AS DateTime), 1)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (2, N'H00000002', 1, 1, N'sdfsdf', N'sdfsdf', N'fsdfdsfsd', N'', N'sdfsdfsd', N'22222222222', 14, N'(111) 111-1111', N'wddfsdfsd', N'', N'', N'', N'', N'', N'', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'', N'', N'', 1, NULL, CAST(N'2021-11-10T13:04:04.453' AS DateTime), NULL, 1)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (3, N'H00000003', 1, 1, N'sdfsdfsdfsdf', N'sdfsdfsdf', N'', N'19', N'', N'', 19, N'(   )    -', N'', N'', N'', N'', N'', N'', N'', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'', N'', N'', 1, NULL, CAST(N'2021-11-10T13:22:51.230' AS DateTime), NULL, 0)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (4, N'H00000004', 1, 1, N'Acimadem', N'Acimadem A.S', N'dfsdfsd', N'sdfcsxvxcv', N'sdfsdf', N'11111111111', 6, N'(111) 111-1111', N'info@acimadem.com', N'sdfdsf', N'werwer', N'xcvxc', N'Muhasebe', N'Muhasebe', N'Depo', N'(111) 111-1111', N'(222) 222-2222', N'(333) 333-3333', N'(444) 444-4444', N'(666) 666-6666', N'(666) 666-6666', N'fff', N'ddd', N'ggg', 1, NULL, CAST(N'2021-11-11T11:33:03.973' AS DateTime), NULL, 1)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (5, N'D00000005', 2, 1, N'Omer Taser', N'Prof_Dr', N'Maslak Acibadem', N'Maslak Giz Plaza', N'ddddd', N'99999999999', 40, N'(333) 333-3333', N'ertgfdd', NULL, NULL, NULL, N'Ortopedi', NULL, NULL, NULL, NULL, NULL, N'(222) 222-2222', NULL, NULL, NULL, NULL, NULL, 1, 1, CAST(N'2021-11-11T13:44:18.520' AS DateTime), CAST(N'2021-11-11T13:58:59.673' AS DateTime), 1)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (6, N'D00000006', 2, 1, N'Ufuk CandanQ', N'Doc_Dr', N'ldfklsdfjlskQ', N'lkdsjflkdfjQ', N'kgjdklfgjQ', N'33333333334', 63, N'(111) 111-1112', N'ksldflskdfQ', NULL, NULL, NULL, N'Cocuk Hastaliklari', NULL, NULL, NULL, NULL, NULL, N'(222) 222-2223', NULL, NULL, NULL, NULL, NULL, 1, 1, CAST(N'2021-11-11T14:00:21.207' AS DateTime), CAST(N'2021-11-11T14:42:16.163' AS DateTime), 1)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (7, N'D00000007', 2, 1, N'dfgdfg', N'Uzm_Dr', N'fff', N'ggg', N'dfgdfg', N'11111111111', 28, N'(444) 444-4444', N'fdgdfg', NULL, NULL, NULL, N'Kadin Dogum', NULL, NULL, NULL, NULL, NULL, N'(333) 333-3333', NULL, NULL, NULL, NULL, NULL, 1, NULL, CAST(N'2021-11-11T14:00:47.493' AS DateTime), NULL, 0)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (8, N'P00000001', 6, 1, N'Onur Agici', N'Sube_Muduru', N'dfsdfsdf', N'sdfsdfsd', NULL, N'23232323232', 25, N'(333) 333-3333', N'asdasd', NULL, NULL, NULL, N'Bilgi Islem', NULL, NULL, NULL, NULL, NULL, N'(222) 222-2222', NULL, NULL, NULL, NULL, NULL, 1, 1, CAST(N'2021-11-12T09:59:45.603' AS DateTime), CAST(N'2021-11-12T11:53:03.767' AS DateTime), 1)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (10, N'D00000008', 2, 1, N'jhgjhgjhghj', N'Prof_Dr', N'', N'', N'', N'', NULL, N'(   )    -', N'', NULL, NULL, NULL, N'', NULL, NULL, NULL, NULL, NULL, N'(   )    -', NULL, NULL, NULL, NULL, NULL, 1, NULL, CAST(N'2021-11-12T11:10:12.940' AS DateTime), NULL, 1)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (1008, N'P00000009', 6, 1, N'deneme1', N'Muhendis', N'deneme', N'deneme', NULL, N'11111111111', 1, N'(555) 555-5555', N'deneme', NULL, NULL, NULL, N'Satin Alma', NULL, NULL, NULL, NULL, NULL, N'(444) 444-4444', NULL, NULL, NULL, NULL, NULL, 1, 1, CAST(N'2021-11-12T11:56:04.837' AS DateTime), CAST(N'2021-11-12T11:56:32.753' AS DateTime), 1)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (1019, N'F00001009', 3, 1, N'A-Firmasi', N'Distributor', N'sdsd', N'sdsd', N'sdfsdf', N'12121212121', 5, N'(111) 111-1111', N'dsdfsdfsdf', N'sadasd', N'', N'', N'Satinalma', N'', N'', N'(444) 444-4444', N'(   )    -', N'(   )    -', N'(444) 444-4444', N'(   )    -', N'(   )    -', N'sdfsdfsdf', N'', N'', 1, 1, CAST(N'2021-11-12T14:17:55.703' AS DateTime), CAST(N'2021-11-15T10:31:50.707' AS DateTime), 1)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (1020, N'F00001020', 3, 1, N'B-Firmasi', N'Distributor', N'', N'', N'', N'', 5, N'(   )    -', N'', N'', N'', N'', N'', N'', N'', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'', N'', N'', 1, 1, CAST(N'2021-11-12T14:19:03.013' AS DateTime), CAST(N'2021-11-15T10:32:01.360' AS DateTime), 1)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (1021, N'F00001021', 3, 1, N'C-Firmasi', N'Distributor', N'', N'', N'', N'', 5, N'(   )    -', N'', N'', N'', N'', N'', N'', N'', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'', N'', N'', 1, 1, CAST(N'2021-11-12T14:22:42.117' AS DateTime), CAST(N'2021-11-15T10:32:23.067' AS DateTime), 1)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (1022, N'F00001022', 3, 1, N'D-Firmasi', N'Distributor', N'', N'', N'', N'', 5, N'(   )    -', N'', N'', N'', N'', N'', N'', N'', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'', N'', N'', 1, 1, CAST(N'2021-11-12T14:37:57.923' AS DateTime), CAST(N'2021-11-15T10:32:32.423' AS DateTime), 1)
INSERT [dbo].[tblCariler] ([Id], [CariNo], [CariGroupId], [CariTipId], [CariAdi], [CariUnvan], [Adres1], [Adres2], [Vdairesi], [Tc_Vn], [SehirId], [CariTel], [CariMail], [YetkiliAdi1], [YetkiliAdi2], [YetkiliAdi3], [YetkiliDepartmani1], [YetkiliDepartmani2], [YetkiliDepartmani3], [YetkiliTel1], [YetkiliTel2], [YetkiliTel3], [YetkiliCep1], [YetkiliCep2], [YetkiliCep3], [YetkiliMail1], [YetkiliMail2], [YetkiliMail3], [SaveUserId], [UpdateUserId], [SaveDate], [UpdateDate], [isActive]) VALUES (1023, N'F00001023', 3, 7, N'VergiDairesi', N'Resmi', N'sdfsdf', N'sdfsdf', N'1111111', N'11111111111', 5, N'(111) 111-1111', N'sdfsdf', N'', N'', N'', N'', N'', N'', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'(   )    -', N'', N'', N'', 1, 1, CAST(N'2021-11-15T10:20:40.527' AS DateTime), CAST(N'2021-11-15T10:24:34.487' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[tblCariler] OFF
GO
SET IDENTITY_INSERT [dbo].[tblDepartmanlar] ON 

INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (1, 1, N'Satin Alma', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (2, 1, N'Muhasebe', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (3, 1, N'Ortopedi Servisi', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (4, 1, N'Poliklinik', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (5, 1, N'Depo', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (6, 1, N'Bilgi İşlem', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (7, 2, N'Ortopedi', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (8, 2, N'Cocuk Hastaliklari', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (9, 2, N'Acil', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (10, 2, N'Uroloji', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (11, 2, N'Kadin Dogum', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (12, 2, N'Noroloji', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (13, 2, N'Kbb', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (14, 2, N'Gene Cerrahi', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (15, 2, N'Kalp Damar', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (16, 2, N'Cildiye', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (17, 2, N'Dahiliye', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (18, 2, N'Goz', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (19, 2, N'Dis ve Cene Cerrahisi', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (20, 2, N'Ortodonti', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (21, 6, N'Satin Alma', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (22, 6, N'Muhasebe', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (23, 6, N'Satis Pazarlama', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (24, 6, N'Insan Kaynaklari', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (25, 6, N'Bilgi Islem', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (26, 6, N'Ameliyat Ekibi', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (27, 6, N'Evrak', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (28, 6, N'Depo', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (29, 6, N'Sevkiyat', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (30, 6, N'Guvenlik', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (31, 6, N'Finans', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (1007, 3, N'Genel Mudur', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (1008, 3, N'Satinalma', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (1009, 3, N'Finans', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (1010, 3, N'Depo', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (1011, 3, N'Lojistik', 1)
INSERT [dbo].[tblDepartmanlar] ([Id], [GrupId], [DepartmanAdi], [isActive]) VALUES (1012, 3, N'Satis Pazarlama', 1)
SET IDENTITY_INSERT [dbo].[tblDepartmanlar] OFF
GO
SET IDENTITY_INSERT [dbo].[tblPersonelDetay] ON 

INSERT [dbo].[tblPersonelDetay] ([Id], [CariId], [IsBasiTarih], [IsSonuTarih]) VALUES (1, 8, CAST(N'2010-11-12T09:58:38.000' AS DateTime), CAST(N'2021-11-08T09:58:38.000' AS DateTime))
INSERT [dbo].[tblPersonelDetay] ([Id], [CariId], [IsBasiTarih], [IsSonuTarih]) VALUES (2, 1008, CAST(N'2021-11-01T11:55:32.000' AS DateTime), CAST(N'2021-11-08T11:56:23.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tblPersonelDetay] OFF
GO
SET IDENTITY_INSERT [dbo].[tblSehirler] ON 

INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (1, N'ADANA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (2, N'ADIYAMAN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (3, N'AFYON')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (4, N'AĞRI')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (5, N'AMASYA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (6, N'ANKARA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (7, N'ANTALYA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (8, N'ARTVİN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (9, N'AYDIN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (10, N'BALIKESİR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (11, N'BİLECİK')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (12, N'BİNGÖL')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (13, N'BİTLİS')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (14, N'BOLU')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (15, N'BURDUR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (16, N'BURSA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (17, N'ÇANAKKALE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (18, N'ÇANKIRI')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (19, N'ÇORUM')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (20, N'DENİZLİ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (21, N'DİYARBAKIR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (22, N'EDİRNE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (23, N'ELAZIĞ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (24, N'ERZİNCAN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (25, N'ERZURUM')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (26, N'ESKİŞEHİR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (27, N'GAZİANTEP')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (28, N'GİRESUN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (29, N'GÜMÜŞHANE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (30, N'HAKKARİ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (31, N'HATAY')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (32, N'ISPARTA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (33, N'İÇEL')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (34, N'İSTANBUL')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (35, N'İZMİR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (36, N'KARS')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (37, N'KASTAMONU')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (38, N'KAYSERİ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (39, N'KIRKLARELİ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (40, N'KIRŞEHİR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (41, N'KOCAELİ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (42, N'KONYA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (43, N'KÜTAHYA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (44, N'MALATYA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (45, N'MANİSA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (46, N'KAHRAMANMARAŞ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (47, N'MARDİN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (48, N'MUĞLA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (49, N'MUŞ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (50, N'NEVŞEHİR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (51, N'NİĞDE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (52, N'ORDU')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (53, N'RİZE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (54, N'SAKARYA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (55, N'SAMSUN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (56, N'SİİRT')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (57, N'SİNOP')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (58, N'SİVAS')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (59, N'TEKİRDAĞ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (60, N'TOKAT')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (61, N'TRABZON')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (62, N'TUNCELİ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (63, N'ŞANLIURFA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (64, N'UŞAK')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (65, N'VAN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (66, N'YOZGAT')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (67, N'ZONGULDAK')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (68, N'AKSARAY')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (69, N'BAYBURT')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (70, N'KARAMAN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (71, N'KIRIKKALE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (72, N'BATMAN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (73, N'ŞIRNAK')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (74, N'BARTIN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (75, N'ARDAHAN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (76, N'IĞDIR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (77, N'YALOVA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (78, N'KARABÜK')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (79, N'KİLİS')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (80, N'OSMANİYE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (81, N'DÜZCE')
SET IDENTITY_INSERT [dbo].[tblSehirler] OFF
GO
ALTER TABLE [dbo].[tblCariler]  WITH CHECK ADD  CONSTRAINT [FK_tblCariler_tblCariGruplari] FOREIGN KEY([CariGroupId])
REFERENCES [dbo].[tblCariGruplari] ([Id])
GO
ALTER TABLE [dbo].[tblCariler] CHECK CONSTRAINT [FK_tblCariler_tblCariGruplari]
GO
ALTER TABLE [dbo].[tblCariler]  WITH CHECK ADD  CONSTRAINT [FK_tblCariler_tblSehirler] FOREIGN KEY([SehirId])
REFERENCES [dbo].[tblSehirler] ([id])
GO
ALTER TABLE [dbo].[tblCariler] CHECK CONSTRAINT [FK_tblCariler_tblSehirler]
GO
ALTER TABLE [dbo].[tblDepartmanlar]  WITH CHECK ADD  CONSTRAINT [FK_tblDepartmanlar_tblCariGruplari] FOREIGN KEY([GrupId])
REFERENCES [dbo].[tblCariGruplari] ([Id])
GO
ALTER TABLE [dbo].[tblDepartmanlar] CHECK CONSTRAINT [FK_tblDepartmanlar_tblCariGruplari]
GO
ALTER TABLE [dbo].[tblPersonelDetay]  WITH CHECK ADD  CONSTRAINT [FK_tblPersonelDetay_tblCariler] FOREIGN KEY([CariId])
REFERENCES [dbo].[tblCariler] ([Id])
GO
ALTER TABLE [dbo].[tblPersonelDetay] CHECK CONSTRAINT [FK_tblPersonelDetay_tblCariler]
GO
ALTER TABLE [dbo].[tblUrunler]  WITH CHECK ADD  CONSTRAINT [FK_tblUrunler_tblCariler] FOREIGN KEY([TedarikciFirmaId])
REFERENCES [dbo].[tblCariler] ([Id])
GO
ALTER TABLE [dbo].[tblUrunler] CHECK CONSTRAINT [FK_tblUrunler_tblCariler]
GO
USE [master]
GO
ALTER DATABASE [ErpProjectWMP] SET  READ_WRITE 
GO
