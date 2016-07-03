using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica.StudentsOrganizer.Model
{
    class evenimentDAO
    {
        public evenimentBO Event(int IdEvent)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice5;" +
            "Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select FirstName.student,LastName.student from student where IdStudent=" + IdEvent;
            cmd.Connection = conn;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader.HasRows)//intoarce daca sunt sau nu randuri de citit
                {
                    evenimentBO Event = new evenimentBO();
                    Event.IdEvent = reader["IdEvent"].INTEGER.parseInt();
                    Event.EventName = reader["EventName"].ToString();
                    Event.Departament = reader["Departament"].ToString();
                    Event.Task = reader["Task"].ToString();
                    return Event;
                }
            }
            return null;

        }
    }
}

