using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StudentsOrganizer.Model
{
    class Event_intermediateDAO
    {
        public Event_intermediate getEventIntermediateByID(int ID)
        {
            SqlDataReader reader;
            Event_intermediateBO eventIntermediate = new Event_intermediateBO();
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

            cmd.CommandText = "SELECT Name FROM Event_intermediate where ID = " + ID;

            reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows == true)
                {

                    eventIntermediate.name = reader.GetString(reader.GetOrdinal("Name"));
                   

                }
            }

            return eventIntermediate;


        }
    }
}
