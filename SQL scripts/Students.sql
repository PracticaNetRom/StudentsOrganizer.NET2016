drop table Students;

CREATE TABLE Students(

   ID   Integer PRIMARY KEY NOT NULL IDENTITY (1,1),
   First_Name varchar (30)  NOT NULL,
   Last_Name varchar (30)  NOT NULL,
   Gender varchar (30)  NOT NULL,
   Birth_Date date NOT NULL,
   Email varchar(30) NOT NULL,
   Phone_number int NOT NULL,
   Faculty varchar (100)  NOT NULL,
   Faculty_Start_Year int NOT NULL,
   Remarks varchar(100)
  
         
);





INSERT INTO Students ( 
First_Name ,
Last_Name, 
Gender, 
Birth_Date, 
Email, 
Phone_number, 
Faculty, 
Faculty_Start_Year)
VALUES ( 'Roxana Alina',
 'Marin', 
 'Female', 
'1994-06-22', 
'marin.roxana07@gmail.com', 
0756034678, 
'Facultatea de Automatica, Calculatoare si Electronica', 
2013);

INSERT INTO Students ( 
First_Name ,
Last_Name, 
Gender, 
Birth_Date, 
Email, 
Phone_number, 
Faculty, 
Faculty_Start_Year)
VALUES ( 'Dragos',
 'Puscu', 
 'Male', 
'1994-06-22', 
'marin.roxana07@gmail.com', 
0756034678, 
'Universitatea din Craiova', 
2013);

select *from Students;

SELECT  Students.First_Name , Students.Last_Name, Events.Event_name , Event_Occurence.Start,
 Event_Occurence.Finish 
FROM  Students
 JOIN Stud_Event_Occurence
 ON Students.ID = Stud_Event_Occurence.StudentsId
 JOIN Event_Occurence
 ON Stud_Event_Occurence.Event_OccurenceId = Event_Occurence.EventsId
 JOIN Events
 ON Event_Occurence.EventsId = Events.ID