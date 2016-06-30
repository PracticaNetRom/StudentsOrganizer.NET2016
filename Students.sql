USE [NetRom.Practice2]
GO

INSERT INTO [dbo].[Students]
           ([ID]
           ,[FirstName]
           ,[LastName]
           ,[Gender]
           ,[BirthDate]
           ,[Email]
           ,[PhoneNumber]
           ,[FacultyStartYear])
     VALUES
           (<ID, int,>
           ,<FirstName, ntext,>
           ,<LastName, ntext,>
           ,<Gender, nchar(10),>
           ,<BirthDate, datetime,>
           ,<Email, nchar(10),>
           ,<PhoneNumber, numeric(18,0),>
           ,<FacultyStartYear, int,>)
GO


INSERT INTO Students(ID,FirstName,LastName,Gender,BirthDate,Email,PhoneNumber,FacultyStartYear)
VALUES ('1','Serban','Andra','F','20.11.1995','andra.serban2095@gmail.com','0767408854','2014');