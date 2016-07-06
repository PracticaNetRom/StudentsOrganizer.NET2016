DROP TABLE event;
CREATE TABLE event(
	IdEvent Integer PRIMARY KEY, 
	EventName varchar(20),
	Departament varchar(30),
	Task varchar(60),
);

DROP TABLE student;
CREATE TABLE student(
	IdStudent integer PRIMARY KEY,
	FirstName varchar(30),
	LastName varchar(20),
	Gender varchar(1),
	BirthDate date,
	Email varchar(50),
	PhoneNumbers integer,
	PhoneHomeNumbers integer,
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
	Id integer PRIMARY KEY,
	IdEvent integer,
	DateStart date,
	DateEnd date,
);

alter table student_period_event add constraint FK_student_period_event_student foreign key(IdStudent) references student(IdStudent);
alter table student_event_occurence add constraint FK_student_event_occurence_event foreign key(IdEvent) references event(IdEvent);
alter table student_period_event add constraint FK_student_event_occurence_student_period_event foreign key(IdStudentOccurence) references student_event_occurence(Id);



SELECT * FROM student;
SELECT * FROM event;
SELECT * FROM student_period_event;
SELECT * FROM student_event_occurence;


INSERT INTO student_period_event(IdStudent,IdStudentOccurence) VALUES('1','2');
INSERT INTO student_period_event(IdStudent,IdStudentOccurence) VALUES('2','1');

INSERT INTO student_event_occurence(Id,IdEvent,DateStart,DateEnd) VALUES('2','1','6/27/2016','7/15/2016');
INSERT INTO student_event_occurence(Id,IdEvent,DateStart,DateEnd) VALUES('1','2','6/27/2016','7/15/2016');

INSERT INTO event(IdEvent,EventName,Departament,Task) VALUES('1','Practica','Informatica','Crearea si instantierea unei baze de date');
INSERT INTO event(IdEvent,EventName,Departament,Task) VALUES('2','Practica','Calculatoare-romana','Crearea si instantierea unei baze de date');

INSERT INTO student(IdStudent,FirstName,LastName,Gender,BirthDate,Email,PhoneNumbers,PhoneHomeNumbers,FacultyStartYear,Faculty,Remarks) VALUES('1','Dragos','Puscu','M','9/5/1995','psucu.dragos@yahoo.com','0761511179','0251451209','2014','Universitatea din Craiova','Anul II');
INSERT INTO student(IdStudent,FirstName,LastName,Gender,BirthDate,Email,PhoneNumbers,PhoneHomeNumbers,FacultyStartYear,Faculty,Remarks) VALUES('2','George','Puscu','M','7/11/1991','psucu.alex@yahoo.com','0762997626','0251451209','2008','Universitatea din Craiova','A dinalizat studiile');