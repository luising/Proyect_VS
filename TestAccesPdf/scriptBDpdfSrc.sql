USE [BDpdfSrc]
GO
/****** Object:  Table [dbo].[pdfsrc]    Script Date: 01/31/2018 09:15:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pdfsrc](
	[idPdf] [int] IDENTITY(1,1) NOT NULL,
	[srcPdf] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01/31/2018 09:15:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nUser] [varchar](50) NULL,
	[nPassword] [varchar](50) NULL,
	[Access] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_getUser]    Script Date: 01/31/2018 09:15:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getUser] 
@pUser varchar(50),
@pPassword	varchar(50) 
AS
BEGIN
	SELECT * from Users where nUser = @pUser and nPassword = @pPassword
END
GO
