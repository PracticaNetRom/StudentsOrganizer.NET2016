USE [NetRom.Practice1]
GO

/****** Object:  Table [dbo].[Event_Occurence]    Script Date: 7/8/2016 11:36:34 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Event_Occurence](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_event] [int] NOT NULL,
	[Start date] [date] NOT NULL,
	[End date] [date] NOT NULL,
 CONSTRAINT [PK_Event_Occurence] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Event_Occurence]  WITH CHECK ADD  CONSTRAINT [FK_Event_Occurence_Event] FOREIGN KEY([Id_event])
REFERENCES [dbo].[Event] ([Id])
GO

ALTER TABLE [dbo].[Event_Occurence] CHECK CONSTRAINT [FK_Event_Occurence_Event]
GO

