using Practica.StudentsOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.DAO
{
    class EventOccurenceDAO
    {
        public EventOccurenceBO GetEventOccurence (int id)
        {
            SqlConnection conn = new SqlConnection();
            
            conn.ConnectionString =
            "Data Source = netsrv-db01\\sql2014;" +
            "Initial Catalog = NetRom.Practice3;" +
            "Integrated Security = SSPI;";
            

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
                    //eventOccurence.id = reader["id"].();
                    //eventOccurence.idEvent = reader["idEvent"].();
                    //eventOccurence.startData = reader["startData"].();
                    //eventOccurence.endData = reader["endData"].();

                    return eventOccurence;
                }
            }

            return null;

        }
    }
}
