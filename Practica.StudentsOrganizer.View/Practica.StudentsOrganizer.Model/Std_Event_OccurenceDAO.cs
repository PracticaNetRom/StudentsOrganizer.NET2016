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

            cmd.CommandText = "SELECT ID_Student, ID_Event FROM dbo.Student_Event_Occurence WHERE ID= " + Id;

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows == true)
                {


                    std_ev_occ.Id_Student = reader.GetInt32(reader.GetOrdinal("ID_Student"));
                    std_ev_occ.Id_Event = reader.GetInt32(reader.GetOrdinal("ID_Event"));

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

            cmd.CommandText = "INSERT INTO dbo.Student_Event_Occurence (ID_Student, ID_Event) VALUES (@Id_Student, @Id_Event)";

            cmd.Parameters.AddWithValue("@ID_Student", std_ev_occ.Id_Student);
            cmd.Parameters.AddWithValue("@ID_Event", std_ev_occ.Id_Event);
            

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
