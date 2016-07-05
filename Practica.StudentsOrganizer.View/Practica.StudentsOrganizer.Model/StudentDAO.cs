﻿ using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model
{
    public class StudentDAO
    {
     public StudentBO   getStudentById(int Id)
        {
            StudentBO student = new StudentBO();
            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString ="Data Source=netsrv-db01\\sql2014;" + "Initial Catalog=NetRom.Practice1;" + "Integrated Security=SSPI;";
            conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "SELECT [First name], [Last name], Gender, [Birth date], Email, [Phone number], Faculty, [Faculty start year], Remarks FROM dbo.Students WHERE Id= " + Id;

            SqlDataReader reader=cmd.ExecuteReader();

            reader.Read();

            if(reader.Read() == true)
            {
                if(reader.HasRows == true)
                {

                    
                    student.FirstName = reader.GetString(reader.GetOrdinal("[First name]"));
                    student.LastName = reader.GetString(reader.GetOrdinal("[Last name]"));
                    student.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    student.BirthDate = reader.GetDateTime(reader.GetOrdinal("[Birth date]"));
                    student.Email = reader.GetString(reader.GetOrdinal("Email"));
                    student.PhoneNumber = reader.GetString(reader.GetOrdinal("[Phone number]"));
                    student.Faculty = reader.GetString(reader.GetOrdinal("Faculty"));
                    student.FacultyStartYear = reader.GetInt32(reader.GetOrdinal("[Faculty start year]"));
                    student.FirstName = reader.GetString(reader.GetOrdinal("Remarks"));

                }
            }

            return student;

        }

        public void AddStudent(StudentBO student)
        {
            
            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString ="Data Source=netsrv-db01\\sql2014;" + "Initial Catalog=NetRom.Practice1;" + "Integrated Security=SSPI;";
            //conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO dbo.Students ([First name],[Last name],Gender,[Birth date],Email,[Phone number],Faculty,[Faculty start year],Remarks) VALUES (@FirstN, @LastN, @Gender, @Birth, @Email, @Number, @Faculty, @FacultyStartY, @Remarks)";

            cmd.Parameters.AddWithValue("@FirstN", student.FirstName);
            cmd.Parameters.AddWithValue("@LastN", student.LastName);
            cmd.Parameters.AddWithValue("@Gender", student.Gender);
            cmd.Parameters.AddWithValue("@Birth", student.BirthDate);
            cmd.Parameters.AddWithValue("@Email", student.Email);
            cmd.Parameters.AddWithValue("@Number", student.PhoneNumber);
            cmd.Parameters.AddWithValue("@Faculty", student.Faculty);
            cmd.Parameters.AddWithValue("@FacultyStartY", student.FacultyStartYear);
            cmd.Parameters.AddWithValue("@Remarks", student.Remarks);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

    }
}
