USE [NetRom.Practice2]
GO

INSERT INTO [dbo].[Event]
           ([Name]
           ,[TaskReceived]
           ,[Departament/Technology])
     VALUES
           (<Name, varchar(50),>
           ,<TaskReceived, varchar(50),>
           ,<Departament/Technology, varchar(50),>)
GO


Delete  from Event_occurence;