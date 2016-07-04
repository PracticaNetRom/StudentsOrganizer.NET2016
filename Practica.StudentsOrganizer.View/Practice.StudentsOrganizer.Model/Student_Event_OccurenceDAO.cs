using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StudentsOrganizer.Model
{
     public class Student_Event_OccurenceDAO
    { 
        public Student_Event_OccurenceBO getStudentEventOccurencebyID(int ID)
        {
            SqlDataReader reader;
            Student_Event_OccurenceBO studentEventOccurence = new Student_Event_OccurenceBO();
            // conexiunea cu baza de date

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source = netsrv-db01\\sql2014;" +
                "Initial Catalog=NetRom.Practice2;" +
                "Integrated Security=SSPI;";
            conn.Open();

            //sql command

            SqlCommand cmd = new SqlCommand();

            // connection la command

            cmd.Connection = conn;

            cmd.CommandText = "SELECT ID_student,ID_event_occurence FROM Student_Event_Occurence where ID = " + ID;

            reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows == true)
                {

                    studentEventOccurence.ID_student = reader.GetInt32(reader.GetOrdinal("ID_student"));
                    studentEventOccurence.ID_event_occurence = reader.GetInt32(reader.GetOrdinal("ID_event_occurence"));
                   

                }
            }

            return studentEventOccurence;
        }
    }
}
