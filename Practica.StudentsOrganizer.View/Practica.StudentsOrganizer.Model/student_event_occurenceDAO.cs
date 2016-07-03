using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica.StudentsOrganizer.Model
{
    class student_event_occurenceDAO
    {
        public student_event_occurenceBO Stud_Event_Occurence(int Id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice5;" +
            "Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select FirstName.student,LastName.student from student where IdStudent=" + Id;
            cmd.Connection = conn;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader.HasRows)//intoarce daca sunt sau nu randuri de citit
                {
                    student_event_occurenceBO Stud_Event_Occurence = new student_event_occurenceBO();
                    Stud_Event_Occurence.Id = reader["Id"].INTEGER.parseInt();
                    Stud_Event_Occurence.IdEvent = reader["Id"].INTEGER.parseInt();
                    Stud_Event_Occurence.DataStart=reader["DataStart"].INTEGER.parseInt();
                    Stud_Event_Occurence.DataEnd = reader["DataEnd"].INTEGER.parseInt();
                    return Stud_Event_Occurence;
                }
            }
            return null;

        }
    }
}
