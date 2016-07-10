using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica.StudentsOrganizer.Model
{
  public  class student_event_occurenceDAO
    {
        public student_event_occurenceBO Stud_Event_Occurence(int Id)
        {
            SqlConnection conn = new SqlConnection();
            /*conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice5;" +
            "Integrated Security=SSPI;";
            */
            conn.ConnectionString = Connection.ConValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Id.student_event_occurence,IdEvent.student_event_occurence,DataStart.student_event_occurence,DataEnd.student_event_occurence from student_event_occurence where Id=" + Id;
            cmd.Connection = conn;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader.HasRows)//intoarce daca sunt sau nu randuri de citit
                {
                    student_event_occurenceBO Stud_Event_Occurence = new student_event_occurenceBO();
                    Stud_Event_Occurence.Id = Convert.ToInt32(reader["Id"]);
                    Stud_Event_Occurence.IdEvent = Convert.ToInt32(reader["IdEvent"]);
                    Stud_Event_Occurence.DataStart= Convert.ToDateTime(reader["DataStart"]);
                    Stud_Event_Occurence.DataEnd = Convert.ToDateTime(reader["DataEnd"]);
                    return Stud_Event_Occurence;
                }
            }
            return null;

        }
        public void AddStudent_event_occurence(student_event_occurenceBO student_event_occurenceAdd)
        {


            SqlConnection conn = new SqlConnection();
            /*  conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
              "Initial Catalog=NetRom.Practice5;" +
              "Integrated Security=SSPI;";
              */
            conn.ConnectionString = Connection.ConValue; 
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT into student_event_occurence(
                                DataStart,
                                DataEnd,
                               ) " +
                                " VALUES (@Id,@IdEvent,@DataStart,@DataEnd);";
            cmd.Connection = conn;
            cmd.Parameters.Add("@DataStart", SqlDbType.DateTime).Value = student_event_occurenceAdd.DataStart;
            cmd.Parameters.Add("@DataEnd", SqlDbType.DateTime).Value = student_event_occurenceAdd.DataEnd;

            conn.Open();

            cmd.ExecuteNonQuery();
        }
    }
}
