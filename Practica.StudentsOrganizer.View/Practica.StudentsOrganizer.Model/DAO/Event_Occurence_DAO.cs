using Practica.StudentsOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.DAO
{
    class Event_Occurence_DAO
    {
        public Event_Occurence_BO GetEvOcc_ById(int ID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            /* "Data Source=netsrv-db01\\sql2014;" +
             "Initial Catalog=NetRom.Practice4;" +
             "Integrated Security=SSPI;";*/

            "Data Source=ROXXANA\\SQLEXPRESS;" +
           "Initial Catalog=PracticaNETROM;" +
           "Integrated Security=SSPI;";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select EventsId Start Finish from Event_Occurence where ID = " + ID;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //reader.Read() true a reusit sa citeasca, false nu a gasit informatii
            if (reader.Read())
            {
                if (reader.HasRows)
                {
                    Event_Occurence_BO Ev_Occ = new Event_Occurence_BO();
                    Ev_Occ.EventsId = Convert.ToInt32(reader["EventId"]);
                    Ev_Occ.Start = Convert.ToDateTime(reader["Start"]);
                    Ev_Occ.Finish = Convert.ToDateTime(reader["Finish"]);

                    return Ev_Occ;
                }
            }

            return null;

        }
    }
}
