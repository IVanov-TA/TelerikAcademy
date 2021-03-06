USE [master]
GO
/****** Object:  Database [Continents]    Script Date: 24.8.2014 г. 15:40:20 ******/
CREATE DATABASE [Continents]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Continents', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Continents.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Continents_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Continents_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Continents] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Continents].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Continents] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Continents] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Continents] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Continents] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Continents] SET ARITHABORT OFF 
GO
ALTER DATABASE [Continents] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Continents] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Continents] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Continents] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Continents] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Continents] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Continents] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Continents] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Continents] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Continents] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Continents] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Continents] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Continents] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Continents] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Continents] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Continents] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Continents] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Continents] SET RECOVERY FULL 
GO
ALTER DATABASE [Continents] SET  MULTI_USER 
GO
ALTER DATABASE [Continents] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Continents] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Continents] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Continents] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Continents] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Continents', N'ON'
GO
USE [Continents]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 24.8.2014 г. 15:40:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[Address_Text] [nvarchar](200) NULL,
	[TownID] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continent]    Script Date: 24.8.2014 г. 15:40:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continent](
	[ContinetID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Continent] PRIMARY KEY CLUSTERED 
(
	[ContinetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 24.8.2014 г. 15:40:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContinentID] [int] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 24.8.2014 г. 15:40:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[AddressID] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Town]    Script Date: 24.8.2014 г. 15:40:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[TownID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryID] [int] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[TownID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([AddressID], [Address_Text], [TownID]) VALUES (1, N'Shipchenski prohod 22', 1)
INSERT [dbo].[Address] ([AddressID], [Address_Text], [TownID]) VALUES (2, N'Neznaina 1', 2)
INSERT [dbo].[Address] ([AddressID], [Address_Text], [TownID]) VALUES (3, N'Nairoby Str 2021', 6)
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[Continent] ON 

INSERT [dbo].[Continent] ([ContinetID], [Name]) VALUES (1, N'Europe')
INSERT [dbo].[Continent] ([ContinetID], [Name]) VALUES (2, N'Africa')
SET IDENTITY_INSERT [dbo].[Continent] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (2, N'Bulgaria', 1)
INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (3, N'Kenya', 2)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([PersonID], [First_Name], [Last_Name], [AddressID]) VALUES (1, N'Pesho', N'Peshev', 1)
INSERT [dbo].[Person] ([PersonID], [First_Name], [Last_Name], [AddressID]) VALUES (2, N'Maria', N'Vanova', 2)
INSERT [dbo].[Person] ([PersonID], [First_Name], [Last_Name], [AddressID]) VALUES (3, N'Mboa', N'Manakki', 3)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Town] ON 

INSERT [dbo].[Town] ([TownID], [Name], [CountryID]) VALUES (1, N'Sofia', 2)
INSERT [dbo].[Town] ([TownID], [Name], [CountryID]) VALUES (2, N'Plovdiv', 2)
INSERT [dbo].[Town] ([TownID], [Name], [CountryID]) VALUES (6, N'Nairobi', 3)
SET IDENTITY_INSERT [dbo].[Town] OFF
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Town] FOREIGN KEY([TownID])
REFERENCES [dbo].[Town] ([TownID])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Town]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Continent] FOREIGN KEY([ContinentID])
REFERENCES [dbo].[Continent] ([ContinetID])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Continent]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Address] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Address] ([AddressID])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Address]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_Country] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Country] ([CountryID])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_Country]
GO
USE [master]
GO
ALTER DATABASE [Continents] SET  READ_WRITE 
GO
