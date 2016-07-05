using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Practica.StudentsOrganizer.Model;
using System.Data;

namespace Practica.StudentsOrganizer.Model
{
   public class StudentDAO
    {
        private object sqlDbType;

        public studentBO GetStud(int Id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice5;" +
            "Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select FirstName.student,LastName.student,Gender.student,BirtDate.student,Email.student,PhoneNumber.student,PhoneHomeNumber.student,Faculty.student,FacultyStartYear.student,Remarks.student from student where IdStudent=" + Id;
            cmd.Connection = conn;


            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader.HasRows)//intoarce daca sunt sau nu randuri de citit
                {
                    studentBO GetStud = new studentBO();
                    GetStud.FirstName = reader["FirstName"].ToString();
                    GetStud.LastName = reader["LastName"].ToString();
                    GetStud.Gender = reader["Gender"].ToString();
                    GetStud.BirthDate = Convert.ToDateTime(reader["BirtDate"]);
                    GetStud.Email = reader["Email"].ToString();
                    GetStud.PhoneNumbers = reader["PhoneNumbers"].ToString();
                    GetStud.PhoneHomeNumbers = reader["PhoneHomeNumbers"].ToString();
                    GetStud.Faculty = reader["Faculty"].ToString();
                    GetStud.FacultyStarYear = Convert.ToInt32(reader["FacultyStartYear"]);
                    GetStud.Remarks = reader["Remarks"].ToString();
                    return GetStud;
                }
            }
            return null;
        
        }

        public void AddStud(studentBO StudAdd)
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice5;" +
            "Integrated Security=SSPI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT into student(
                                FirstName,
                                LastName,
                                Gender,
                                BirthDate,
                                Email,
                                PhoneNumbers,   
                                PhoneHomeNumbers,
                                Faculty,
                                FacultyStartYear,
                                Remarks) " +
                                " VALUES (@FirstName,@LastName,@Gender,@BirthDate,@Email,@PhoneNumbers,@PhoneHomeNumbers,@Faculty,@FacultyStartYear,@Remarks);";
            cmd.Connection = conn;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 30).Value = StudAdd.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 30).Value = StudAdd.LastName;
            cmd.Parameters.Add("@Gender", SqlDbType.VarChar,1).Value = StudAdd.Gender;
            cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = StudAdd.BirthDate;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = StudAdd.Email;
            cmd.Parameters.Add("@PhoneNumbers", SqlDbType.VarChar,30).Value = StudAdd.PhoneNumbers;
            cmd.Parameters.Add("@PhoneHomeNumbers", SqlDbType.VarChar, 30).Value = StudAdd.PhoneHomeNumbers;
            cmd.Parameters.Add("@Faculty", SqlDbType.VarChar, 50).Value = StudAdd.Faculty;
            cmd.Parameters.Add("@FacultyStartYear", SqlDbType.Int).Value = StudAdd.FacultyStarYear;
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 100).Value = StudAdd.Remarks;

            conn.Open();

            cmd.ExecuteNonQuery();


            
        }
    }
}
