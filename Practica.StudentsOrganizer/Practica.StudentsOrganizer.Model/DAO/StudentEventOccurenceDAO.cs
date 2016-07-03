using Practica.StudentsOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.DAO
{
    class StudentEventOccurenceDAO
    {
        public StudentEventOccurenceBO GetStudentEventOccurence (int id)
        {
            SqlConnection conn = new SqlConnection();
            
            conn.ConnectionString =
            "Data Source = netsrv-db01\\sql2014;" +
            "Initial Catalog = NetRom.Practice3;" +
            "Integrated Security = SSPI;";
            

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
                    //studentEventOccurence.id = reader["id"].();
                    //studentEventOccurence.idStudent = reader["idStudent"].();
                    //studentEventOccurence.idEventOccurence = reader["idEventOccurence"].();


                    return studentEventOccurence;
                }
            }

            return null;

        }
    }
}
