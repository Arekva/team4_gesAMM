USE [master]
GO

/****** Object:  Database [GSB_gesAMM]    Script Date: 15/12/2020 17:27:40 ******/
CREATE DATABASE [GSB_gesAMM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GSB_gesAMM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GSB_gesAMM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GSB_gesAMM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GSB_gesAMM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GSB_gesAMM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [GSB_gesAMM] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET ARITHABORT OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [GSB_gesAMM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [GSB_gesAMM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET  DISABLE_BROKER 
GO

ALTER DATABASE [GSB_gesAMM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [GSB_gesAMM] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [GSB_gesAMM] SET  MULTI_USER 
GO

ALTER DATABASE [GSB_gesAMM] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [GSB_gesAMM] SET DB_CHAINING OFF 
GO

ALTER DATABASE [GSB_gesAMM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [GSB_gesAMM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [GSB_gesAMM] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [GSB_gesAMM] SET QUERY_STORE = OFF
GO

ALTER DATABASE [GSB_gesAMM] SET  READ_WRITE 
GO
