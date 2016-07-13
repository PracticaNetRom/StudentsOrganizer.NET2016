using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Practica.StudentsOrganizer.Model;

namespace Practica.StudentsOrganizer.Model
{
  public  class student_event_occurenceDAO
    {
        public int IdEvent { get; private set; }

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
                    student_event_occurenceBO Stud_Events_Occurence = new student_event_occurenceBO();
                    Stud_Events_Occurence.Id = Convert.ToInt32(reader["Id"]);
                    Stud_Events_Occurence.IdEvent = Convert.ToInt32(reader["IdEvent"]);
                    Stud_Events_Occurence.DataStart= Convert.ToDateTime(reader["DataStart"]);
                    Stud_Events_Occurence.DataEnd = Convert.ToDateTime(reader["DataEnd"]);

                    return Stud_Events_Occurence;
                }
            }
            return null;

        }

        public List<student_event_occurenceBO> Select_Student_Event(int idEvent)
        {
            List<student_event_occurenceBO> ListToReturn = new List<student_event_occurenceBO>();


            SqlConnection conn = new SqlConnection();
            /*  conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
              "Initial Catalog=NetRom.Practice5;" +
              "Integrated Security=SSPI;";
              */
            conn.ConnectionString = Connection.ConValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select Id,IdEvent,DateStart,DateEnd from student_event_occurence where IdEvent=" + idEvent;
            cmd.Connection = conn;
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    student_event_occurenceBO SEO = new student_event_occurenceBO();
                    SEO.Id = Convert.ToInt32(reader["Id"]);
                    SEO.IdEvent = Convert.ToInt32(reader["IdEvent"]);
                    SEO.DataStart = Convert.ToDateTime(reader["DateStart"]);
                    SEO.DataEnd = Convert.ToDateTime(reader["DateEnd"]);                
                    ListToReturn.Add(SEO);
                }

            }
            return ListToReturn;
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
                                IdEvent,
                                DataStart,
                                DataEnd,
                               ) " +
                                " VALUES (@IdEvent,@DataStart,@DataEnd);";
            cmd.Connection = conn;
            cmd.Parameters.Add("@IdEvent", SqlDbType.Int).Value=student_event_occurenceAdd.IdEvent;
            cmd.Parameters.Add("@DataStart", SqlDbType.DateTime).Value = student_event_occurenceAdd.DataStart;
            cmd.Parameters.Add("@DataEnd", SqlDbType.DateTime).Value = student_event_occurenceAdd.DataEnd;

            conn.Open();

            cmd.ExecuteNonQuery();
        }

        public void UpStudent_event_occurence(student_event_occurenceBO student_event_occurenceUp)
        {


            SqlConnection conn = new SqlConnection();
            /*  conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
              "Initial Catalog=NetRom.Practice5;" +
              "Integrated Security=SSPI;";
              */
            conn.ConnectionString = Connection.ConValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =  @"UPDATE student_evenrt_occurence SET  
                                    IdEvent = @IdEvent ,
                                    DataStart = @DataStart, 
                                    DataEnd = @DataEnd 
                                     WHERE ID = @ID"; 
            cmd.Connection = conn;
            cmd.Parameters.Add("@IdEvent", SqlDbType.Int).Value = student_event_occurenceUp.IdEvent;
            cmd.Parameters.Add("@DataStart", SqlDbType.DateTime).Value = student_event_occurenceUp.DataStart;
            cmd.Parameters.Add("@DataEnd", SqlDbType.DateTime).Value = student_event_occurenceUp.DataEnd;

            conn.Open();

            cmd.ExecuteNonQuery();
        }

        public List<student_event_occurenceBO> GetAllEO()
        {
            List<student_event_occurenceBO> ListToReturn = new List<student_event_occurenceBO>();


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select Id, IdEvent, DateStart, DateEnd from student_event_occurence";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    student_event_occurenceBO EO = new student_event_occurenceBO();
                    EO.Id = Convert.ToInt32(reader["Id"]);
                    EO.IdEvent = Convert.ToInt32(reader["IdEvent"]);
                    EO.DataStart = Convert.ToDateTime(reader["DateStart"]);
                    EO.DataEnd = Convert.ToDateTime(reader["DateEnd"]);

                    ListToReturn.Add(EO);
                }
            }

            return ListToReturn;



        }



    }
}

