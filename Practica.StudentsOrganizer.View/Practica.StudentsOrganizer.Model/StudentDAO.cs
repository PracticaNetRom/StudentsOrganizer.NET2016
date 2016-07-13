using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model
{
    public class StudentDAO
    {      
     public StudentBO getStudentById(int Id)
        {
            StudentBO student = new StudentBO();
            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;
            conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "SELECT FirstName, LastName, Gender, BirthDate, Email, PhoneNumber, Faculty, FacultyStartYear, Remarks FROM dbo.Students WHERE ID= " + Id;

            SqlDataReader reader=cmd.ExecuteReader();

            if(reader.Read() == true)
            {
                if(reader.HasRows == true)
                {
                    student.Id = Id;
                    student.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                    student.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                    student.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    student.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                    student.Email = reader.GetString(reader.GetOrdinal("Email"));
                    student.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                    student.Faculty = reader.GetString(reader.GetOrdinal("Faculty"));
                    student.FacultyStartYear = reader.GetInt32(reader.GetOrdinal("FacultyStartYear"));
                    student.Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                }
            }

            return student;

        }

        public void AddStudent(StudentBO student)
        {
            
            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;
            //conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO dbo.Students FirstName, LastName, Gender, BirthDate, Email, PhoneNumber, Faculty, FacultyStartYear, Remarks VALUES (@FirstN, @LastN, @Gender, @Birth, @Email, @Number, @Faculty, @FacultyStartY, @Remarks)";

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

        public DataTable GetAllStudents()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;

            DataTable item = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Students", conn);

            adapter.Fill(item);

            return item;

        }


        public void UpdateStudent(StudentBO s)
        {

            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;
            //conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = @"UPDATE dbo.Students 

                           SET FirstName=@FirstN,
                               LastName=@LastN,
                               Gender=@Gender,
                               BirthDate=@Birth,
                               Email=@Email,
                               PhoneNumber=@Number,
                               Faculty=@Faculty,
                               FacultyStartYear=@FacultyStartY,
                               Remarks=@Remarks
                               WHERE ID=@Id";

            cmd.Parameters.AddWithValue("@FirstN", s.FirstName);
            cmd.Parameters.AddWithValue("@LastN", s.LastName);
            cmd.Parameters.AddWithValue("@Gender", s.Gender);
            cmd.Parameters.AddWithValue("@Birth", s.BirthDate);
            cmd.Parameters.AddWithValue("@Email", s.Email);
            cmd.Parameters.AddWithValue("@Number", s.PhoneNumber);
            cmd.Parameters.AddWithValue("@Faculty", s.Faculty);
            cmd.Parameters.AddWithValue("@FacultyStartY", s.FacultyStartYear);
            cmd.Parameters.AddWithValue("@Remarks", s.Remarks);
            cmd.Parameters.AddWithValue("@ID", s.Id);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeleteStudent(int Id)
        {
            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;
            //conn.Open();

            //sql command
            SqlCommand cmd = new SqlCommand();

            //conexiunea la command
            cmd.Connection = conn;

            cmd.CommandText = "DELETE FROM dbo.Students WHERE ID=" + Id;

            conn.Open();
            cmd.ExecuteNonQuery();
        }
        public void SelectEventAndEventOccurence(int Id)
        {
            StudentBO student = new StudentBO();
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;
            conn.Open();

            SqlCommand cmd = new SqlCommand();

           
            cmd.Connection = conn;

            cmd.CommandText = @"select 
                                seo.ID as SudentEventOcurrenceID,
                                eo.ID as EventOcurrenceID,
                                e.Name as EventName,
                                eo.StartDate,
                                eo.EndDate
                            from	
	                            Student_Event_Occurence seo inner join 
	                            Event_occurence eo on seo.ID_event_occurence = eo.ID inner join
	                            Event e on eo.ID_Event = e.ID

                                where seo.ID_student =  " + Id;


 

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
