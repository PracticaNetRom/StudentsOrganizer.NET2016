INSERT INTO Event_occurence (ID_event,StartDate,EndDate) VALUES (1,'2016-06-27','2016-07-15');
INSERT INTO Event_occurence (ID_event,StartDate,EndDate) VALUES (2,'2016-06-27','2016-07-15');

SELECT * FROM Event_occurence;

select * from Student_Event_Occurence
select * from Event_occurence
select * from Event


select 
seo.ID as SudentEventOcurrenceID,
eo.ID as EventOcurrenceID,
e.Name as EventName,
eo.StartDate,
eo.EndDate
from	
	Student_Event_Occurence seo inner join 
	Event_occurence eo on seo.ID_event_occurence = eo.ID inner join
	Event e on eo.ID_Event = e.ID

where seo.ID_student = 