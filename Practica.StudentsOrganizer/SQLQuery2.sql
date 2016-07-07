DROP TABLE Student;
CREATE TABLE Student (
	id INT PRIMARY KEY IDENtity(1,1),
	firstName varchar(40),
	lastName varchar(40),
	gender varchar(1),
	birthDate date,
	email varchar(30),
	phoneNumber varchar(30),
	faculty varchar(30),
	facultyStartYear integer,
	remarks varchar(200));
ALTER TABLE Student
ADD PRIMARY KEY (id) 

DROP TABLE Eveniment;
CREATE TABLE Eveniment(
	id INT PRIMARY KEY IDENtity(1,1),
	eventName varchar(40),
	task varchar(60),
	departamentOrTehnology varchar(40) );
ALTER TABLE Eveniment
ADD PRIMARY KEY (id) 



DROP TABLE EventOccurence;
CREATE TABLE EventOccurence(
	id INT PRIMARY KEY IDENtity(1,1) ,
	idEvent integer,
	startData date,
	endData date); 


DROP TABLE StudentEventOccurence;
CREATE TABLE StudentEventOccurence(
	id INT PRIMARY KEY IDENtity(1,1),
	idStudent integer,
	idEventOccurence integer);

DECLARE @firstName VARCHAR(40) = 'ion'


INSERT INTO Student(firstName, lastName, gender, birthDate, email, phoneNumber, faculty, facultyStartYear, remarks)
		VALUES('Ion', 'Popescu', 'M', '2/4/1995', 'popescu@yahoo.com', '0251765398', 'Automatica', '2014', 'Abilitati de dezvoltare personala rapida');
INSERT INTO Student(firstName, lastName, gender, birthDate, email, phoneNumber, faculty, facultyStartYear, remarks)
		VALUES('Dana', 'Ionescu', 'F', '5/8/1996', 'ionescudana@yahoo.com', '0254309432', 'Universitate', '2015', 'Nicio remarca');
INSERT INTO Student(firstName, lastName, gender, birthDate, email, phoneNumber, faculty, facultyStartYear, remarks)
		VALUES('Corina', 'Florescu', 'F', '7/12/1995', 'florescu@yahoo.com', '0243057354', 'Universitate', '2014', 'Bune cunostinte de C#');
INSERT INTO Student(firstName, lastName, gender, birthDate, email, phoneNumber, faculty, facultyStartYear, remarks) 
		VALUES('Florian', 'Dumitrescu', 'M', '9/10/1995', 'dumi@yahoo.com', '0987068362', 'Automatica', '2014', 'Impresionante abilitati intelectuale');


INSERT INTO Eveniment(eventName, task, departamentOrTehnology) 
		VALUES('Practica', 'Aplicatie', 'C');
INSERT INTO Eveniment(eventName, task, departamentOrTehnology)
		VALUES('Intership', 'Program', 'C++');
INSERT INTO Eveniment(eventName, task, departamentOrTehnology) 
		VALUES('Academie', 'Training', 'C#');


INSERT INTO EventOccurence(idEvent, startData, endData)
		VALUES ('5', '3/6/2013', '9/7/2013');
INSERT INTO EventOccurence(idEvent, startData, endData)
		VALUES ('6', '6/8/2014', '3/10/2014');
INSERT INTO EventOccurence(idEvent, startData, endData) 
		VALUES ('7', '12/8/2015', '8/10/2015');
INSERT INTO EventOccurence(idEvent, startData, endData) 
		VALUES ('8', '9/11/2015', '2/12/2015');
     

INSERT INTO StudentEventOccurence(idStudent, idEventOccurence) VALUES('1', '8');
INSERT INTO StudentEventOccurence(idStudent, idEventOccurence) VALUES('2', '9');
INSERT INTO StudentEventOccurence(idStudent, idEventOccurence) VALUES('3', '10');
INSERT INTO StudentEventOccurence(idStudent, idEventOccurence) VALUES('2', '11');

SELECT * FROM Student;
SELECT * FROM Eveniment;
SELECT * FROM EventOccurence;
SELECT * FROM StudentEventOccurence;


SELECT DATEPART(yyyy,startData) AS OrderYear
FROM EventOccurence;


SELECT firstName, lastName, eventName, EventOccurence.startData, EventOccurence.endData
FROM Student
JOIN StudentEventOccurence
ON Student.id=StudentEventOccurence.idStudent
JOIN EventOccurence
ON EventOccurence.id=StudentEventOccurence.idEventOccurence
JOIN Eveniment
ON Eveniment.id=EventOccurence.idEvent

