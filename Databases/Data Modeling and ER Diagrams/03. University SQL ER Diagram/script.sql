USE [master]
GO
/****** Object:  Database [Universities]    Script Date: 24.8.2014 г. 19:24:11 ******/
CREATE DATABASE [Universities]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Universities', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Universities.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Universities_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Universities_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Universities] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Universities].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Universities] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Universities] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Universities] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Universities] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Universities] SET ARITHABORT OFF 
GO
ALTER DATABASE [Universities] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Universities] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Universities] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Universities] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Universities] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Universities] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Universities] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Universities] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Universities] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Universities] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Universities] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Universities] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Universities] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Universities] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Universities] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Universities] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Universities] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Universities] SET RECOVERY FULL 
GO
ALTER DATABASE [Universities] SET  MULTI_USER 
GO
ALTER DATABASE [Universities] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Universities] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Universities] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Universities] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Universities] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Universities', N'ON'
GO
USE [Universities]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 24.8.2014 г. 19:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DepartmentID] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 24.8.2014 г. 19:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[FaciltityID] [int] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 24.8.2014 г. 19:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[FacultyID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[UnivesityID] [int] NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[FacultyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professor_Course]    Script Date: 24.8.2014 г. 19:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor_Course](
	[ProfessorID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
 CONSTRAINT [PK_Professor_Course] PRIMARY KEY CLUSTERED 
(
	[ProfessorID] ASC,
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professor_Title]    Script Date: 24.8.2014 г. 19:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor_Title](
	[ProfessorID] [int] NOT NULL,
	[TitleID] [int] NOT NULL,
 CONSTRAINT [PK_Professor_Title] PRIMARY KEY CLUSTERED 
(
	[ProfessorID] ASC,
	[TitleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 24.8.2014 г. 19:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[ProfesorID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DepartmenID] [int] NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[ProfesorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 24.8.2014 г. 19:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[FacultyID] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_Course]    Script Date: 24.8.2014 г. 19:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Course](
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
 CONSTRAINT [PK_Student_Course] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC,
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 24.8.2014 г. 19:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[TitleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[TitleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Universities]    Script Date: 24.8.2014 г. 19:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Universities](
	[UnivesityID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Universities] PRIMARY KEY CLUSTERED 
(
	[UnivesityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departments] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Departments] ([DepartmentID])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departments]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([FaciltityID])
REFERENCES [dbo].[Faculties] ([FacultyID])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
ALTER TABLE [dbo].[Faculties]  WITH CHECK ADD  CONSTRAINT [FK_Faculties_Universities] FOREIGN KEY([UnivesityID])
REFERENCES [dbo].[Universities] ([UnivesityID])
GO
ALTER TABLE [dbo].[Faculties] CHECK CONSTRAINT [FK_Faculties_Universities]
GO
ALTER TABLE [dbo].[Professor_Course]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Course_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[Professor_Course] CHECK CONSTRAINT [FK_Professor_Course_Courses]
GO
ALTER TABLE [dbo].[Professor_Course]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Course_Professors] FOREIGN KEY([ProfessorID])
REFERENCES [dbo].[Professors] ([ProfesorID])
GO
ALTER TABLE [dbo].[Professor_Course] CHECK CONSTRAINT [FK_Professor_Course_Professors]
GO
ALTER TABLE [dbo].[Professor_Title]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Title_Professors] FOREIGN KEY([ProfessorID])
REFERENCES [dbo].[Professors] ([ProfesorID])
GO
ALTER TABLE [dbo].[Professor_Title] CHECK CONSTRAINT [FK_Professor_Title_Professors]
GO
ALTER TABLE [dbo].[Professor_Title]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Title_Titles] FOREIGN KEY([TitleID])
REFERENCES [dbo].[Titles] ([TitleID])
GO
ALTER TABLE [dbo].[Professor_Title] CHECK CONSTRAINT [FK_Professor_Title_Titles]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Departments] FOREIGN KEY([DepartmenID])
REFERENCES [dbo].[Departments] ([DepartmentID])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_Professors_Departments]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Faculties] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculties] ([FacultyID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Faculties]
GO
ALTER TABLE [dbo].[Student_Course]  WITH CHECK ADD  CONSTRAINT [FK_Student_Course_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[Student_Course] CHECK CONSTRAINT [FK_Student_Course_Courses]
GO
ALTER TABLE [dbo].[Student_Course]  WITH CHECK ADD  CONSTRAINT [FK_Student_Course_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO
ALTER TABLE [dbo].[Student_Course] CHECK CONSTRAINT [FK_Student_Course_Student]
GO
USE [master]
GO
ALTER DATABASE [Universities] SET  READ_WRITE 
GO
