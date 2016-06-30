CREATE TABLE Students(

   ID   Integer PRIMARY KEY NOT NULL,
   First_Name varchar (30)  NOT NULL,
   Last_Name varchar (30)  NOT NULL,
   Gender varchar (30)  NOT NULL,
   Birth_Date date NOT NULL,
   Email varchar(30) NOT NULL,
   Phone_number int NOT NULL,
   Faculty varchar (50)  NOT NULL,
   Faculty_Start_Year int NOT NULL,
   EventsId int NOT NULL,
   Stud_Event_OccurenceId int Not null,
   Remarks varchar(100)
  
         
);

select *from Students;

alter table Students add constraint Students_EventsId_FK
Foreign Key (EventsId) references Events(ID);

alter table Students add constraint Students_Stud_Event_OccurenceId_FK
Foreign Key (Stud_Event_OccurenceId) references Stud_Event_Occurence(ID);

INSERT INTO Students ( ID, First_Name ,Last_Name, Gender, Birth_Date, Email, Phone_number, Faculty, Faculty_Start_Year, EventsId, Stud_Event_OccurenceId)
VALUES ( 1, 'Roxana Alina', 'Marin', 'Female', '22/06/1994', 'marin.roxana07@gmail.com', 0756034678, 'Facultatea de Automatica, Calculatoare si Electronica', 
		2013, 1, 1);