using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica.StudentsOrganizer.Model
{
    public class evenimentDAO
    {
        public evenimentBO Event(int Id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice5;" +
            "Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select IdEvent.eveniment,EventName.eveniment,Departament.eveniment,Task.eveniment from eveniment where IdEvent=" + Id;
            cmd.Connection = conn;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader.HasRows)//intoarce daca sunt sau nu randuri de citit
                {
                    evenimentBO Event = new evenimentBO();
                    Event.IdEvent = Convert.ToInt32(reader["IdEvent"]);
                    Event.EventName = reader["EventName"].ToString();
                    Event.Departament = reader["Departament"].ToString();
                    Event.Task = reader["Task"].ToString();
                    return Event;
                }
            }
            return null;

        }
        public void AddEvent(evenimentBO EventAdd)
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice5;" +
            "Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT into eveniment(
                                IdEvent,
                                EventName,
                                Departament,
                                Task) " +
                                " VALUES (@IdEvent,@EventName,@Departament,@Task);";
            cmd.Connection = conn;
            cmd.Parameters.Add("@IdEvent", SqlDbType.Int).Value = EventAdd.IdEvent;
            cmd.Parameters.Add("@EventName", SqlDbType.VarChar, 20).Value = EventAdd.EventName;
            cmd.Parameters.Add("@Departament", SqlDbType.VarChar, 30).Value = EventAdd.Departament;
            cmd.Parameters.Add("@Task", SqlDbType.VarChar,60).Value = EventAdd.Task;

            conn.Open();

            cmd.ExecuteNonQuery();

        }


    }
}

