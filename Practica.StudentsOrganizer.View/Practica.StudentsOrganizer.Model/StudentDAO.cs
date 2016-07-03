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
        public studentBO GetStud(int Id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice5;" +
            "Integrated Security=SSPI;";
            SqlCommand cmS = new SqlCommand();
            cmS.CommandText = "select FirstName.student,LastName.student,Gender.student,BirtDate.student,Email.student,PhoneNumber.student,PhoneHomeNumber.student,Faculty.student,FacultyStartYear.student,Remarks.student from student where IdStudent=" + Id;
            cmS.Connection = conn;


            conn.Open();
            SqlDataReader reader = cmS.ExecuteReader();

            if (reader.Read())
            {
                if (reader.HasRows)//intoarce daca sunt sau nu randuri de citit
                {
                    studentBO GetStud = new studentBO();
                    GetStud.FirstName = reader["FirstName"].ToString();
                    GetStud.LastName = reader["LastName"].ToString();
                    GetStud.Gender = reader["Gender"].ToString();
                    GetStud.BirtDate = reader["BirtDate"].INTEGER.parseInt();
                    GetStud.Email = reader["Email"].ToString();
                    GetStud.PhoneNumbers = reader["PhoneNumbers"].INTEGER.parseInt();
                    GetStud.PhoneHomeNumbers = reader["PhoneHomeNumbers"].INTEGER.parseInt();
                    GetStud.Faculty = reader["Faculty"].ToString();
                    GetStud.FacultyStarYear = reader["FacultyStartYear"].INTEGER.parseInt();
                    GetStud.Remarks = reader["Remarks"].ToString();
                    return GetStud;
                }
            }
            return null;
        
        }
    }
}
