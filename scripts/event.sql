USE [NetRom.Practice1]
GO

/****** Object:  Table [dbo].[Event]    Script Date: 6/30/2016 7:47:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Event](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Task] [varchar](50) NOT NULL,
	[Departament/Technology] [varchar](50) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

