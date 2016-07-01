--DELETE FROM dbo.Event;
--DELETE FROM dbo.Event_Occurence;
DELETE FROM dbo.Std_Event_Occurence;
--DELETE FROM dbo.Students;

INSERT dbo.Students ( [First name], [Last name], Gender, [Birth date], Email, [Phone number],
Faculty, [Faculty start year],Remarks) VALUES ( 'Catalin', 'Stan', 'M', '1994-01-19', 'catastan@yahoo.com',
0712354267, 'Informatica', 2012, 'bursier')

INSERT dbo.Students ( [First name], [Last name], Gender, [Birth date], Email, [Phone number],
Faculty, [Faculty start year],Remarks) VALUES ( 'Maria', 'Tudoriu', 'F', '1995-06-13', 'marymaria@yahoo.com',
0717367928, 'Automatica', 2013, 'bursier')
 
INSERT dbo.Students ( [First name], [Last name], Gender, [Birth date], Email, [Phone number],
Faculty, [Faculty start year],Remarks) VALUES ( 'Eduard', 'Stefanescu', 'M', '1994-04-23', 'eduardst@yahoo.com',
0742354212, 'Drept', 2012, 'taxa')
 
INSERT dbo.Event ( Name, Task, [Departament/Technology]) VALUES ( 'Practica', 'Students Organizer',
'.NET/Java')

INSERT dbo.Event( Name, Task, [Departament/Technology]) VALUES ( 'Software Academy', 'Problema1',
'C/C++')

INSERT dbo.Event_Occurence ( Id_event, [Start date], [End date]) VALUES ( 1, '2016-06-27', 
'2016-07-15')

INSERT dbo.Event_Occurence ( Id_event, [Start date], [End date]) VALUES ( 2, '2016-09-15', 
'2016-12-15')

--INSERT dbo.Std_Event_Occurence (Id_Student, Id_Event_Occurence) VALUES (1,1)
--INSERT dbo.Std_Event_Occurence (Id_Student, Id_Event_Occurence) VALUES (2,1)
--INSERT dbo.Std_Event_Occurence (Id_Student, Id_Event_Occurence) VALUES (3,2)


 
GO

--SELECT dbo.Students.[First name],dbo.Students.[Last name],dbo.Event.Name,dbo.Event_Occurence.[Start date],
--dbo.Event_Occurence.[End date] FROM dbo.Students,dbo.Event,dbo.Event_Occurence JOIN 
--dbo.Std_Event_Occurence ON dbo.Std_Event_Occurence.Id_Student=
--dbo.Students.Id, dbo.Std_Event_Occurence.Id_Event_Occurence=dbo.Event_Occurence.Id, dbo.Event_Occurence.Id_event=
--dbo.Event.Id;



