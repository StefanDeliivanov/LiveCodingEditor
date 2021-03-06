USE [master]
GO
/****** Object:  Database [LiveCodingEditor]    Script Date: 28.9.2021 г. 1:07:00 ******/
CREATE DATABASE [LiveCodingEditor]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LiveCodingEditor', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LiveCodingEditor.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LiveCodingEditor_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LiveCodingEditor_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LiveCodingEditor] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LiveCodingEditor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LiveCodingEditor] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET ARITHABORT OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LiveCodingEditor] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LiveCodingEditor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LiveCodingEditor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LiveCodingEditor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LiveCodingEditor] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [LiveCodingEditor] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LiveCodingEditor] SET  MULTI_USER 
GO
ALTER DATABASE [LiveCodingEditor] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LiveCodingEditor] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LiveCodingEditor] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LiveCodingEditor] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LiveCodingEditor] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LiveCodingEditor] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LiveCodingEditor] SET QUERY_STORE = OFF
GO
USE [LiveCodingEditor]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 28.9.2021 г. 1:07:00 ******/
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
/****** Object:  Table [dbo].[HtmlExamples]    Script Date: 28.9.2021 г. 1:07:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HtmlExamples](
	[Id] [nvarchar](450) NOT NULL,
	[CodeText] [nvarchar](max) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_HtmlExamples] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[HtmlExamples] ADD  DEFAULT (N'') FOR [CodeText]
GO
USE [master]
GO
ALTER DATABASE [LiveCodingEditor] SET  READ_WRITE 
GO
