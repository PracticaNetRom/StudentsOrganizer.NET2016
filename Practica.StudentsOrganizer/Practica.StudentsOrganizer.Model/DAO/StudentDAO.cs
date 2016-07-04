using Practica.StudentsOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.DAO
{
    public class StudentDAO
    {
        public StudentBO GetStudent (int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = netsrv-db01\\sql2014;" +
            "Initial Catalog = NetRom.Practice3;" +
            "Integrated Security = SSPI;";
            

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " Select firstName, lastName, gender, birthDate, email,phoneNumber, faculty, facultyStartYear, remarks from Student where ID = " + id;
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
                    student.gender = reader["gender"].ToString();
                    student.birthDate = Convert.ToDateTime(reader["birthDate"]);
                    student.email = reader["email"].ToString();
                    student.phoneNumber = reader["phoneNumber"].ToString();
                    student.faculty = reader["faculty"].ToString();
                    student.facultyStartYear = Convert.ToInt32(reader["facultyStartYear"]);
                    student.remarks = reader["remarks"].ToString();

                    return student;
                }
            }

            return null;
         
        }

     
        public void AddStudent (StudentBO studentAdd)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = netsrv-db01\\sql2014;" +
            "Initial Catalog = NetRom.Practice3;" +
            "Integrated Security = SSPI;";

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO Student(
                                firstName, 
                                lastName, 
                                gender,
                                birthDate,
                                email,
                                phoneNumber,
                                faculty, 
                                facultyStartYear,
                                remarks)
                                VALUES(@paramFirstName, 
                                @paramLastName, 
                                @paramGender,
                                @paramBirthDate,
                                @paramEmail,
                                @paramPhoneNumber,
                                @paramFaculty, 
                                @paramFacultyStartYear,
                                @paramRemarks)";

            cmd.Connection = conn;
            conn.Open();

            cmd.Parameters.AddWithValue("@paramFirstName", studentAdd.firstName);
            cmd.Parameters.AddWithValue("@paramLastName", studentAdd.lastName);
            cmd.Parameters.AddWithValue("@paramGender", studentAdd.gender);
            cmd.Parameters.AddWithValue("@paramBirthDate", studentAdd.birthDate);
            cmd.Parameters.AddWithValue("@paramEmail", studentAdd.email);
            cmd.Parameters.AddWithValue("@paramPhoneNumber", studentAdd.phoneNumber);
            cmd.Parameters.AddWithValue("@paramFaculty", studentAdd.faculty);
            cmd.Parameters.AddWithValue("@paramFacultyStartYear", studentAdd.facultyStartYear);
            cmd.Parameters.AddWithValue("@paramRemarks", studentAdd.remarks);

            cmd.ExecuteNonQuery();
          







        }

    }
}
