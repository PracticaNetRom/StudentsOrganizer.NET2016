USE [NetRom.Practice1]
GO

/****** Object:  Table [dbo].[Students]    Script Date: 6/30/2016 7:49:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Students](
	[Id] [int] NOT NULL,
	[First name] [varchar](50) NOT NULL,
	[Last name] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Birth date] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Phone number] [numeric](18, 0) NOT NULL,
	[Faculty] [varchar](50) NOT NULL,
	[Faculty start year] [int] NOT NULL,
	[Remarks] [varchar](50) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

