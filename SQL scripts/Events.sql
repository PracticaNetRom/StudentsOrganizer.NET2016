Drop table Events;

CREATE TABLE Events(

	ID int Primary Key not null IDENTITY (1,1),
	Event_Name varchar(30) not null,
	Technology varchar(30) not null,
	Task varchar(100) not null,

);


insert into Events (Event_Name, Technology, Task)
Values ('Netrom Summer Camp', 'DotNet', 'Application');
insert into Events (ID, Event_Name, Technology, Task)
Values ('Internship', 'Java', 'Application');

select *from Events;
