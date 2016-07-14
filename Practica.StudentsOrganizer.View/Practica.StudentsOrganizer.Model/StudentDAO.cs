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

            cmd.CommandText = "SELECT [First name], [Last name], Gender, [Birth date], Email, [Phone number], Faculty, [Faculty start year], Remarks FROM dbo.Students WHERE Id= " + Id;

            SqlDataReader reader=cmd.ExecuteReader();

            if(reader.Read() == true)
            {
                if(reader.HasRows == true)
                {
                    student.Id = Id;
                    student.FirstName = reader.GetString(reader.GetOrdinal("First name"));
                    student.LastName = reader.GetString(reader.GetOrdinal("Last name"));
                    student.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    student.BirthDate = reader.GetDateTime(reader.GetOrdinal("Birth date"));
                    student.Email = reader.GetString(reader.GetOrdinal("Email"));
                    student.PhoneNumber = reader.GetString(reader.GetOrdinal("Phone number"));
                    student.Faculty = reader.GetString(reader.GetOrdinal("Faculty"));
                    student.FacultyStartYear = reader.GetInt32(reader.GetOrdinal("Faculty start year"));
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

                           SET [First name]=@FirstN,
                               [Last name]=@LastN,
                               Gender=@Gender,
                               [Birth date]=@Birth,
                               Email=@Email,
                               [Phone number]=@Number,
                               Faculty=@Faculty,
                               [Faculty start year]=@FacultyStartY,
                               Remarks=@Remarks
                               WHERE Id=@Id";

            cmd.Parameters.AddWithValue("@FirstN", s.FirstName);
            cmd.Parameters.AddWithValue("@LastN", s.LastName);
            cmd.Parameters.AddWithValue("@Gender", s.Gender);
            cmd.Parameters.AddWithValue("@Birth", s.BirthDate);
            cmd.Parameters.AddWithValue("@Email", s.Email);
            cmd.Parameters.AddWithValue("@Number", s.PhoneNumber);
            cmd.Parameters.AddWithValue("@Faculty", s.Faculty);
            cmd.Parameters.AddWithValue("@FacultyStartY", s.FacultyStartYear);
            cmd.Parameters.AddWithValue("@Remarks", s.Remarks);
            cmd.Parameters.AddWithValue("@Id", s.Id);

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

            cmd.CommandText = "DELETE FROM dbo.Students WHERE Id=" + Id;

            conn.Open();
            cmd.ExecuteNonQuery();
        }


        public DataTable  SelectEventsAndOccurences(int Id_std)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.Value;

            DataTable item = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT seo.Id as StudentEventOccId, eo.Id as EventOccId, e.Name as EventName, eo.[Start date], eo.[End date] FROM dbo.Std_Event_Occurence seo INNER JOIN Event_Occurence eo on seo.Id_Event_Occurence = eo.Id INNER JOIN Event e on eo.Id_event = e.Id WHERE seo.Id_Student = " + Id_std , conn);

            adapter.Fill(item);

            return item;

        }
    }
}
