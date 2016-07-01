using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model
{
    class StudentDAO
    {
     public StudentBO   getStudentById(int Id)
        {
            StudentBO student = new StudentBO();
            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice1;" +
            "Integrated Security=SSPI;";
            conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "SELECT [First name] FROM dbo.Students WHERE Id= " + Id;

            SqlDataReader reader=cmd.ExecuteReader();

            reader.Read();

            if(reader.Read() == true)
            {
                if(reader.HasRows == true)
                {

                    
                    student.FirstName = reader.GetString(reader.GetOrdinal("First name"));

                }
            }

            return student;

        }
    }
}
