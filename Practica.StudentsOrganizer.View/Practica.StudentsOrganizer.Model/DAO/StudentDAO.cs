using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.DAO
{
    class StudentDAO
    {
        public StudentBO GetStudent (int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = netsrv-db01\\sql2014;" +
            "Initial Catalog = NetRom.Practice3;" +
            "Integrated Security = SSPI;";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " Select firstName, lastName from Student where ID = " + id;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows)
                {
                    StudentBO student = new StudentBO();
                    student.firstName = reader["firstName"].ToString();
                    student.lastName = reader["lastName"].ToString();

                    return student;
                }

            }

            return null;
         
        }
    }
}
