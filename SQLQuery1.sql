DROP TABLE event;
CREATE TABLE event(
	id Integer PRIMARY KEY, 
	nume varchar(20),
	departament varchar(30),
	task varchar(60),
);

DROP TABLE student;
CREATE TABLE student(
	id integer PRIMARY KEY,
	nume varchar(30),
	facultatea varchar(50),
	remarks varchar(100),
);

DROP TABLE student_period_event;
CREATE TABLE student_period_event(
	id_student integer,
	id_student_ocurrence integer,
);

DROP TABLE student_event_ocurrence;
CREATE TABLE student_event_ocurrence(
	id integer PRIMARY KEY,
	id_event integer,
	date_start date,
	date_end date,
);

SELECT * FROM student;
SELECT * FROM event;
SELECT * FROM student_period_event;
SELECT * FROM student_event_ocurrence;


INSERT INTO event(id,nume,departament,task) VALUES('1','Dragos','informatica','baze de date');