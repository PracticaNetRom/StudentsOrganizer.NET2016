select *from Students;

select * from Stud_Event_Occurence


SELECT  
                                Students.ID,
                                Students.First_Name , 
                                Students.Last_Name, 
                                Students.Gender, 
                                Students.Birth_Date, 
                                Students.Email, 
                                Students.Phone_number, 
                                Students.Faculty, 
                                Students.Faculty_Start_Year,
                                Students.Remarks, 
                                Events.Event_name ,
                                Events.Technology,
                                Events.Task, 
                                Event_Occurence.Start,
                                Event_Occurence.Finish 
                                FROM  Students
                                JOIN Stud_Event_Occurence
                                ON Students.ID = Stud_Event_Occurence.StudentsId
                                JOIN Event_Occurence
                                ON Stud_Event_Occurence.Event_OccurenceId = Event_Occurence.EventsId
                                JOIN Events
                                ON Event_Occurence.EventsId = Events.ID

SELECT  
                                Stud_Event_Occurence.ID,
                                Event_Occurence.ID,
                                Events.Event_name ,
                                Event_Occurence.Start,
                                Event_Occurence.Finish
                               
                                FROM  Stud_Event_Occurence
                                JOIN Event_Occurence
                                ON Stud_Event_Occurence.Event_OccurenceId = Event_Occurence.ID 
                                JOIN Events
                                ON Event_Occurence.EventsId = Events.ID