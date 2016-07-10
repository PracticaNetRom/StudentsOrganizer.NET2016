using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model
{
    public class Event_OccurenceDAO
    {
        public Event_OccurenceBO getEvent_OccurenceById(int Id)
        {
            Event_OccurenceBO event_occ = new Event_OccurenceBO();
            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;
            conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "SELECT ID_event, StartDate, EndDate FROM dbo.Event_Occurence WHERE ID= " + Id;

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows == true)
                {

                    event_occ.Id_event = reader.GetInt32(reader.GetOrdinal("ID_event"));
                    event_occ.StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                    event_occ.EndDate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                }
            }

            return event_occ;
        }

        public void AddEvent_Occurence(Event_OccurenceBO ev_occ)
        {

            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;
            //conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO dbo.Event_Occurence (ID_event, StartDate, EndDate] VALUES (@Id_ev, @StartDate, @EndDate)";

            cmd.Parameters.AddWithValue("@Id_ev", ev_occ.Id_event);
            cmd.Parameters.AddWithValue("@StartDate", ev_occ.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", ev_occ.EndDate);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
