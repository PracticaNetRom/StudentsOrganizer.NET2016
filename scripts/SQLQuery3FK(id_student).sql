ALTER TABLE Student_Event_Occurence
  ADD CONSTRAINT FK_Student
    FOREIGN KEY(ID_student) REFERENCES Students(ID)

ALTER TABLE Student_Event_Occurence
  ADD CONSTRAINT FK_Event_Occurence
    FOREIGN KEY(ID_event_occurence) REFERENCES Event_occurence(ID)

ALTER TABLE Event_occurence
  ADD CONSTRAINT FK_Event
    FOREIGN KEY(ID_Event) REFERENCES [Event](ID)


select * from Event_occurence


select * from Event

SELECT FirstName, LastName FROM Students where ID = 10;