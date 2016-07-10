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
    public class Event_Occurence_DAO
    {
        public Event_Occurence_BO GetEvOcc_ById(int ID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
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


        public List<Event_Occurence_BO> GetAllEO()
        {
            List<Event_Occurence_BO> ListToReturn = new List<Event_Occurence_BO>();


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select ID, EventsId, Start, Finish from Event_Occurence";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //reader.Read() true a reusit sa citeasca, false nu a gasit informatii
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    Event_Occurence_BO EO = new Event_Occurence_BO();
                    EO.ID = Convert.ToInt32(reader["ID"]);
                    EO.EventsId = Convert.ToInt32(reader["EventsId"]);
                    EO.Start = Convert.ToDateTime(reader["Start"]);
                    EO.Finish = Convert.ToDateTime(reader["Finish"]);

                    ListToReturn.Add(EO);
                }
            }

            return ListToReturn;



        }

        public void AddEO(Event_Occurence_BO StudEO)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Event_Occurence (  
                                      EventsId, 
                                      Start, 
                                      Finish)
                                      VALUES ( @EventsId ,
                                      @Start,
                                      @Finish)";

            cmd.Connection = conn;


            cmd.Parameters.Add("@EventsId", SqlDbType.Int).Value = StudEO.EventsId;
            cmd.Parameters.Add("@Start", SqlDbType.Date).Value = StudEO.Start;
            cmd.Parameters.Add("@Finish", SqlDbType.Date).Value = StudEO.Finish;


            conn.Open();
            cmd.ExecuteNonQuery();

        }
        public void UpdateEO (Event_Occurence_BO EOUp)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Event_Occurence SET  
                                    EventsId = @EventsId ,
                                    Start = @Start, 
                                    Finish = @Finish 
                                     WHERE ID = @ID";

            cmd.Connection = conn;
            cmd.Parameters.Add("ID", SqlDbType.Int).Value = EOUp.ID;
            cmd.Parameters.Add("EventsId", SqlDbType.Int).Value = EOUp.EventsId;
            cmd.Parameters.Add("@Start", SqlDbType.Date).Value = EOUp.Start;
            cmd.Parameters.Add("@Finish", SqlDbType.Date).Value = EOUp.Finish;

            conn.Open();
            cmd.ExecuteNonQuery();
        }
        public void DeleteEO_ById(Event_Occurence_BO DelEO)
        {

            SqlCommand cmd;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            conn.Close();
            cmd = new SqlCommand("DELETE FROM Event_Occurence WHERE ID = @ID", conn);
            conn.Open();

            //Students_BO DelStud = new Students_BO();
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = DelEO.ID;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Successful.");
            }
            conn.Close();

        }

    }
}
