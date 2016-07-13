using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model
{
    public class EventDAO
    {      
       public EventBO  getEventById(int Id)
        {
            EventBO e = new EventBO();
            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;
            conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "SELECT Name, Task, Department/Technology FROM dbo.Event WHERE ID= " + Id;

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows == true)
                {


                    e.Name = reader.GetString(reader.GetOrdinal("Name"));
                    e.Task = reader.GetString(reader.GetOrdinal("Task"));
                    e.Department_Technology = reader.GetString(reader.GetOrdinal("Department/Technology"));

                }
            }

            return e;
        }

        /* public void AddEvent(EventBO ev)
         {

             //conexiunea cu baza de date
             SqlConnection conn = new SqlConnection();
                 conn.ConnectionString = ConnectionString.Value;
                 //conn.Open();

                 //sql command
                 SqlCommand cmd = new SqlCommand();

             //conexiunea la command
             cmd.Connection = conn;

             cmd.CommandText = "INSERT INTO dbo.Event (Name,Task,Department/Technology) VALUES (@Name, @Task, @Dep_Tech)";

             cmd.Parameters.AddWithValue("@Name", ev.Name);
             cmd.Parameters.AddWithValue("@Task", ev.Task);
             cmd.Parameters.AddWithValue("@Dep_Tech", ev.Department_Technology);

             conn.Open();
             cmd.ExecuteNonQuery();
         }*/

        public DataTable GetAllEvents()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;

            DataTable item = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Event", conn);

            adapter.Fill(item);

            return item;

        }
        

    }
}





