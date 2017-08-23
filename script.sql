USE [master]
GO
/****** Object:  Database [Pruebas]    Script Date: 23/8/2017 16:41:29 ******/
CREATE DATABASE [Pruebas] ON  PRIMARY 
( NAME = N'Pruebas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Pruebas.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Pruebas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Pruebas_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pruebas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pruebas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pruebas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pruebas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pruebas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pruebas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pruebas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pruebas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pruebas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pruebas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pruebas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pruebas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pruebas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pruebas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pruebas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pruebas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pruebas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pruebas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pruebas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pruebas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pruebas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pruebas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pruebas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pruebas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Pruebas] SET  MULTI_USER 
GO
ALTER DATABASE [Pruebas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pruebas] SET DB_CHAINING OFF 
GO
USE [Pruebas]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 23/8/2017 16:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ApellidoPaterno] [varchar](50) NOT NULL,
	[ApellidoMaterno] [varchar](50) NOT NULL,
	[Direccion] [varchar](300) NULL,
	[Telefono] [nchar](10) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [Pruebas] SET  READ_WRITE 
GO
