USE [master]
GO

/****** Object:  Database [DB_SistemaMicroondas]    Script Date: 09/07/2024 11:06:01 ******/
CREATE DATABASE [DB_SistemaMicroondas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_SistemaMicroondas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DB_SistemaMicroondas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_SistemaMicroondas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DB_SistemaMicroondas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_SistemaMicroondas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [DB_SistemaMicroondas] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET ARITHABORT OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET  ENABLE_BROKER 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET RECOVERY FULL 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET  MULTI_USER 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [DB_SistemaMicroondas] SET DB_CHAINING OFF 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [DB_SistemaMicroondas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [DB_SistemaMicroondas] SET QUERY_STORE = ON
GO

ALTER DATABASE [DB_SistemaMicroondas] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [DB_SistemaMicroondas] SET  READ_WRITE 
GO


