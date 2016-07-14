using Practica.StudentsOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data;
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
            conn.ConnectionString = ConnString.Value;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select id, firstName, lastName, gender, birthDate, email,phoneNumber, faculty, facultyStartYear, remarks from Student where ID = " + id;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
           
            if (reader.Read() == true)
            {
                if (reader.HasRows)
                {
                    StudentBO student = new StudentBO();
                    student.id = Convert.ToInt32(reader["id"]);
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
            conn.ConnectionString = ConnString.Value;

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


        public DataTable GetAllStudents()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnString.Value;

            DataTable dt = new DataTable();
            SqlDataAdapter adapetr = new SqlDataAdapter("SELECT * FROM Student",conn);

            adapetr.Fill(dt);

            return dt;
        }


        public void updateStudent(StudentBO stdUpdate)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnString.Value;
            SqlCommand updateCmd = new SqlCommand();
 
            updateCmd.CommandText = @"UPDATE Student Set
                                firstName = @pFirstName,
                                lastName = @pLastName, 
                                gender = @pGender,
                                birthDate = @pBirthDate,
                                email = @pEmail,
                                phoneNumber = @pPhoneNumber,
                                faculty  = @pFaculty, 
                                facultyStartYear = @pFacultyStartYear,
                                remarks = @pRemarks 
                                Where id = @id";

            updateCmd.Connection = conn;
            conn.Open();

            updateCmd.Parameters.Add("@id", SqlDbType.Int).Value = stdUpdate.id;
            updateCmd.Parameters.Add("@pFirstName", SqlDbType.VarChar, 40).Value = stdUpdate.firstName;
            updateCmd.Parameters.Add("@pLastName", SqlDbType.VarChar, 40).Value = stdUpdate.lastName;
            updateCmd.Parameters.Add("@pGender", SqlDbType.VarChar, 1).Value = stdUpdate.gender;
            updateCmd.Parameters.Add("@pBirthDate", SqlDbType.Date).Value = stdUpdate.birthDate;
            updateCmd.Parameters.Add("@pEmail", SqlDbType.VarChar, 30).Value = stdUpdate.email;
            updateCmd.Parameters.Add("@pPhoneNumber", SqlDbType.VarChar, 30).Value = stdUpdate.phoneNumber;
            updateCmd.Parameters.Add("@pFaculty", SqlDbType.VarChar, 30).Value = stdUpdate.faculty;
            updateCmd.Parameters.Add("@pFacultyStartYear", SqlDbType.Int).Value = stdUpdate.facultyStartYear;
            updateCmd.Parameters.Add("@pRemarks", SqlDbType.VarChar, 200).Value = stdUpdate.remarks;

            updateCmd.ExecuteNonQuery();
           
        }


        public void DeleteStudent(int id)
        {   
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnString.Value;

            conn.Open();

            SqlCommand deleteCmd = new SqlCommand();

            deleteCmd.CommandText = "DELETE FROM Student WHERE id =" +id;

            deleteCmd.Connection = conn;
            deleteCmd.ExecuteNonQuery();
        }
    }
}
