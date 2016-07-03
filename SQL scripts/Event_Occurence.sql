Drop table Event_Occurence;

CREATE TABLE Event_Occurence(

	ID int Primary key not null IDENTITY (1,1),
	EventsId int not null,
	Start date not null,
	Finish date not null, 
);
select *from Event_Occurence;

alter table Event_Occurence add constraint Event_Occurence_EventsId_FK
Foreign Key (EventsId) references Events(ID);

Insert into Event_Occurence ( EventsId, Start, Finish)
Values ( 1, '2016-06-27', '2016-07-15');
Insert into Event_Occurence ( EventsId, Start, Finish)
Values ( 2,  '2016-07-20', '2016-08-27');

select *from Event_Occurence;