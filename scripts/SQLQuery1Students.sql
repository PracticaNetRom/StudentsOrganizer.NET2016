DELETE FROM Students;

INSERT INTO Students (FirstName,LastName,Gender,BirthDate,Email,PhoneNumber,Faculty,FacultyStartYear,Remarks)
VALUES ('Ana','Marin','F','10/4/1996','anamaria@yahoo.com',0767859812,'ACE',2014,'bursiera');

INSERT INTO Students (FirstName,LastName,Gender,BirthDate,Email,PhoneNumber,Faculty,FacultyStartYear,Remarks)
VALUES ('Maria','Marin','F','10/4/1996','maria@yahoo.com',0758859812,'ACE',2014,'bursiera');

INSERT INTO Students (FirstName,LastName,Gender,BirthDate,Email,PhoneNumber,Faculty,FacultyStartYear,Remarks)
VALUES ('Anca','Stefan','F','13/5/1995','anca@yahoo.com',0767859012,'UCV',2013,'restanta');

INSERT INTO Students (FirstName,LastName,Gender,BirthDate,Email,PhoneNumber,Faculty,FacultyStartYear,Remarks)
VALUES ('Stefan','Citu','M','27/5/1996','stefan@yahoo.com',0767235698,'UCV',2014,'bursier');

SELECT * FROM Students;