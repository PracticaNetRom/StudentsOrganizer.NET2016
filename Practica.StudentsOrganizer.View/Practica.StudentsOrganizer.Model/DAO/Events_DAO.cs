using Practica.StudentsOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.DAO
{
    public class Events_DAO
    {
        public Events_BO GetEvent_ById(int ID)
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
            cmd.CommandText = "Select Event_Name Technology Task from Events where ID = " + ID;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
        
            //reader.Read() true a reusit sa citeasca, false nu a gasit informatii
            if (reader.Read())
            {
                if (reader.HasRows)
                {
                    Events_BO Event = new Events_BO();
                    Event.Event_Name = reader["Event_Name"].ToString();
                    Event.Technology = reader["Technology"].ToString();
                    Event.Task = reader["Task"].ToString();
                    
                    return Event;
                }
            }

            return null;

        }
        public void AddEvent(Events_BO EventI)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            /*"Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice4;" +
            "Integrated Security=SSPI;";*/

           "Data Source=ROXXANA\\SQLEXPRESS;" +
          "Initial Catalog=PracticaNETROM;" +
          "Integrated Security=SSPI;";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Events ( 
                                    Event_Name ,
                                    Technology, 
                                    Task )
                                    VALUES ( 
                                    @Event_Name ,
                                    @Technology, 
                                    @Task )";

            cmd.Connection = conn;


            cmd.Parameters.Add("@Event_Name", SqlDbType.VarChar, 30).Value = EventI.Event_Name;
            cmd.Parameters.Add("@Technology", SqlDbType.VarChar, 30).Value = EventI.Technology;
            cmd.Parameters.Add("@Task", SqlDbType.VarChar, 100).Value = EventI.Task;
            

            conn.Open();
            cmd.ExecuteNonQuery();




        }
    }
}
