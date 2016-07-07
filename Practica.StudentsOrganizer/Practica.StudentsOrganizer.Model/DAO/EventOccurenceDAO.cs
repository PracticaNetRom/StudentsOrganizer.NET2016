using Practica.StudentsOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.DAO
{
    public class EventOccurenceDAO
    {
        public EventOccurenceBO GetEventOccurence (int id)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = PC\\SQL;" +
            "Initial Catalog = master;" +
            "Integrated Security = SSPI;";


            /*
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = netsrv-db01\\sql2014;" +
            "Initial Catalog = NetRom.Practice3;" +
            "Integrated Security = SSPI;";
            */


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " Select id, idEvent, startData, endData from EventOccurence where ID = " + id;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows)
                {
                    EventOccurenceBO eventOccurence = new EventOccurenceBO();
                    eventOccurence.id = Convert.ToInt32(reader["id"]);
                    eventOccurence.idEvent = Convert.ToInt32(reader["idEvent"]);
                    eventOccurence.startData = Convert.ToDateTime(reader["startData"]);
                    eventOccurence.endData = Convert.ToDateTime(reader["endData"]);

                    return eventOccurence;
                }
            }

            return null;
        }


        public void AddEventOccurence(EventOccurenceBO eventOccuAdd)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = PC\\SQL;" +
            "Initial Catalog = master;" +
            "Integrated Security = SSPI;";


            /*
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = netsrv-db01\\sql2014;" +
            "Initial Catalog = NetRom.Practice3;" +
            "Integrated Security = SSPI;";
            */

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO EventOccurence(
                                idEvent, 
                                startData, 
                                endData)
                                VALUES(@paramIdEvent, 
                                @paramStartData, 
                                @paramEndData)";

            cmd.Connection = conn;
            conn.Open();

            cmd.Parameters.AddWithValue("@paramIdEvent", eventOccuAdd.idEvent);
            cmd.Parameters.AddWithValue("@paramStartData", eventOccuAdd.startData);
            cmd.Parameters.AddWithValue("@paramEndData", eventOccuAdd.endData);

            cmd.ExecuteNonQuery();
        }
    }
}
