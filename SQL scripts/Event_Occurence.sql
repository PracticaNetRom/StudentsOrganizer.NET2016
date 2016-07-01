Drop table Event_Occurence;

CREATE TABLE Event_Occurence(

	ID int Primary key not null IDENTITY (1,1),
	EventsId int not null,
	Start varchar(15) not null,
	Finish varchar(15) not null, 
);
select *from Event_Occurence;

alter table Event_Occurence add constraint Event_Occurence_EventsId_FK
Foreign Key (EventsId) references Events(ID);

Insert into Event_Occurence ( EventsId, Start, Finish)
Values ( 1, '27/06/2016', '15/07/2016');
Insert into Event_Occurence ( EventsId, Start, Finish)
Values ( 2,  '15/07/2016', '27/08/2016');