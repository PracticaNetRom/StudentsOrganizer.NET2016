using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StudentsOrganizer.Model
{
    class StudentDAO
    {
        public Student getStudentByID(int ID)
        {
            SqlDataReader reader;
            StudentBO student = new StudentBO();
            // conexiunea cu baza de date

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice2;" +
            "Integrated Security=SSPI;";
            conn.Open();

            //sql command

            SqlCommand cmd = new SqlCommand();

            // connection la command

            cmd.Connection = conn;

            cmd.CommandText = "SELECT FirstName, LastName FROM Students where ID = " + ID;

            reader = cmd.ExecuteReader();

            reader.Read();

            if(reader.Read() == true)
            {
                if(reader.HasRows == true)
                {
                
                    student.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                    student.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                }
            }

            return student;


        }
    }
}
