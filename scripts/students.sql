USE [NetRom.Practice1]
GO

/****** Object:  Table [dbo].[Students]    Script Date: 7/8/2016 11:37:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First name] [varchar](50) NOT NULL,
	[Last name] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Birth date] [date] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Phone number] [varchar](50) NOT NULL,
	[Faculty] [varchar](50) NOT NULL,
	[Faculty start year] [int] NOT NULL,
	[Remarks] [varchar](50) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

