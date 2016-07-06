DROP TABLE eveniment;
CREATE TABLE eveniment(
	IdEvent Integer PRIMARY KEY IDENTITY (1,1), 
	EventName varchar(20),
	Departament varchar(30),
	Task varchar(60),
);
DROP TABLE login;
CREATE TABLE login(
	NumeUtilizator varchar(20),
	ParolaUtilizator varchar(20),
	Roll varchar(20),
);


DROP TABLE student;
CREATE TABLE student(
	IdStudent integer PRIMARY KEY IDENTITY (1,1),
	FirstName varchar(30),
	LastName varchar(20),
	Gender varchar(1),
	BirthDate date,
	Email varchar(50),
	PhoneNumbers varchar(30),
	PhoneHomeNumbers varchar(30),
	FacultyStartYear integer,
	Faculty varchar(50),
	Remarks varchar(100),
);

DROP TABLE student_period_event;
CREATE TABLE student_period_event(
	IdStudent integer,
	IdStudentOccurence integer,
);

DROP TABLE student_event_occurence;
CREATE TABLE student_event_occurence(
	Id integer PRIMARY KEY IDENTITY(1,1),
	IdEvent integer,
	DateStart date,
	DateEnd date,
);

alter table student_period_event add constraint FK_student_period_event_student foreign key(IdStudent) references student(IdStudent);
alter table student_event_occurence add constraint FK_student_event_occurence_event foreign key(IdEvent) references eveniment(IdEvent);
alter table student_period_event add constraint FK_student_event_occurence_student_period_event foreign key(IdStudentOccurence) references student_event_occurence(Id);


SELECT * FROM login;
SELECT * FROM student;
SELECT * FROM eveniment;
SELECT * FROM student_period_event;
SELECT * FROM student_event_occurence;

DECLARE @FirstName varchar(30)='Dragos'
DECLARE @LastName varchar(20)='Puscu'


UPDATE student Set FirstName='Viorel', LastName='Bogdan' WHERE IdStudent='1';



INSERT INTO login(NumeUtilizator,ParolaUtilizator,Roll) VALUES('Dragos','Puscu','ADMIN');
INSERT INTO login(NumeUtilizator,ParolaUtilizator,Roll) VALUES('admin','admin','Client');

INSERT INTO student_period_event(IdStudent,IdStudentOccurence) VALUES('1','2');
INSERT INTO student_period_event(IdStudent,IdStudentOccurence) VALUES('2','1');
INSERT INTO student_period_event(IdStudent,IdStudentOccurence) VALUES('1','3');

INSERT INTO student_event_occurence(IdEvent,DateStart,DateEnd) VALUES('1','6/27/2016','7/15/2016');
INSERT INTO student_event_occurence(IdEvent,DateStart,DateEnd) VALUES('2','6/27/2016','7/15/2016');
INSERT INTO student_event_occurence(IdEvent,DateStart,DateEnd) VALUES('3','6/27/2016','7/15/2016');

INSERT INTO eveniment(EventName,Departament,Task) VALUES('Practica','Informatica','Crearea si instantierea unei baze de date');
INSERT INTO eveniment(EventName,Departament,Task) VALUES('Intership','Informatica','Crearea si instantierea unei baze de date');
INSERT INTO eveniment(EventName,Departament,Task) VALUES('Practica','Calculatoare-romana','Crearea si instantierea unei baze de date');

INSERT INTO student(FirstName,LastName,Gender,BirthDate,Email,PhoneNumbers,PhoneHomeNumbers,FacultyStartYear,Faculty,Remarks) VALUES('Dragos','Puscu','M','9/5/1995','psucu.dragos@yahoo.com','0761511179','0251451209','2014','Universitatea din Craiova','Anul II');
INSERT INTO student(FirstName,LastName,Gender,BirthDate,Email,PhoneNumbers,PhoneHomeNumbers,FacultyStartYear,Faculty,Remarks) VALUES('George','Puscu','M','7/11/1991','psucu.alex@yahoo.com','0762997626','0251451209','2008','Universitatea din Craiova','A dinalizat studiile');


SELECT *,eveniment.EventName,student_event_occurence.DateStart,student_event_occurence.DateEnd from student,eveniment,student_event_occurence;

SELECT student.FirstName,student.LastName,eveniment.EventName,student_event_occurence.DateStart,student_event_occurence.DateEnd from student 
JOIN student_period_event ON student.IdStudent=student_period_event.IdStudent
JOIN student_event_occurence ON student_period_event.IdStudentOccurence=student_event_occurence.Id
JOIN eveniment ON student_event_occurence.IdEvent=eveniment.IdEvent;