using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StudentsOrganizer.Model
{
   public class Event_occurenceDAO
    {
        public Event_occurenceBO getEventOccurencebyID(int ID)
        {
            SqlDataReader reader;
            Event_occurenceBO eventOccurence = new Event_occurenceBO();
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

            cmd.CommandText = "SELECT ID_Event,StartDate,EndDate FROM Event_occurence where ID = " + ID;

            reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows == true)
                {

                    eventOccurence.ID_Event = reader.GetInt32(reader.GetOrdinal("ID_Event"));
                    eventOccurence.startDate = reader.GetString(reader.GetOrdinal("StartDate"));
                    eventOccurence.endDate = reader.GetString(reader.GetOrdinal("EndDate"));

                }
            }

            return eventOccurence;
        }
    
    }
}
