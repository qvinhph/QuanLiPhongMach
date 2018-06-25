/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Nguyễn Công Hoan' ******/

USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLTV')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLTV') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLTV]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLTV]
GO

USE [QLTV]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblDocGia](
	[msdg] [nvarchar](8) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[ngaysinh] [datetime2](7) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[loaidg] [nvarchar](1) NOT NULL,
	[nguoilap] [nvarchar](50) NOT NULL,
	[ngaylapthe] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[msdg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLTV]
GO

INSERT INTO [dbo].[tblDocGia] ([msdg], [hoten], [diachi], [ngaysinh], [email], [loaidg], [nguoilap], [ngaylapthe]) VALUES(N'16000001','Mai Quang Nam','Q1, TP HCM',convert(datetime,'12/30/2000 00:00:00'),'maiquangnam@gmail.com','X','Quang',convert(datetime,'12/30/2000 00:00:00'))


GO