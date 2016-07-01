USE [NetRom.Practice2]
GO

/****** Object:  Table [dbo].[Students]    Script Date: 7/1/2016 10:11:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Students](
	[ID] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[BirthDate] [date] NULL,
	[Email] [varchar](50) NULL,
	[PhoneNumber] [numeric](18, 0) NULL,
	[Faculty] [varchar](50) NULL,
	[FacultyStartYear] [int] NULL,
	[Remarks] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

