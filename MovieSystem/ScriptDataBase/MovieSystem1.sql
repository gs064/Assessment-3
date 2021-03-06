USE [master]
GO
/****** Object:  Database [MovieSystem]    Script Date: 2/24/2021 3:13:15 PM ******/
CREATE DATABASE [MovieSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MovieSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MovieSystem.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MovieSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MovieSystem_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MovieSystem] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MovieSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MovieSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MovieSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MovieSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MovieSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MovieSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [MovieSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MovieSystem] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MovieSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MovieSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MovieSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MovieSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MovieSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MovieSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MovieSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MovieSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MovieSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MovieSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MovieSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MovieSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MovieSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MovieSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MovieSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MovieSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MovieSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MovieSystem] SET  MULTI_USER 
GO
ALTER DATABASE [MovieSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MovieSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MovieSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MovieSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MovieSystem]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2/24/2021 3:13:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CId] [int] NOT NULL,
	[FName] [varchar](50) NULL,
	[LName] [varchar](50) NULL,
	[CAddress] [varchar](50) NULL,
	[CPhoneNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Listmovies]    Script Date: 2/24/2021 3:13:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Listmovies](
	[RentalMoviesId] [int] NOT NULL,
	[MoviesTitle] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movies]    Script Date: 2/24/2021 3:13:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Movies](
	[MoviesId] [int] NOT NULL,
	[MTitle] [varchar](50) NULL,
	[MRating] [int] NULL,
	[Mcopies] [int] NULL,
	[Mgenre] [varchar](50) NULL,
	[Mplot] [varchar](50) NULL,
	[MCost] [money] NULL,
	[MRelaseDate] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MoviesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RentalMovies]    Script Date: 2/24/2021 3:13:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RentalMovies](
	[RentalMoviesId] [int] NOT NULL,
	[MoviesId] [int] NULL,
	[CId] [int] NULL,
	[RentalDate] [varchar](50) NULL,
	[ReturnDate] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[RentalMoviesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Customer] ([CId], [FName], [LName], [CAddress], [CPhoneNo]) VALUES (1, N'james', N'jack', N'43 lantk', 683745)
INSERT [dbo].[Customer] ([CId], [FName], [LName], [CAddress], [CPhoneNo]) VALUES (2, N'rojer', N'raj', N'92 jam street', 195321)
INSERT [dbo].[Customer] ([CId], [FName], [LName], [CAddress], [CPhoneNo]) VALUES (3, N'peter', N'kons', N'11 walton road', 762345)
INSERT [dbo].[Customer] ([CId], [FName], [LName], [CAddress], [CPhoneNo]) VALUES (4, N'kane', N'den', N'47 west garden', 734954)
INSERT [dbo].[Customer] ([CId], [FName], [LName], [CAddress], [CPhoneNo]) VALUES (5, N'rodis', N'rak', N'23 thom park', 429463)
INSERT [dbo].[Customer] ([CId], [FName], [LName], [CAddress], [CPhoneNo]) VALUES (6, N'thoms', N'jhons', N'29 glow palp', 612954)
INSERT [dbo].[Customer] ([CId], [FName], [LName], [CAddress], [CPhoneNo]) VALUES (7, N'stephan', N'hokin', N'62 judal city', 523913)
INSERT [dbo].[Customer] ([CId], [FName], [LName], [CAddress], [CPhoneNo]) VALUES (8, N'flain', N'tozer', N'84 street ', 148295)
INSERT [dbo].[Listmovies] ([RentalMoviesId], [MoviesTitle]) VALUES (1, N'avengers  ')
INSERT [dbo].[Listmovies] ([RentalMoviesId], [MoviesTitle]) VALUES (2, N'friend req')
INSERT [dbo].[Listmovies] ([RentalMoviesId], [MoviesTitle]) VALUES (3, N'might fall')
INSERT [dbo].[Listmovies] ([RentalMoviesId], [MoviesTitle]) VALUES (4, N'demon     ')
INSERT [dbo].[Listmovies] ([RentalMoviesId], [MoviesTitle]) VALUES (5, N'nightmare ')
INSERT [dbo].[Listmovies] ([RentalMoviesId], [MoviesTitle]) VALUES (6, N'Snitch    ')
INSERT [dbo].[Movies] ([MoviesId], [MTitle], [MRating], [Mcopies], [Mgenre], [Mplot], [MCost], [MRelaseDate]) VALUES (1, N'Aquera', 6, 36, N'horror', N'fight against monster', 2.0000, N'8-10-2016')
INSERT [dbo].[Movies] ([MoviesId], [MTitle], [MRating], [Mcopies], [Mgenre], [Mplot], [MCost], [MRelaseDate]) VALUES (2, N'jurick park', 9, 65, N'action', N'dianusor come again', 5.0000, N'27-8-2020')
INSERT [dbo].[Movies] ([MoviesId], [MTitle], [MRating], [Mcopies], [Mgenre], [Mplot], [MCost], [MRelaseDate]) VALUES (3, N'Start hight', 5, 12, N'adventure', N'action against ', 5.0000, N'11-8-2019')
INSERT [dbo].[Movies] ([MoviesId], [MTitle], [MRating], [Mcopies], [Mgenre], [Mplot], [MCost], [MRelaseDate]) VALUES (4, N'Frind request', 3, 34, N'comedy', N'get request and the see some thing', 2.0000, N'17-2-2012')
INSERT [dbo].[Movies] ([MoviesId], [MTitle], [MRating], [Mcopies], [Mgenre], [Mplot], [MCost], [MRelaseDate]) VALUES (5, N'Parsight', 7, 54, N'superhero', N'story of fight against friends', 5.0000, N'22-2-2015')
INSERT [dbo].[RentalMovies] ([RentalMoviesId], [MoviesId], [CId], [RentalDate], [ReturnDate]) VALUES (1, 3, 4, N'17-2-2021', N'18--2021')
INSERT [dbo].[RentalMovies] ([RentalMoviesId], [MoviesId], [CId], [RentalDate], [ReturnDate]) VALUES (2, 1, 2, N'18-2-2021', N'')
INSERT [dbo].[RentalMovies] ([RentalMoviesId], [MoviesId], [CId], [RentalDate], [ReturnDate]) VALUES (3, 5, 3, N'22-2-2021', N'')
INSERT [dbo].[RentalMovies] ([RentalMoviesId], [MoviesId], [CId], [RentalDate], [ReturnDate]) VALUES (4, 2, 5, N'25-2-2021', N'25-2-2021')
INSERT [dbo].[RentalMovies] ([RentalMoviesId], [MoviesId], [CId], [RentalDate], [ReturnDate]) VALUES (5, 5, 1, N'28-2-2021', N'28-2-2021')
INSERT [dbo].[RentalMovies] ([RentalMoviesId], [MoviesId], [CId], [RentalDate], [ReturnDate]) VALUES (6, 1, 4, N'28-2-2021', N'')
ALTER TABLE [dbo].[Listmovies]  WITH CHECK ADD  CONSTRAINT [FK_Listmovies_RentalMovies] FOREIGN KEY([RentalMoviesId])
REFERENCES [dbo].[RentalMovies] ([RentalMoviesId])
GO
ALTER TABLE [dbo].[Listmovies] CHECK CONSTRAINT [FK_Listmovies_RentalMovies]
GO
ALTER TABLE [dbo].[RentalMovies]  WITH CHECK ADD  CONSTRAINT [FK_Table_Customer] FOREIGN KEY([CId])
REFERENCES [dbo].[Customer] ([CId])
GO
ALTER TABLE [dbo].[RentalMovies] CHECK CONSTRAINT [FK_Table_Customer]
GO
ALTER TABLE [dbo].[RentalMovies]  WITH CHECK ADD  CONSTRAINT [FK_Table_Movies] FOREIGN KEY([MoviesId])
REFERENCES [dbo].[Movies] ([MoviesId])
GO
ALTER TABLE [dbo].[RentalMovies] CHECK CONSTRAINT [FK_Table_Movies]
GO
USE [master]
GO
ALTER DATABASE [MovieSystem] SET  READ_WRITE 
GO
