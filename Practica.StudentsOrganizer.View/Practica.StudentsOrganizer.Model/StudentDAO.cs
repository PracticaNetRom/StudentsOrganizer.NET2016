using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practica.StudentsOrganizer.Model
{
    class StudentDAO
    {
        public studentBO Stud(int IdStudent)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice5;" +
            "Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select FirstName.student,LastName.student from student where IdStudent=" + IdStudent;
            cmd.Connection = conn;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader.HasRows)//intoarce daca sunt sau nu randuri de citit
                {
                    studentBO Stud = new studentBO();
                    Stud.IdStudent = reader["IdStudent"].INTEGER.parseInt();
                    Stud.FirstName = reader["FirstName"].ToString();
                    Stud.LastName = reader["LastName"].ToString();
                    Stud.Gender = reader["Gender"].ToString();
                    Stud.BirtDate = reader["BirtDate"].INTEGER.parseInt();
                    Stud.Email = reader["Email"].ToString();
                    Stud.PhoneNumbers = reader["PhoneNumbers"].INTEGER.parseInt();
                    Stud.PhoneHomeNumbers = reader["PhoneHomeNumbers"].INTEGER.parseInt();
                    Stud.Faculty = reader["Faculty"].ToString();
                    Stud.FacultyStarYear = reader["FacultyStartYear"].INTEGER.parseInt();
                    Stud.Remarks = reader["Remarks"].ToString();
                    return Stud;
                }
            }
            return null;
        
        }
    }
}
