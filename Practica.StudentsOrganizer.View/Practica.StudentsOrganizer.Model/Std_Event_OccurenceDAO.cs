using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model
{
    public class Std_Event_OccurenceDAO
    {
        public Std_Event_OccurenceBO getStd_Event_OccurenceById(int Id)
        {
            Std_Event_OccurenceBO std_ev_occ = new Std_Event_OccurenceBO();
            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;
            conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "SELECT Id_Student, Id_Event_Occurence FROM dbo.Std_Event_Occurence WHERE Id= " + Id;

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows == true)
                {


                    std_ev_occ.Id_Student = reader.GetInt32(reader.GetOrdinal("Id_Student"));
                    std_ev_occ.Id_Event_Occurence = reader.GetInt32(reader.GetOrdinal("Id_Event"));

                }
            }

            return std_ev_occ;
        }

        public void AddStd_Event_Occurence(Std_Event_OccurenceBO std_ev_occ)
        {

            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;
            //conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO dbo.Std_Event_Occurence (Id_Student, Id_Event_Occurence) VALUES (@Id_Student, @Id_Event_Occurence)";

            cmd.Parameters.AddWithValue("@Id_Student", std_ev_occ.Id_Student);
            cmd.Parameters.AddWithValue("@Id_Event_Occurence", std_ev_occ.Id_Event_Occurence);
            

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeleteStd_Event_Occurence(int Id)
        {
            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;
            //conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "DELETE FROM dbo.Std_Event_Occurence WHERE Id=" + Id;

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeleteStd_Event_OccurenceByStudentId(int Id_std)
        {
            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;
            //conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "DELETE FROM dbo.Std_Event_Occurence WHERE Id_Student=" + Id_std;

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
