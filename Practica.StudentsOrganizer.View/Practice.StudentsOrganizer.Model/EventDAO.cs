using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StudentsOrganizer.Model
{
    class EventDAO
    {
        public Event getEventByID(int ID)
        {
            SqlDataReader reader;
            EventBO Event = new EventBO();
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

            cmd.CommandText = "SELECT Name, TaskReceived,Departament/Technology  FROM Event where ID = " + ID;

            reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows == true)
                {

                    Event.name = reader.GetString(reader.GetOrdinal("Name"));
                    Event.taskReceived = reader.GetString(reader.GetOrdinal("TaskReceived"));
                    Event.departamentTechnology = reader.GetString(reader.GetOrdinal("Departament/Technology"));
                }

        
            }
    

            return Event;
    }
}

}
