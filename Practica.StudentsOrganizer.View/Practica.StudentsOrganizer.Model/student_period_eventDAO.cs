using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica.StudentsOrganizer.Model
{
    class student_period_eventDAO
    {
        public student_period_eventBO Stud_Period_Event(int Id)
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
                    student_period_eventBO Stud_Period_Event = new student_period_eventBO();
                    Stud_Period_Event.IdStudent = reader["IdStudent"].INTEGER.parseInt();
                    Stud_Period_Event.IdStudentOccurence = reader["IdStudentOccurence"].INTEGER.parseInt();
                    return Stud_Period_Event;
                }
    }
            return null;

        }
    }
}

