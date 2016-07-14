﻿using System;
using System.Collections.Generic;
using System.Data;
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

            cmd.CommandText = "SELECT Id_event, [Start date], [End date] FROM dbo.Event_Occurence WHERE Id= " + Id;

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows == true)
                {

                    event_occ.Id_event = reader.GetInt32(reader.GetOrdinal("Id_event"));
                    event_occ.StartDate = reader.GetDateTime(reader.GetOrdinal("[Start date]"));
                    event_occ.EndDate = reader.GetDateTime(reader.GetOrdinal("[End date]"));
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

            cmd.CommandText = "INSERT INTO dbo.Event_Occurence (Id_event, [Start date], [End date]) VALUES (@Id_ev, @StartDate, @EndDate)";

            cmd.Parameters.AddWithValue("@Id_ev", ev_occ.Id_event);
            cmd.Parameters.AddWithValue("@StartDate", ev_occ.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", ev_occ.EndDate);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public DataTable GetAllEvent_Occurences(int Id_ev)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;

            DataTable item = new DataTable();           
           
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Event_Occurence WHERE Id_event=" + Id_ev, conn);

            adapter.Fill(item);

            return item;

        }
    }
}