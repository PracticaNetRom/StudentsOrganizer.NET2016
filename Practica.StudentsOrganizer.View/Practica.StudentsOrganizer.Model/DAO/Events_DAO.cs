using Practica.StudentsOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentsOrganizer.Model.DAO
{
    public class Events_DAO
    {
        public List<Events_BO> GetEvent_ById(int ID)
        {
            List<Events_BO> ListToReturn = new List<Events_BO>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select ID, Event_Name, Technology, Task from Events where ID = " + ID;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
        
            //reader.Read() true a reusit sa citeasca, false nu a gasit informatii
            if (reader.Read())
            {
                if (reader.HasRows)
                {
                    Events_BO Event = new Events_BO();
                    Event.ID = Convert.ToInt32(reader["ID"]);
                    Event.Event_Name = reader["Event_Name"].ToString();
                    Event.Technology = reader["Technology"].ToString();
                    Event.Task = reader["Task"].ToString();
                    
                    ListToReturn.Add(Event);
                }
            }

            return ListToReturn;

        }
        public List<Events_BO> GetAllEvents()
        {

            List<Events_BO> ListToReturn = new List<Events_BO>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select ID, Event_Name, Technology, Task from Events ";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //reader.Read() true a reusit sa citeasca, false nu a gasit informatii
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    Events_BO Event = new Events_BO();
                    Event.ID = Convert.ToInt32(reader["ID"]);
                    Event.Event_Name = reader["Event_Name"].ToString();
                    Event.Technology = reader["Technology"].ToString();
                    Event.Task = reader["Task"].ToString();
                   

                    ListToReturn.Add(Event);
                }
            }

            return ListToReturn;



        }
        public void AddEvent(Events_BO EventI)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
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
        public void UpdateEvent(Events_BO EventUp)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Students SET  
                                    Event_Name = @Event_Name ,
                                    Technology = @Technology, 
                                    Task = @Task WHERE ID = @ID";

            cmd.Connection = conn;
            cmd.Parameters.Add("ID", SqlDbType.Int).Value = EventUp.ID;
            cmd.Parameters.Add("@Event_Name", SqlDbType.VarChar, 30).Value = EventUp.Event_Name;
            cmd.Parameters.Add("@Technology", SqlDbType.VarChar, 30).Value = EventUp.Technology;
            cmd.Parameters.Add("@Task", SqlDbType.VarChar, 100).Value = EventUp.Task;
            
            conn.Open();
            cmd.ExecuteNonQuery();

        }
        public void DeleteEV_ById(Events_BO DelEv)
        {

            SqlCommand cmd;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            conn.Close();
            cmd = new SqlCommand("DELETE FROM Events WHERE ID = @ID", conn);
            conn.Open();

            //Students_BO DelStud = new Students_BO();
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = DelEv.ID;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Successful.");
            }
            conn.Close();

        }
    }
}
