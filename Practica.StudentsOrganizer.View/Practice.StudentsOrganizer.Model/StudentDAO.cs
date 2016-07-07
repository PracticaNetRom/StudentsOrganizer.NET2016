using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StudentsOrganizer.Model
{
    public class StudentDAO
    {


        public StudentBO getStudentByID(int ID)
        {
            SqlDataReader reader;
            StudentBO student = new StudentBO();
            // conexiunea cu baza de date

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = ANDRA;" + //  netsrv-db01\\sql2014
            "Initial Catalog=NetRom.Practice2;" +
            "Integrated Security=SSPI;";
            conn.Open();

            //sql command

            SqlCommand cmd = new SqlCommand();

            // connection la command

            cmd.Connection = conn;

            cmd.CommandText = "SELECT FirstName, LastName,Gender,BirthDate,Email,PhoneNumber,Faculty,FacultyStartYear,Remarks FROM Students where ID = " + ID;

            reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows == true)
                {

                    student.firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                    student.lastName = reader.GetString(reader.GetOrdinal("LastName"));
                    student.gender = reader.GetString(reader.GetOrdinal("Gender"));
                    student.birthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                    student.email = reader.GetString(reader.GetOrdinal("Email"));
                    student.phoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                    student.faculty = reader.GetString(reader.GetOrdinal("Faculty"));
                    student.facultyStartYear = reader.GetInt32(reader.GetOrdinal("FacultyStratYear"));
                    student.remarks = reader.GetString(reader.GetOrdinal("Remarks"));

                }
            }

            return student;


        }

        public void addStudent(StudentBO student)
        {

            string insertSql = @"INSERT INTO Students(FirstName,LastName,Gender,BirthDate,Email,PhoneNumber,Faculty,FacultyStartYear,Remarks)
                     Values(@FirstName,@LastName,@Gender,@BirthDate,@Email,@PhoneNumber,@Faculty,@FacultyStartYear,@Remarks)";

            using (var conn = new SqlConnection(@"Data Source = ANDRA; 
                                                Initial Catalog=NetRom.Practice2; 
                                                Integrated Security=SSPI;"))
            {                                   // netsrv-db01\sql2014
                using (var com = new SqlCommand(insertSql, conn))
                {

                    com.Parameters.AddWithValue("@FirstName", student.firstName);
                    com.Parameters.AddWithValue("@LastName", student.lastName);
                    com.Parameters.AddWithValue("@Gender", student.gender);
                    com.Parameters.AddWithValue("@BirthDate", student.birthDate);
                    com.Parameters.AddWithValue("@Email", student.email);
                    com.Parameters.AddWithValue("@PhoneNumber", student.phoneNumber);
                    com.Parameters.AddWithValue("@Faculty", student.faculty);
                    com.Parameters.AddWithValue("@FacultyStartYear", student.facultyStartYear);
                    com.Parameters.AddWithValue("@Remarks", student.remarks);


                }
            }
        }
        public DataTable GetAllStudents()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" + "Initial Catalog=NetRom.Practice1;" + "Integrated Security=SSPI;";

            DataTable item = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Students", conn);

            adapter.Fill(item);

            return item;

        }


        public void UpdateStudent(StudentBO student)
        {

            //conexiunea cu baza de date
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" + "Initial Catalog=NetRom.Practice1;" + "Integrated Security=SSPI;";
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
                               Remarks=@Remarks'
                               WHERE ID=@ID";

            cmd.Parameters.AddWithValue("@FirstN", student.firstName);
            cmd.Parameters.AddWithValue("@LastN", student.lastName);
            cmd.Parameters.AddWithValue("@Gender", student.gender);
            cmd.Parameters.AddWithValue("@Birth", student.birthDate);
            cmd.Parameters.AddWithValue("@Email", student.email);
            cmd.Parameters.AddWithValue("@Number", student.phoneNumber);
            cmd.Parameters.AddWithValue("@Faculty", student.faculty);
            cmd.Parameters.AddWithValue("@FacultyStartY", student.facultyStartYear);
            cmd.Parameters.AddWithValue("@Remarks", student.remarks);
            cmd.Parameters.AddWithValue("@ID", student.ID);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
