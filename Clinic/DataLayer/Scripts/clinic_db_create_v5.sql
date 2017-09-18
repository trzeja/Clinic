USE [master]
GO
/****** Object:  Database [clinic]    Script Date: 08/04/2017 16:26:04 ******/
CREATE DATABASE [clinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'przychodnia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\przychodnia.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'przychodnia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\przychodnia_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [clinic] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [clinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [clinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [clinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [clinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [clinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [clinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [clinic] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [clinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [clinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [clinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [clinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [clinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [clinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [clinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [clinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [clinic] SET  ENABLE_BROKER 
GO
ALTER DATABASE [clinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [clinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [clinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [clinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [clinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [clinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [clinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [clinic] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [clinic] SET  MULTI_USER 
GO
ALTER DATABASE [clinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [clinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [clinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [clinic] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [clinic] SET DELAYED_DURABILITY = DISABLED 
GO
USE [clinic]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 08/04/2017 16:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[id_patient] [int] IDENTITY(1,1) NOT NULL,
	[place] [nvarchar](50) NOT NULL,
	[street] [nvarchar](50) NULL,
	[zip_code] [nvarchar](50) NOT NULL,
	[house] [nvarchar](10) NOT NULL,
	[flat] [nvarchar](10) NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[id_patient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 08/04/2017 16:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[id_doc] [int] IDENTITY(1,1) NOT NULL,
	[medical_right_no] [nvarchar](20) NULL,
	[user_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Doctor__D5EAB26CD1F8E864] PRIMARY KEY CLUSTERED 
(
	[id_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Examination_dictionary]    Script Date: 08/04/2017 16:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examination_dictionary](
	[code] [int] NOT NULL,
	[type] [nchar](1) NOT NULL,
	[name] [nvarchar](254) NOT NULL,
 CONSTRAINT [PK__Examinat__357D4CF812DF778B] PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Laboratory_examination]    Script Date: 08/04/2017 16:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laboratory_examination](
	[id_laboratory_examination] [int] IDENTITY(1,1) NOT NULL,
	[order_date] [datetime] NOT NULL,
	[examination_execution_date] [datetime] NULL,
	[examination_approval_date] [datetime] NULL,
	[doctor_comments] [nvarchar](254) NULL,
	[result] [nvarchar](254) NULL,
	[lab_manager_comments] [nvarchar](254) NULL,
	[state] [nvarchar](50) NOT NULL,
	[id_visit] [int] NOT NULL,
	[id_laboratory_woker] [int] NULL,
	[id_laboratory_manager] [int] NULL,
	[code] [int] NOT NULL,
 CONSTRAINT [PK__Laborato__E8C8FB5CB43B68B7] PRIMARY KEY CLUSTERED 
(
	[id_laboratory_examination] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Laboratory_manager]    Script Date: 08/04/2017 16:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laboratory_manager](
	[id_laboratory_manager] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Lab_M__672119138C983300] PRIMARY KEY CLUSTERED 
(
	[id_laboratory_manager] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Laboratory_worker]    Script Date: 08/04/2017 16:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laboratory_worker](
	[id_laboratory_worker] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Lab__6CCAEB78BBE47446] PRIMARY KEY CLUSTERED 
(
	[id_laboratory_worker] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patient]    Script Date: 08/04/2017 16:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[id_patient] [int] IDENTITY(1,1) NOT NULL,
	[fname] [nvarchar](50) NOT NULL,
	[lname] [nvarchar](50) NOT NULL,
	[PESEL] [nchar](11) NOT NULL,
 CONSTRAINT [PK__Patient__6FCA2A6C66F89CAB] PRIMARY KEY CLUSTERED 
(
	[id_patient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Physical_examination]    Script Date: 08/04/2017 16:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Physical_examination](
	[id_physical_examination] [int] IDENTITY(1,1) NOT NULL,
	[result] [nvarchar](254) NULL,
	[execution_datetime] [datetime] NULL,
	[id_visit] [int] NOT NULL,
	[code] [int] NOT NULL,

 CONSTRAINT [PK__Physical__7ADFB9463D61CFEA] PRIMARY KEY CLUSTERED 
(
	[id_physical_examination] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Registration]    Script Date: 08/04/2017 16:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[id_registration] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [nvarchar](50) NULL,
 CONSTRAINT [PK__Registra__6ABE6F0C97644492] PRIMARY KEY CLUSTERED 
(
	[id_registration] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 08/04/2017 16:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_name] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[retire_date] [datetime] NULL,
	[roles] [nvarchar](50) NOT NULL,
	[lname] [nvarchar](50) NOT NULL,
	[fname] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__User__7C9273C5B28F82DD] PRIMARY KEY CLUSTERED 
(
	[user_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Visit]    Script Date: 08/04/2017 16:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit](
	[id_visit] [int] IDENTITY(1,1) NOT NULL,
	[description] [nvarchar](254) NOT NULL,
	[diagnosis] [nvarchar](254) NULL,
	[state] [nvarchar](50) NOT NULL,
	[registration_date] [datetime] NOT NULL,
	[execution_cancel_datetime] [datetime] NULL,
	[id_patient] [int] NOT NULL,
	[id_registration] [int] NOT NULL,
	[id_doctor] [int] NOT NULL,
 CONSTRAINT [PK__Visit__26798FF0B29374AC] PRIMARY KEY CLUSTERED 
(
	[id_visit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Patient] FOREIGN KEY([id_patient])
REFERENCES [dbo].[Patient] ([id_patient])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Patient]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_User] FOREIGN KEY([user_name])
REFERENCES [dbo].[User] ([user_name])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_User]
GO
ALTER TABLE [dbo].[Laboratory_examination]  WITH CHECK ADD  CONSTRAINT [FK_Laboratory_examination_Examination_dictionary] FOREIGN KEY([code])
REFERENCES [dbo].[Examination_dictionary] ([code])
GO
ALTER TABLE [dbo].[Laboratory_examination] CHECK CONSTRAINT [FK_Laboratory_examination_Examination_dictionary]
GO
ALTER TABLE [dbo].[Laboratory_examination]  WITH CHECK ADD  CONSTRAINT [FK_Laboratory_examination_Lab] FOREIGN KEY([id_laboratory_woker])
REFERENCES [dbo].[Laboratory_worker] ([id_laboratory_worker])
GO
ALTER TABLE [dbo].[Laboratory_examination] CHECK CONSTRAINT [FK_Laboratory_examination_Lab]
GO
ALTER TABLE [dbo].[Laboratory_examination]  WITH CHECK ADD  CONSTRAINT [FK_Laboratory_examination_Lab_M] FOREIGN KEY([id_laboratory_manager])
REFERENCES [dbo].[Laboratory_manager] ([id_laboratory_manager])
GO
ALTER TABLE [dbo].[Laboratory_examination] CHECK CONSTRAINT [FK_Laboratory_examination_Lab_M]
GO
ALTER TABLE [dbo].[Laboratory_examination]  WITH CHECK ADD  CONSTRAINT [FK_Laboratory_examination_Visit] FOREIGN KEY([id_visit])
REFERENCES [dbo].[Visit] ([id_visit])
GO
ALTER TABLE [dbo].[Laboratory_examination] CHECK CONSTRAINT [FK_Laboratory_examination_Visit]
GO
ALTER TABLE [dbo].[Laboratory_manager]  WITH CHECK ADD  CONSTRAINT [FK_Lab_M_User] FOREIGN KEY([user_name])
REFERENCES [dbo].[User] ([user_name])
GO
ALTER TABLE [dbo].[Laboratory_manager] CHECK CONSTRAINT [FK_Lab_M_User]
GO
ALTER TABLE [dbo].[Laboratory_worker]  WITH CHECK ADD  CONSTRAINT [FK_Lab_User] FOREIGN KEY([user_name])
REFERENCES [dbo].[User] ([user_name])
GO
ALTER TABLE [dbo].[Laboratory_worker] CHECK CONSTRAINT [FK_Lab_User]
GO
ALTER TABLE [dbo].[Physical_examination]  WITH CHECK ADD  CONSTRAINT [FK_Physical_examination_Examination_dictionary] FOREIGN KEY([code])
REFERENCES [dbo].[Examination_dictionary] ([code])
GO
ALTER TABLE [dbo].[Physical_examination] CHECK CONSTRAINT [FK_Physical_examination_Examination_dictionary]
GO
ALTER TABLE [dbo].[Physical_examination]  WITH CHECK ADD  CONSTRAINT [FK_Physical_examination_Visit] FOREIGN KEY([id_visit])
REFERENCES [dbo].[Visit] ([id_visit])
GO
ALTER TABLE [dbo].[Physical_examination] CHECK CONSTRAINT [FK_Physical_examination_Visit]
GO
ALTER TABLE [dbo].[Registration]  WITH CHECK ADD  CONSTRAINT [FK_Registration_User] FOREIGN KEY([user_name])
REFERENCES [dbo].[User] ([user_name])
GO
ALTER TABLE [dbo].[Registration] CHECK CONSTRAINT [FK_Registration_User]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Doctor] FOREIGN KEY([id_doctor])
REFERENCES [dbo].[Doctor] ([id_doc])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Doctor]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Patient] FOREIGN KEY([id_patient])
REFERENCES [dbo].[Patient] ([id_patient])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Patient]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Registration] FOREIGN KEY([id_registration])
REFERENCES [dbo].[Registration] ([id_registration])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Registration]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [CK_Visit] CHECK  (([state]='DONE' OR [state]='CANC' OR [state]='REG'))
GO
ALTER TABLE [dbo].[Examination_dictionary]  WITH CHECK ADD CONSTRAINT [CK_Examination_dictionary] CHECK  (([type]='L' OR [type]='P'))
GO
ALTER TABLE [dbo].[Laboratory_examination]  WITH CHECK ADD  CONSTRAINT [CK_Laboratory_examination] CHECK  (([state]='DONE' OR [state]='ORD' OR [state]='CANC_LABW' OR [state]='APP' OR [state]='CANC_LABM'))
GO
ALTER TABLE [dbo].[Laboratory_examination] CHECK CONSTRAINT [CK_Laboratory_examination]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [CK_User] CHECK  (([roles]='DOC' OR [roles]='REG' OR [roles]='LABM' OR [roles]='LABW' OR [roles]='ADM'))
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [CK_User]
GO
USE [master]
GO
ALTER DATABASE [clinic] SET  READ_WRITE 
GO
