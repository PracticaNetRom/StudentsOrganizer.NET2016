USE [NetRom.Practice1]
GO

/****** Object:  Table [dbo].[Event_Occurence]    Script Date: 6/30/2016 7:48:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Event_Occurence](
	[Id] [int] NOT NULL,
	[Id_event] [int] NOT NULL,
	[Start date] [varchar](50) NOT NULL,
	[End date] [varchar](50) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

