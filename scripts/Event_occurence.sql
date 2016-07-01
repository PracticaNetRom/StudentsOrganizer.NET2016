USE [NetRom.Practice2]
GO

/****** Object:  Table [dbo].[Event_occurence]    Script Date: 7/1/2016 10:12:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Event_occurence](
	[ID] [int] NULL,
	[ID_Event] [int] NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL
) ON [PRIMARY]

GO

