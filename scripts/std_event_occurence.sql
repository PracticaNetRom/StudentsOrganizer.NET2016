USE [NetRom.Practice1]
GO

/****** Object:  Table [dbo].[Std_Event_Occurence]    Script Date: 7/8/2016 11:36:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Std_Event_Occurence](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Student] [int] NOT NULL,
	[Id_Event_Occurence] [int] NOT NULL,
 CONSTRAINT [PK_Std_Event_Occurence_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Std_Event_Occurence]  WITH CHECK ADD  CONSTRAINT [FK_Std_Event_Occurence_Students] FOREIGN KEY([Id_Student])
REFERENCES [dbo].[Students] ([Id])
GO

ALTER TABLE [dbo].[Std_Event_Occurence] CHECK CONSTRAINT [FK_Std_Event_Occurence_Students]
GO

