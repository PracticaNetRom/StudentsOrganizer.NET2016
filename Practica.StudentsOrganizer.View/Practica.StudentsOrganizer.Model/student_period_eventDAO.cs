using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica.StudentsOrganizer.Model
{
    public class student_period_eventDAO
    {
        public List<student_period_eventDAO> GetAllSEO()
        {
            List<student_period_eventBO> ListToReturn = new List<student_period_eventBO>();

            List<student_period_eventDAO> ListSEO_DAO = new List<student_period_eventDAO>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select IdStudent.student_period_event,IdStudentOccurence.student_period_event from student_period_event where IdStudent=@IdStudent";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    student_period_eventBO SEO = new student_period_eventBO();
                    SEO.Id = Convert.ToInt32(reader["ID"]);
                    SEO.IdStudent = Convert.ToInt32(reader["StudentsId"]);
                    SEO.IdStudentOccurence = Convert.ToInt32(reader["Event_OccurenceId"]);


                    ListToReturn.Add(SEO);
                }
            }

            return ListSEO_DAO;



        }

        public void AddStudent_period_eventDAO(student_period_eventBO Student_period_eventDAO_ADD)
        {


            SqlConnection conn = new SqlConnection();
            // conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
            //"Initial Catalog=NetRom.Practice5;" +
            //"Integrated Security=SSPI;";
            conn.ConnectionString = Connection.ConValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT into student_period_event(
                                IdStudent,
                                IdStudentOccurence,
                                ) " +
                                " VALUES (@IdStudent,@IdStudentOccurence);";
            cmd.Connection = conn;
            cmd.Parameters.Add("@IdStudent", SqlDbType.Int).Value = Student_period_eventDAO_ADD.IdStudent;
            cmd.Parameters.Add("@IdStudentOccurence", SqlDbType.Int).Value = Student_period_eventDAO_ADD.IdStudentOccurence;

            conn.Open();
            cmd.ExecuteNonQuery();

        }

        public void UpStudent_period_eventDAO(student_period_eventBO Student_period_eventDAO_UP)
        {


            SqlConnection conn = new SqlConnection();
            // conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
            //"Initial Catalog=NetRom.Practice5;" +
            //"Integrated Security=SSPI;";
            conn.ConnectionString = Connection.ConValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Stud_Event_Occurence SET  
                                    IdStudent = @StudentsId,
                                    IdStudentOccurence = @IdStudentOccurence,
                                    WHERE Id = @Id";
            cmd.Connection = conn;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Student_period_eventDAO_UP.Id;
            cmd.Parameters.Add("@IdStudentOccurence", SqlDbType.Int).Value = Student_period_eventDAO_UP.IdStudentOccurence;
            cmd.Parameters.Add("@IdStudent", SqlDbType.Int).Value = Student_period_eventDAO_UP.IdStudent;

            conn.Open();
            cmd.ExecuteNonQuery();

        }


    }
}

