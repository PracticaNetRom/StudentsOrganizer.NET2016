CREATE TABLE Events(

	ID int Primary Key not null,
	Event_Name varchar(30) not null,
	Technology varchar(30) not null,
	Task varchar(100) not null,

);


insert into Events ( ID, Event_Name, Technology, Task)
Values (1, 'Netrom Summer Camp', 'DotNet', 'Application');

select *from Events;