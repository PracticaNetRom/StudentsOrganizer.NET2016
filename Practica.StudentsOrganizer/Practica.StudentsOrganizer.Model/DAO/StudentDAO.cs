using Practica.StudentsOrganizer.Model.BO;
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
            cmd.CommandText = " Select id, firstName, lastName, gender, birthDate, email,phoneNumber, faculty, facultyStartYear, remarks from Student where ID = " + id;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows)
                {
                    StudentBO student = new StudentBO();
                    //student.id = reader["id"].;
                    student.firstName = reader["firstName"].ToString();
                    student.lastName = reader["lastName"].ToString();
                    student.gender = reader["gender"].ToString();
                    //student.birthDate = reader["birthDate"].();
                    student.email = reader["email"].ToString();
                    student.phoneNumber = reader["phoneNumber"].ToString();
                    student.faculty = reader["faculty"].ToString();
                    //student.facultyStartYear = reader["facultyStartYear"].();
                    student.remarks = reader["remarks"].ToString();
                    
                    return student;
                }

            }

            return null;
         
        }
    }
}
