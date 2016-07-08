using Practica.StudentsOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.DAO
{
    public class StudentEventOccurenceDAO
    {
        public StudentEventOccurenceBO GetStudentEventOccurence (int id)
        {

            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString =
            //"Data Source = PC\\SQL;" +
            //"Initial Catalog = master;" +
            //"Integrated Security = SSPI;";


            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnString.Value;


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " Select id, idStudent, idEventOccurence from StudentEventOccurence where ID = " + id;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows)
                {
                    StudentEventOccurenceBO studentEventOccurence = new StudentEventOccurenceBO();
                    studentEventOccurence.id = Convert.ToInt32(reader["id"]);
                    studentEventOccurence.idStudent = Convert.ToInt32 (reader["idStudent"]);
                    studentEventOccurence.idEvenOccurence = Convert.ToInt32(reader["idEventOccurence"]);

                    return studentEventOccurence;
                }
            }

            return null;
        }


        public void AddSdtEvenOcc(StudentEventOccurenceBO stdEventOccuAdd)
        {

            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString =
            //"Data Source = PC\\SQL;" +
            //"Initial Catalog = master;" +
            //"Integrated Security = SSPI;";

            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnString.Value;



            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO StudentEventOccurence(
                                idStudent, 
                                idEvenOccurence)
                                VALUES(@paramIdStudent, 
                                @paramIdEvenOccurence)";

            cmd.Connection = conn;
            conn.Open();

            cmd.Parameters.AddWithValue("@paramIdStudent", stdEventOccuAdd.idStudent);
            cmd.Parameters.AddWithValue("@paramIdEventOccurence", stdEventOccuAdd.idEvenOccurence);

            cmd.ExecuteNonQuery();
        }
    }
}
