Drop table Stud_Event_Occurence;

CREATE TABLE Stud_Event_Occurence(

	ID int Primary Key not null IDENTITY (1,1) , 
	StudentsId int not null,
	Event_OccurenceId int not null,

);
select *from Stud_Event_Occurence;

alter table  Stud_Event_Occurence add constraint Stud_Event_Occurence_Students_FK
Foreign Key (StudentsId) references Students(ID);

alter table  Stud_Event_Occurence add constraint Stud_Event_Occurence_Event_Occurence_FK
Foreign Key (Event_OccurenceId) references Event_Occurence(ID);

Insert INTO Stud_Event_Occurence ( 
StudentsId, 
Event_OccurenceId)
values (1,1);

Insert INTO Stud_Event_Occurence ( 
StudentsId, 
Event_OccurenceId)
values (2, 2);

Insert INTO Stud_Event_Occurence ( 
StudentsId, 
Event_OccurenceId)
values (1, 2);