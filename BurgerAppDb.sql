USE [master]
GO
/****** Object:  Database [BurgerAppDb]    Script Date: 23.05.2024 14:03:42 ******/
CREATE DATABASE [BurgerAppDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BurgerAppDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BurgerAppDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BurgerAppDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BurgerAppDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BurgerAppDb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BurgerAppDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BurgerAppDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BurgerAppDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BurgerAppDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BurgerAppDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BurgerAppDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [BurgerAppDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BurgerAppDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BurgerAppDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BurgerAppDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BurgerAppDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BurgerAppDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BurgerAppDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BurgerAppDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BurgerAppDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BurgerAppDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BurgerAppDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BurgerAppDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BurgerAppDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BurgerAppDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BurgerAppDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BurgerAppDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [BurgerAppDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BurgerAppDb] SET RECOVERY FULL 
GO
ALTER DATABASE [BurgerAppDb] SET  MULTI_USER 
GO
ALTER DATABASE [BurgerAppDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BurgerAppDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BurgerAppDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BurgerAppDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BurgerAppDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BurgerAppDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BurgerAppDb', N'ON'
GO
ALTER DATABASE [BurgerAppDb] SET QUERY_STORE = ON
GO
ALTER DATABASE [BurgerAppDb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BurgerAppDb]
GO
/****** Object:  User [btn]    Script Date: 23.05.2024 14:03:42 ******/
CREATE USER [btn] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 23.05.2024 14:03:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 23.05.2024 14:03:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[AddressLine1] [nvarchar](100) NOT NULL,
	[AddressLine2] [nvarchar](100) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](20) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[IsFavorite] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppSettings]    Script Date: 23.05.2024 14:03:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppSettings](
	[SettingID] [int] IDENTITY(1,1) NOT NULL,
	[SettingName] [nvarchar](100) NOT NULL,
	[SettingValue] [nvarchar](max) NOT NULL,
	[SettingDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AppSettings] PRIMARY KEY CLUSTERED 
(
	[SettingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 23.05.2024 14:03:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Categoryimg] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 23.05.2024 14:03:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[LogDate] [datetime2](7) NOT NULL,
	[LogLevel] [nvarchar](20) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 23.05.2024 14:03:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 23.05.2024 14:03:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[AddressID] [int] NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[TotalAmount] [decimal](18, 2) NOT NULL,
	[StatusID] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderStatuses]    Script Date: 23.05.2024 14:03:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatuses](
	[StatusID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_OrderStatuses] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 23.05.2024 14:03:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[StockQuantity] [int] NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 23.05.2024 14:03:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NULL,
	[RegistrationDate] [datetime2](7) NULL,
	[Language] [bit] NOT NULL,
	[UserType] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240429112419_BurgerDbMigOne', N'8.0.4')
GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([AddressID], [UserID], [AddressLine1], [AddressLine2], [City], [PostalCode], [Country], [IsFavorite], [IsActive]) VALUES (1, 1, N'merkez mah. no 8-10', N'mesar apt. daire 6 eyüpsultan', N'istanbul', N'34000', N'turkiye', 1, 1)
INSERT [dbo].[Addresses] ([AddressID], [UserID], [AddressLine1], [AddressLine2], [City], [PostalCode], [Country], [IsFavorite], [IsActive]) VALUES (11, 3, N'Adres satırı 1', N'Adres satırı 2', N'beşiktaş', N'34353', N'istanbul', 1, 1)
INSERT [dbo].[Addresses] ([AddressID], [UserID], [AddressLine1], [AddressLine2], [City], [PostalCode], [Country], [IsFavorite], [IsActive]) VALUES (16, 7, N'Adres satırı 1', N'Adres satırı 2', N'beşiktaş', N'34353', N'istanbul', 1, 1)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [Name], [Description], [IsActive], [Categoryimg]) VALUES (1, N'Menüler', N'Hazır Paket Menüler', 1, N'Menuler.png')
INSERT [dbo].[Categories] ([CategoryID], [Name], [Description], [IsActive], [Categoryimg]) VALUES (2, N'Burgerler', N'Sadece Burgerler', 1, N'burgerler-icon.png')
INSERT [dbo].[Categories] ([CategoryID], [Name], [Description], [IsActive], [Categoryimg]) VALUES (3, N'Çıtır Lezzetler', N'Patates,soğan halkası,nuggets', 1, N'citir-lezzetler-icon.png')
INSERT [dbo].[Categories] ([CategoryID], [Name], [Description], [IsActive], [Categoryimg]) VALUES (4, N'Kids Menüler', N'Hazır Çocuk Paketleri', 1, N'kids-menuler-icon.png')
INSERT [dbo].[Categories] ([CategoryID], [Name], [Description], [IsActive], [Categoryimg]) VALUES (5, N'Tatlılar', N'Birbirinden lezetli tatlılar', 1, N'tatlilar-icon.png')
INSERT [dbo].[Categories] ([CategoryID], [Name], [Description], [IsActive], [Categoryimg]) VALUES (6, N'İçecekler', N'CocaCola,Fanta,Sprite', 1, N'icecekler-icon.png')
INSERT [dbo].[Categories] ([CategoryID], [Name], [Description], [IsActive], [Categoryimg]) VALUES (7, N'Soslar', N'Ketçap,Mayonez,Ranch', 1, N'soslar-icon.png')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (6, 4, 4, 1, CAST(21.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (7, 4, 5, 1, CAST(19.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (8, 4, 6, 1, CAST(13.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (9, 4, 7, 1, CAST(16.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (10, 5, 1, 1, CAST(12.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (11, 5, 2, 1, CAST(15.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (12, 5, 4, 1, CAST(21.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (13, 5, 5, 1, CAST(19.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (14, 6, 2, 2, CAST(15.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (15, 6, 3, 1, CAST(18.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (16, 6, 4, 2, CAST(21.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (17, 6, 5, 2, CAST(19.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (18, 6, 6, 2, CAST(13.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (19, 6, 7, 1, CAST(16.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (20, 6, 8, 1, CAST(23.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (21, 6, 9, 1, CAST(16.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (22, 7, 1, 1, CAST(12.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (23, 8, 5, 1, CAST(19.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (24, 9, 4, 1, CAST(21.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (25, 10, 4, 1, CAST(21.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (26, 10, 5, 1, CAST(19.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (27, 10, 6, 1, CAST(13.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (28, 10, 7, 1, CAST(16.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (29, 10, 8, 1, CAST(23.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (30, 10, 9, 1, CAST(16.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (31, 11, 71, 2, CAST(5.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (32, 11, 72, 1, CAST(6.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (33, 11, 74, 1, CAST(4.49 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (34, 12, 1, 1, CAST(12.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (35, 12, 2, 1, CAST(15.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (36, 12, 3, 1, CAST(18.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (37, 12, 4, 1, CAST(21.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (38, 12, 5, 1, CAST(19.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (39, 12, 6, 1, CAST(13.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (40, 13, 1, 1, CAST(12.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (41, 13, 2, 1, CAST(15.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (42, 13, 97, 1, CAST(2.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (43, 13, 105, 1, CAST(3.49 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (44, 14, 7, 6, CAST(16.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (45, 14, 8, 4, CAST(23.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (46, 14, 10, 5, CAST(21.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (47, 14, 97, 1, CAST(2.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (48, 14, 98, 1, CAST(1.49 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (49, 15, 75, 1, CAST(4.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (50, 15, 81, 1, CAST(5.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (51, 15, 83, 1, CAST(4.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (52, 15, 89, 3, CAST(1.49 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (53, 16, 1, 1, CAST(12.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (54, 16, 4, 1, CAST(21.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (55, 17, 28, 1, CAST(6.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (56, 17, 29, 1, CAST(8.90 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (57, 17, 30, 1, CAST(7.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (58, 17, 31, 1, CAST(9.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (59, 17, 33, 1, CAST(8.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (60, 17, 34, 1, CAST(5.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (61, 18, 33, 3, CAST(8.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (62, 18, 35, 3, CAST(7.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (63, 18, 38, 3, CAST(11.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (64, 18, 39, 3, CAST(5.90 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (4, 1, 1, CAST(N'2024-05-02T16:21:50.6100951' AS DateTime2), CAST(72.96 AS Decimal(18, 2)), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (5, 1, 1, CAST(N'2024-05-02T16:37:02.5090658' AS DateTime2), CAST(70.96 AS Decimal(18, 2)), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (6, 1, 1, CAST(N'2024-05-02T19:23:30.9465889' AS DateTime2), CAST(220.88 AS Decimal(18, 2)), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (7, 1, 1, CAST(N'2024-05-03T20:23:48.8574398' AS DateTime2), CAST(12.99 AS Decimal(18, 2)), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (8, 1, 1, CAST(N'2024-05-03T20:25:26.2820880' AS DateTime2), CAST(19.99 AS Decimal(18, 2)), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (9, 1, 1, CAST(N'2024-05-03T20:55:04.0755949' AS DateTime2), CAST(21.99 AS Decimal(18, 2)), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (10, 1, 1, CAST(N'2024-05-04T04:36:43.4453173' AS DateTime2), CAST(113.94 AS Decimal(18, 2)), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (11, 1, 1, CAST(N'2024-05-04T10:30:26.3956127' AS DateTime2), CAST(23.46 AS Decimal(18, 2)), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (12, 1, 1, CAST(N'2024-05-04T13:44:35.5553982' AS DateTime2), CAST(103.94 AS Decimal(18, 2)), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (13, 1, 1, CAST(N'2024-05-07T19:12:57.9429100' AS DateTime2), CAST(35.46 AS Decimal(18, 2)), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (14, 1, 1, CAST(N'2024-05-07T19:16:01.2794373' AS DateTime2), CAST(312.33 AS Decimal(18, 2)), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (15, 1, 1, CAST(N'2024-05-09T19:00:59.9391059' AS DateTime2), CAST(20.44 AS Decimal(18, 2)), 1)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (16, 3, 11, CAST(N'2024-05-11T23:31:14.4448141' AS DateTime2), CAST(34.98 AS Decimal(18, 2)), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (17, 3, 11, CAST(N'2024-05-11T23:34:58.2292715' AS DateTime2), CAST(48.85 AS Decimal(18, 2)), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [AddressID], [OrderDate], [TotalAmount], [StatusID]) VALUES (18, 1, 1, CAST(N'2024-05-14T19:13:27.2852354' AS DateTime2), CAST(104.61 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderStatuses] ON 

INSERT [dbo].[OrderStatuses] ([StatusID], [Name], [Description]) VALUES (1, N'Sipariş Alındı', N'Sipariş sisteme girildi.')
INSERT [dbo].[OrderStatuses] ([StatusID], [Name], [Description]) VALUES (2, N'Hazırlanıyor...', N'Mutfakta işlem görmeye başladı')
INSERT [dbo].[OrderStatuses] ([StatusID], [Name], [Description]) VALUES (3, N'Sipariş Tamamlandı', N'Ürünler hazır')
SET IDENTITY_INSERT [dbo].[OrderStatuses] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (1, 1, N'Bean Burger Menü', N'Tadını doyasıya çıkarın.', CAST(12.99 AS Decimal(18, 2)), 100, N'Menuler\BeanBurgerMenu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (2, 1, N'Big King Jr Menü', N'Küçük ama lezzet dolu.', CAST(15.99 AS Decimal(18, 2)), 100, N'Menuler\big-king-jr-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (3, 1, N'Big King Menü', N'Kral gibi bir lezzet deneyimi.', CAST(18.99 AS Decimal(18, 2)), 100, N'Menuler\big-king-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (4, 1, N'Big King XXL Menü', N'Büyük bir lezzet, büyük bir doygunluk.', CAST(21.99 AS Decimal(18, 2)), 100, N'Menuler\big-king-xxl-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (5, 1, N'BK Steakhouse Burger Menü', N'Tadına doyulmaz bir ziyafet.', CAST(19.99 AS Decimal(18, 2)), 100, N'Menuler\bk-steakhouse-burger-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (6, 1, N'Cheeseburger Menü', N'Lezzetli peynirle zenginleştirilmiş.', CAST(13.99 AS Decimal(18, 2)), 100, N'Menuler\cheeseburger-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (7, 1, N'Chicken Royale Burger Menü', N'Tavuk sevenler için mükemmel bir seçim.', CAST(16.99 AS Decimal(18, 2)), 100, N'Menuler\chicken-royale-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (8, 1, N'Double Big King Menü', N'İki kat lezzet, iki kat doyum.', CAST(23.99 AS Decimal(18, 2)), 100, N'Menuler\double-big-king-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (9, 1, N'Double Cheeseburger Menü', N'Çift peynir, çift lezzet.', CAST(16.99 AS Decimal(18, 2)), 100, N'Menuler\double-cheeseburger-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (10, 1, N'Double Kofteburger Menü', N'İki kat lezzet, iki kat doyum.', CAST(21.99 AS Decimal(18, 2)), 100, N'Menuler\double-kofteburger-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (11, 1, N'Double Texas Smokehouse Burger Menü', N'Teksas tarzı büyük lezzet.', CAST(25.99 AS Decimal(18, 2)), 100, N'Menuler\double-texas-smokehouse-burger-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (12, 1, N'Double Whopper Jr Menü', N'Daha fazla lezzet, daha küçük boyut.', CAST(19.99 AS Decimal(18, 2)), 100, N'Menuler\double-whopper-jr-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (13, 1, N'Double Whopper Menü', N'Lezzetin iki katı, keyfin iki katı.', CAST(22.99 AS Decimal(18, 2)), 100, N'Menuler\double-whopper-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (14, 1, N'Etli Barbeku Brioche Menü', N'Barbekü lezzetinin tadını çıkarın.', CAST(20.99 AS Decimal(18, 2)), 100, N'Menuler\etli-barbeku-brioche-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (15, 1, N'Etli Barbeku Deluxe Burger Menü', N'Deluxe lezzet, deluxe doyum.', CAST(23.99 AS Decimal(18, 2)), 100, N'Menuler\etli-barbeku-deluxe-burger-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (16, 1, N'Fish Royale Menü', N'Deniz ürünlerinin tadını çıkarın.', CAST(18.99 AS Decimal(18, 2)), 100, N'Menuler\fish-royale-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (17, 1, N'Hamburger Menü', N'Klasik lezzetin eşsiz tatları.', CAST(11.99 AS Decimal(18, 2)), 100, N'Menuler\hamburger-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (18, 1, N'King Beef Burger Menü', N'Lezzetin kralı.', CAST(17.99 AS Decimal(18, 2)), 100, N'Menuler\king-beef-burger-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (19, 1, N'King Chicken Menü', N'Tavuklu lezzetin kralı.', CAST(16.99 AS Decimal(18, 2)), 100, N'Menuler\king-chicken-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (20, 1, N'Klasik Gurme Tavuk Menü', N'Gurme tadında tavuk.', CAST(18.99 AS Decimal(18, 2)), 100, N'Menuler\klasik-gurme-tavuk-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (21, 1, N'Kofteburger Menü', N'Tadı damaklarda kalacak.', CAST(15.99 AS Decimal(18, 2)), 100, N'Menuler\kofteburger-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (22, 1, N'Mega Double Cheeseburger Menü', N'Mega lezzet, mega doyum.', CAST(24.99 AS Decimal(18, 2)), 100, N'Menuler\mega-double-cheeseburger-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (23, 1, N'Rodeo Whopper Menü', N'Tadına doyulmaz bir macera.', CAST(21.99 AS Decimal(18, 2)), 100, N'Menuler\rodeo-whopper-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (24, 1, N'Spicy Gurme Tavuk Menü', N'Baharatlı lezzetin tadını çıkarın.', CAST(19.99 AS Decimal(18, 2)), 100, N'Menuler\spicy-gurme-tavuk-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (25, 1, N'Tavukburger Menü', N'Tavuklu lezzetin tadı.', CAST(17.99 AS Decimal(18, 2)), 100, N'Menuler\tavukburger-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (26, 1, N'Tavuklu Barbeku Brioche Menü', N'Lezzetli tavuklu barbekü.', CAST(20.99 AS Decimal(18, 2)), 100, N'Menuler\tavuklu-barbeku-brioche-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (27, 1, N'Tavuklu Barbeku Deluxe Burger Menü', N'Tavuklu deluxe burger keyfi.', CAST(23.99 AS Decimal(18, 2)), 100, N'Menuler\tavuklu-barbeku-deluxe-burger-menu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (28, 2, N'Bean Burger', N'Tadını doyasıya çıkarın.', CAST(6.99 AS Decimal(18, 2)), 100, N'Burgerler\bean-burger.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (29, 2, N'Big King', N'Kral gibi bir lezzet deneyimi.', CAST(8.90 AS Decimal(18, 2)), 100, N'Burgerler\big-king.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (30, 2, N'Big King Jr', N'Küçük ama lezzet dolu.', CAST(7.99 AS Decimal(18, 2)), 100, N'Burgerler\big-king-jr.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (31, 2, N'Big King XXL', N'Büyük bir lezzet, büyük bir doygunluk.', CAST(9.99 AS Decimal(18, 2)), 100, N'Burgerler\big-king-xxl.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (33, 2, N'BK Steakhouse Burger', N'Tadına doyulmaz bir ziyafet.', CAST(8.99 AS Decimal(18, 2)), 100, N'Burgerler\bk-steakhouse-burger.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (34, 2, N'Cheeseburger', N'Lezzetli peynirle zenginleştirilmiş.', CAST(5.99 AS Decimal(18, 2)), 100, N'Burgerler\cheeseburger.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (35, 2, N'Chicken Royale', N'Tavuk sevenler için mükemmel bir seçim.', CAST(7.99 AS Decimal(18, 2)), 100, N'Burgerler\chicken-royale.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (38, 2, N'Double Big King', N'İki kat lezzet, iki kat doyum.', CAST(11.99 AS Decimal(18, 2)), 100, N'Burgerler\double-big-king.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (39, 2, N'Double Cheeseburger', N'Çift peynir, çift lezzet.', CAST(5.90 AS Decimal(18, 2)), 100, N'Burgerler\double-cheeseburger.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (40, 2, N'Double King Chicken', N'Çifte tavuk ziyafeti.', CAST(9.50 AS Decimal(18, 2)), 100, N'Burgerler\double-king-chicken.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (41, 2, N'Double Köfteburger', N'İki kat lezzet, iki kat doyum.', CAST(10.90 AS Decimal(18, 2)), 100, N'Burgerler\double-kofteburger-1.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (42, 2, N'Double Texas Smokehouse Burger', N'Teksas tarzı büyük lezzet.', CAST(12.99 AS Decimal(18, 2)), 100, N'Burgerler\double-texas-smokehouse-burger-1.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (43, 2, N'Double Whopper Jr', N'Daha fazla lezzet, daha küçük boyut.', CAST(9.90 AS Decimal(18, 2)), 100, N'Burgerler\double-whopper-jr.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (44, 2, N'Double Whopper', N'Lezzetin iki katı, keyfin iki katı.', CAST(11.90 AS Decimal(18, 2)), 100, N'Burgerler\double-whopper.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (45, 2, N'Etli Barbeku Brioche', N'Barbekü lezzetinin tadını çıkarın.', CAST(8.90 AS Decimal(18, 2)), 100, N'Burgerler\etli-barbeku-brioche.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (46, 2, N'Etli Barbeku Deluxe Burger', N'Deluxe lezzet, deluxe doyum.', CAST(10.90 AS Decimal(18, 2)), 100, N'Burgerler\etli-barbeku-deluxe-burger-1.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (47, 2, N'Fish Royale', N'Deniz ürünlerinin tadını çıkarın.', CAST(9.99 AS Decimal(18, 2)), 100, N'Burgerler\fish-royale-1.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (48, 2, N'Hamburger', N'Klasik lezzetin eşsiz tatları.', CAST(4.90 AS Decimal(18, 2)), 100, N'Burgerler\hamburger.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (49, 2, N'King Beef Burger', N'Lezzetin kralı.', CAST(7.90 AS Decimal(18, 2)), 100, N'Burgerler\king-beef-burger.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (50, 2, N'King Chicken', N'Tavuklu lezzetin kralı.', CAST(8.90 AS Decimal(18, 2)), 100, N'Burgerler\king-chicken-1.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (51, 2, N'Klasik Gurme Tavuk', N'Gurme tadında tavuk.', CAST(9.90 AS Decimal(18, 2)), 100, N'Burgerler\klasik-gurme-tavuk-1.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (52, 2, N'Köfteburger', N'Tadı damaklarda kalacak.', CAST(7.99 AS Decimal(18, 2)), 100, N'Burgerler\kofteburger-1.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (53, 2, N'Mega Double Cheeseburger', N'Mega lezzet, mega doyum.', CAST(12.99 AS Decimal(18, 2)), 100, N'Burgerler\mega-double-cheeseburger.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (55, 2, N'Plant-Based Whopper', N'Bitkisel lezzetlerin tadı.', CAST(8.90 AS Decimal(18, 2)), 100, N'Burgerler\plant-based-whopper.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (56, 2, N'Rodeo Whopper', N'Tadına doyulmaz bir macera.', CAST(10.90 AS Decimal(18, 2)), 100, N'Burgerler\rodeo-whopper.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (58, 2, N'Spicy Gurme Tavuk', N'Baharatlı lezzetin tadını çıkarın.', CAST(9.90 AS Decimal(18, 2)), 100, N'Burgerler\spicy-gurme-tavuk.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (59, 2, N'Tavuklu Barbeku Brioche', N'Lezzetli tavuklu barbekü.', CAST(8.90 AS Decimal(18, 2)), 100, N'Burgerler\tavuklu-barbeku-brioche.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (60, 2, N'Tavuklu Barbeku Deluxe Burger', N'Tavuklu deluxe burger keyfi.', CAST(11.90 AS Decimal(18, 2)), 100, N'Burgerler\tavuklu-barbeku-deluxe-burger.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (61, 3, N'Tavuk Nuggets', N'Cıtır çıtır tavuk parçaları, özel soslarla sunulur.', CAST(14.99 AS Decimal(18, 2)), 100, N'CitirLezzetler\bk-king-nuggets-1.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (62, 3, N'Tavuk Şeritleri', N'Sıcak ve sulu tavuk şeritleri, özel soslarla sunulur.', CAST(19.99 AS Decimal(18, 2)), 80, N'CitirLezzetler\chicken-tenders.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (63, 3, N'Çıtır Peynir', N'Eriyen mozzarella peyniri, çıtır pane kaplamasıyla.', CAST(9.99 AS Decimal(18, 2)), 120, N'CitirLezzetler\citir-peynir.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (64, 3, N'Patates', N'Altın sarısı, çıtır çıtır patates kızartması.', CAST(7.99 AS Decimal(18, 2)), 150, N'CitirLezzetler\patates.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (65, 3, N'Soğan Halkası', N'Kızarmış soğan halkaları, özel soslarla sunulur.', CAST(10.99 AS Decimal(18, 2)), 100, N'CitirLezzetler\sogan-halkasi.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (66, 3, N'Tırtikli Patates', N'Spiral şeklinde kesilmiş, çıtır çıtır patates kızartması.', CAST(9.99 AS Decimal(18, 2)), 130, N'CitirLezzetler\tirtikli-patates.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (67, 4, N'Kids Cheeseburger', N'Cıtır çıtır tavuk parçaları, özel soslarla sunulur.', CAST(12.99 AS Decimal(18, 2)), 100, N'KidsMenuler\kids-cheeseburger.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (68, 4, N'Kids Hamburger', N'Sıcak ve sulu tavuk şeritleri, özel soslarla sunulur.', CAST(17.99 AS Decimal(18, 2)), 80, N'KidsMenuler\kids-hamburger.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (69, 4, N'Kids Tavuk Burger', N'Eriyen mozzarella peyniri, çıtır pane kaplamasıyla.', CAST(8.99 AS Decimal(18, 2)), 120, N'KidsMenuler\kids-tavukburger.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (70, 4, N'Kids Tenders', N'Altın sarısı, çıtır çıtır patates kızartması.', CAST(6.99 AS Decimal(18, 2)), 150, N'KidsMenuler\kids-tenders.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (71, 5, N'Bkool', N'Lezzetli ve serinletici bir dondurma deneyimi.', CAST(5.99 AS Decimal(18, 2)), 100, N'Tatlilar\bkool.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (72, 5, N'Çikolatalı Dondurma Kornet', N'Kıtır bir kornet içinde yumuşak çikolatalı dondurma.', CAST(6.99 AS Decimal(18, 2)), 130, N'Tatlilar\cikolata-dolgulu-kornet.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (73, 5, N'Çikolatalı Kurabiye', N'Çıtır çıtır ve lezzetli çikolatalı kurabiye.', CAST(3.99 AS Decimal(18, 2)), 120, N'Tatlilar\cikolatali-cookie.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (74, 5, N'Çikolatalı Parçacıklı Kurabiye', N'Yumuşak ve lezzetli, bol çikolatalı parçacıklar içeren kurabiye.', CAST(4.49 AS Decimal(18, 2)), 100, N'Tatlilar\cikolata-parcacikli-cookie.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (75, 5, N'Elmalı Tatlı', N'Taze elmalar ve lezzetli bir sosla hazırlanmış tatlı.', CAST(4.99 AS Decimal(18, 2)), 150, N'Tatlilar\elmali-tatli.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (76, 5, N'King Sundae', N'Vanilyalı ve çikolatalı dondurma, çilek sosu ve whipped cream ile dolu bir sundae.', CAST(7.99 AS Decimal(18, 2)), 80, N'Tatlilar\king-sundae.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (77, 5, N'Korumalı Koni', N'Vanilyalı dondurma, çilek sosu ve whipped cream ile dolu kornet.', CAST(5.49 AS Decimal(18, 2)), 130, N'Tatlilar\\kornet-kulah.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (78, 5, N'Koni Dondurma', N'Vanilyalı dondurma ile dolu çıtır bir koni.', CAST(4.99 AS Decimal(18, 2)), 150, N'Tatlilar\kulah-dondurma-1.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (79, 5, N'Milkshake Çeşitleri', N'Vanilyalı, çikolatalı ve çilekli milkshake seçenekleri.', CAST(6.99 AS Decimal(18, 2)), 100, N'Tatlilar\milkshake-cesitleri.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (80, 5, N'Mini Sundae', N'Vanilyalı ve çikolatalı dondurma, çilek sosu ve whipped cream ile dolu küçük bir sundae.', CAST(4.49 AS Decimal(18, 2)), 120, N'Tatlilar\mini-sundae.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (81, 5, N'Sufle', N'Yumuşak ve lezzetli, pudra şekeri ile servis edilen sufle.', CAST(5.99 AS Decimal(18, 2)), 80, N'Tatlilar\sufle.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (82, 5, N'Sundae', N'Vanilyalı ve çikolatalı dondurma, çilek sosu ve whipped cream ile dolu bir sundae.', CAST(6.49 AS Decimal(18, 2)), 100, N'Tatlilar\sundae.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (83, 5, N'Vişneli Tatlı', N'Taze vişneler ve lezzetli bir sosla hazırlanmış tatlı.', CAST(4.99 AS Decimal(18, 2)), 130, N'Tatlilar\visneli-tatli.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (84, 6, N'Ayran 195 ml', N'Serinletici ve ferah bir yaz içeceği.', CAST(0.99 AS Decimal(18, 2)), 100, N'Icecekler\ayran-195-ml.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (85, 6, N'Ayran 300 ml', N'Daha doyurucu bir seçenek.', CAST(1.29 AS Decimal(18, 2)), 80, N'Icecekler\ayran-300-ml.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (86, 6, N'Cappy Atom 200 ml', N'Vitamin ve mineral açısından zengin.', CAST(1.49 AS Decimal(18, 2)), 120, N'Icecekler\cappy-atom-200-ml.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (87, 6, N'Cappy Destek 200 ml', N'Spor ve egzersiz sonrası için ideal.', CAST(1.49 AS Decimal(18, 2)), 100, N'Icecekler\cappy-destek-200-ml.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (88, 6, N'Çikolatalı Süt', N'Çocukların ve yetişkinlerin sevdiği lezzet.', CAST(1.99 AS Decimal(18, 2)), 150, N'Icecekler\cikolatali-sut.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (89, 6, N'Coca Cola', N'Klasik ve en sevilen kola.', CAST(1.49 AS Decimal(18, 2)), 130, N'Icecekler\coca-cola.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (90, 6, N'Coca Cola Light', N'Daha az şekerli, aynı lezzet.', CAST(1.49 AS Decimal(18, 2)), 120, N'Icecekler\coca-cola-light.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (91, 6, N'Coca Cola Zero Sugar', N'Şekersiz ve kalorisiz kola.', CAST(1.49 AS Decimal(18, 2)), 100, N'Icecekler\coca-cola-zero-sugar.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (92, 6, N'Elma Suyu', N'Doğal ve sağlıklı bir meyve suyu.', CAST(1.49 AS Decimal(18, 2)), 150, N'Icecekler\elma-suyu.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (93, 6, N'Fanta', N'Portakal aromalı ferahlatıcı içecek.', CAST(1.49 AS Decimal(18, 2)), 130, N'Icecekler\fanta.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (94, 6, N'Fuse Tea', N'Buzlu çay keyfi.', CAST(1.49 AS Decimal(18, 2)), 120, N'Icecekler\fuse-tea.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (95, 6, N'Sade Süt', N'Kahvaltıların vazgeçilmezi.', CAST(1.49 AS Decimal(18, 2)), 150, N'Icecekler\sade-sut.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (96, 6, N'Sprite', N'Limon aromalı ferahlatıcı içecek.', CAST(1.49 AS Decimal(18, 2)), 130, N'Icecekler\sprite.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (97, 7, N'Aci Hardal', N'Lezzetli acı hardal', CAST(2.99 AS Decimal(18, 2)), 100, N'Soslar\aci-hardal.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (98, 7, N'Mini Aci Sos', N'Küçük boy acı sos', CAST(1.49 AS Decimal(18, 2)), 50, N'Soslar\mini-aci-sos.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (99, 7, N'Mini BBQ', N'Lezzetli mini BBQ sosu', CAST(1.99 AS Decimal(18, 2)), 75, N'Soslar\mini-bbq.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (100, 7, N'Mini Buffalo', N'Mini buffalo sosu', CAST(1.79 AS Decimal(18, 2)), 60, N'Soslar\mini-buffalo-1.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (101, 7, N'Mini Ketçap', N'Küçük boy ketçap', CAST(0.99 AS Decimal(18, 2)), 100, N'Soslar\mini-ketcap.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (102, 7, N'Mini Mayonez', N'Lezzetli mini mayonez', CAST(1.29 AS Decimal(18, 2)), 80, N'Soslar\mini-mayonez.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (103, 7, N'Mini Ranch', N'Mini ranch sosu', CAST(1.59 AS Decimal(18, 2)), 70, N'Soslar\mini-ranch.png', 1)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (104, 7, N'Mini Sarımsaklı Mayonez', N'Lezzetli mini sarımsaklı mayonez', CAST(1.49 AS Decimal(18, 2)), 60, N'Soslar\mini-sarimsakli-mayonez-1.png', 1)
GO
INSERT [dbo].[Products] ([ProductID], [CategoryID], [Name], [Description], [Price], [StockQuantity], [Image], [IsActive]) VALUES (105, 7, N'Truflü Mayonez', N'Trüf aromalı lezzetli mayonez', CAST(3.49 AS Decimal(18, 2)), 40, N'Soslar\truflu-mayonez.png', 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [IsActive], [RegistrationDate], [Language], [UserType]) VALUES (1, N'botanoz', N'botan123', N'botanozalp@gmail.com', N'Botan', N'Özalp', 1, CAST(N'2024-05-02T12:42:50.0933333' AS DateTime2), 1, 1)
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [IsActive], [RegistrationDate], [Language], [UserType]) VALUES (3, N'admin', N'admin', N'admin@admin', N'admin', N'admin', 1, CAST(N'2024-05-11T21:05:05.3871476' AS DateTime2), 1, 2)
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [IsActive], [RegistrationDate], [Language], [UserType]) VALUES (4, N'denme', N'deneme', N'deneme@deneme', N'denme', N'denme', 1, CAST(N'2024-05-13T21:51:25.3844967' AS DateTime2), 0, 1)
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [IsActive], [RegistrationDate], [Language], [UserType]) VALUES (7, N'user', N'user', N'user@user', N'username', N'userlast', 1, CAST(N'2024-05-23T14:02:17.4043481' AS DateTime2), 0, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [IX_Addresses_UserID]    Script Date: 23.05.2024 14:03:42 ******/
CREATE NONCLUSTERED INDEX [IX_Addresses_UserID] ON [dbo].[Addresses]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Logs_UserID]    Script Date: 23.05.2024 14:03:42 ******/
CREATE NONCLUSTERED INDEX [IX_Logs_UserID] ON [dbo].[Logs]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetails_OrderID]    Script Date: 23.05.2024 14:03:42 ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetails_OrderID] ON [dbo].[OrderDetails]
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetails_ProductID]    Script Date: 23.05.2024 14:03:42 ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetails_ProductID] ON [dbo].[OrderDetails]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_AddressID]    Script Date: 23.05.2024 14:03:42 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_AddressID] ON [dbo].[Orders]
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_StatusID]    Script Date: 23.05.2024 14:03:42 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_StatusID] ON [dbo].[Orders]
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_UserID]    Script Date: 23.05.2024 14:03:42 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_UserID] ON [dbo].[Orders]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryID]    Script Date: 23.05.2024 14:03:42 ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryID] ON [dbo].[Products]
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_Username]    Script Date: 23.05.2024 14:03:42 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_Username] ON [dbo].[Users]
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_RegistrationDate]  DEFAULT (getdate()) FOR [RegistrationDate]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Users_UserID]
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_Logs_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_Logs_Users_UserID]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders_OrderID] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders_OrderID]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products_ProductID]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Addresses_AddressID] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Addresses] ([AddressID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Addresses_AddressID]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_OrderStatuses_StatusID] FOREIGN KEY([StatusID])
REFERENCES [dbo].[OrderStatuses] ([StatusID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_OrderStatuses_StatusID]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users_UserID]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryID]
GO
USE [master]
GO
ALTER DATABASE [BurgerAppDb] SET  READ_WRITE 
GO
