using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model
{
    class EventDAO
    {
       public EventBO  getEventById(int Id)
        {
            EventBO event = new EventBO();
            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString ="Data Source=netsrv-db01\\sql2014;" + "Initial Catalog=NetRom.Practice1;" + "Integrated Security=SSPI;";
            conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "SELECT Name, Task, Department/Technology FROM dbo.Event WHERE Id= " + Id;

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows == true)
                {


                    event.Name = reader.GetString(reader.GetOrdinal("Name"));
                    event.Task = reader.GetString(reader.GetOrdinal("Task"));
                    event.Department_Technology = reader.GetString(reader.GetOrdinal("Department/Technology"));

        }
            }

            return event;
        }
    }
}





