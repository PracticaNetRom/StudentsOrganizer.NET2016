using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Practica.StudentsOrganizer.Model.BO;

namespace Practica.StudentsOrganizer.Model.DAO
{
    public class Students_DAO
    {
        public string Last_Name { get; private set; }
        public string First_Name { get; private set; }

        public Students_BO GetStudent_ById(int ID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select First_Name Last_Name Gender Birth_Date Email Phone_number" + 
                              "Faculty Faculty_Start_Year Remarks from Students where ID = " + ID;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //reader.Read() true a reusit sa citeasca, false nu a gasit informatii
            if (reader.Read())
            {
                if(reader.HasRows)
                {
                    Students_BO Student = new Students_BO();
                    Student.First_Name = reader["First_Name"].ToString();
                    Student.Last_Name = reader["Last_Name"].ToString();
                    Student.Gender = reader["Gender"].ToString();
                    Student.Birth_Date = Convert.ToDateTime(reader["Birth_Date"]);
                    Student.Email = reader["Email"].ToString();
                    Student.Phone_Number = reader["Phone_Number"].ToString();
                    Student.Faculty = reader["Faculty"].ToString();
                    Student.Faculty_Start_Year = Convert.ToInt32(reader["Faculty_Start_Year"]);
                    Student.Remarks = reader["Remarks"].ToString();
                                      
                    return Student;
                }
            }

            return null;
            
        }

        public List <Students_BO > GetAllStudents()
        {
            List<Students_BO> ListToReturn = new List<Students_BO>();


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select ID, First_Name, Last_Name, Gender, Birth_Date, Email, Phone_number,
                              Faculty, Faculty_Start_Year, Remarks from Students ";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //reader.Read() true a reusit sa citeasca, false nu a gasit informatii
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    Students_BO Student = new Students_BO();
                    Student.ID = Convert.ToInt32(reader["ID"]);
                    Student.First_Name = reader["First_Name"].ToString();
                    Student.Last_Name = reader["Last_Name"].ToString();
                    Student.Gender = reader["Gender"].ToString();
                    Student.Birth_Date = Convert.ToDateTime(reader["Birth_Date"]);
                    Student.Email = reader["Email"].ToString();
                    Student.Phone_Number = reader["Phone_Number"].ToString();
                    Student.Faculty = reader["Faculty"].ToString();
                    Student.Faculty_Start_Year = Convert.ToInt32(reader["Faculty_Start_Year"]);
                    Student.Remarks = reader["Remarks"].ToString();

                    ListToReturn.Add(Student);
                }
            }

            return ListToReturn;
        }

        

        public void AddStudent(Students_BO StudI)
        {
         
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            SqlCommand cmd = new SqlCommand();
              cmd.CommandText = @"INSERT INTO Students ( 
                                      First_Name ,
                                      Last_Name, 
                                      Gender, 
                                      Birth_Date, 
                                      Email, 
                                      Phone_number, 
                                      Faculty, 
                                      Faculty_Start_Year,
                                      Remarks)
                                      VALUES ( @First_Name ,
                                      @Last_Name, 
                                      @Gender, 
                                      @Birth_Date, 
                                      @Email, 
                                      @Phone_number, 
                                      @Faculty, 
                                      @Faculty_Start_Year,
                                      @Remarks)";

              cmd.Connection = conn;
            
              cmd.Parameters.Add("@First_Name", SqlDbType.VarChar, 30).Value = StudI.First_Name;
              cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar, 30).Value = StudI.Last_Name;
              cmd.Parameters.Add("@Gender", SqlDbType.VarChar, 15).Value = StudI.Gender;
              cmd.Parameters.Add("@Birth_Date", SqlDbType.Date ).Value = StudI.Birth_Date;
              cmd.Parameters.Add("@Email", SqlDbType.VarChar, 30 ).Value = StudI.Email;
              cmd.Parameters.Add("@Phone_number", SqlDbType.VarChar, 30).Value = StudI.Phone_Number;
              cmd.Parameters.Add("@Faculty", SqlDbType.VarChar, 100 ).Value = StudI.Faculty;
              cmd.Parameters.Add("@Faculty_Start_Year", SqlDbType.Int).Value = StudI.Faculty_Start_Year;
              cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 100).Value = StudI.Remarks;
            
              conn.Open();
              cmd.ExecuteNonQuery();
            
          }

          public void DeleteStd_ByFirstName (Students_BO DelStud)
          {
            
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            conn.Close();
            cmd = new SqlCommand("DELETE FROM Students WHERE ID = @ID", conn);
            conn.Open();

            //Students_BO DelStud = new Students_BO();
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = DelStud.ID;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Successful.");
            }
            conn.Close();

        }

        public void UpdateStud(Students_BO StudUp )
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Students SET  
                                    First_Name = @First_Name ,
                                    Last_Name = @Last_Name, 
                                    Gender = @Gender, 
                                    Birth_Date = @Birth_Date, 
                                    Email = @Email, 
                                    Phone_number = @Phone_number, 
                                    Faculty = @Faculty, 
                                    Faculty_Start_Year = @Faculty_Start_Year,
                                    Remarks =  @Remarks WHERE ID = @ID";

            cmd.Connection = conn;
            cmd.Parameters.Add("ID", SqlDbType.Int).Value = StudUp.ID;
            cmd.Parameters.Add("@First_Name", SqlDbType.VarChar, 30).Value = StudUp.First_Name;
            cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar, 30).Value = StudUp.Last_Name;
            cmd.Parameters.Add("@Gender", SqlDbType.VarChar, 15).Value = StudUp.Gender;
            cmd.Parameters.Add("@Birth_Date", SqlDbType.Date).Value = StudUp.Birth_Date;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 30).Value = StudUp.Email;
            cmd.Parameters.Add("@Phone_number", SqlDbType.VarChar, 30).Value = StudUp.Phone_Number;
            cmd.Parameters.Add("@Faculty", SqlDbType.VarChar, 100).Value = StudUp.Faculty;
            cmd.Parameters.Add("@Faculty_Start_Year", SqlDbType.Int).Value = StudUp.Faculty_Start_Year;
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 100).Value = StudUp.Remarks;
            
            conn.Open();
            cmd.ExecuteNonQuery();

        }
        public List<Students_BO> Join()
        {
            List<Students_BO> ListToReturn = new List<Students_BO>();
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT  
                                Students.ID,
                                Students.First_Name , 
                                Students.Last_Name, 
                                Students.Gender, 
                                Students.Birth_Date, 
                                Students.Email, 
                                Students.Phone_number, 
                                Students.Faculty, 
                                Students.Faculty_Start_Year,
                                Students.Remarks, 
                                Events.Event_name ,
                                Events.Technology,
                                Events.Task, 
                                Event_Occurence.Start,
                                Event_Occurence.Finish 
                                FROM  Students
                                JOIN Stud_Event_Occurence
                                ON Students.ID = Stud_Event_Occurence.StudentsId
                                JOIN Event_Occurence
                                ON Stud_Event_Occurence.Event_OccurenceId = Event_Occurence.EventsId
                                JOIN Events
                                ON Event_Occurence.EventsId = Events.ID";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //reader.Read() true a reusit sa citeasca, false nu a gasit informatii
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    Students_BO Student = new Students_BO();
                    Events_BO Event = new Events_BO();
                    Event_Occurence_BO Ev_Occ = new Event_Occurence_BO();
                    Student.ID = Convert.ToInt32(reader["ID"]);
                    Student.First_Name = reader["First_Name"].ToString();
                    Student.Last_Name = reader["Last_Name"].ToString();
                    Student.Gender = reader["Gender"].ToString();
                    Student.Birth_Date = Convert.ToDateTime(reader["Birth_Date"]);
                    Student.Email = reader["Email"].ToString();
                    Student.Phone_Number = reader["Phone_Number"].ToString();
                    Student.Faculty = reader["Faculty"].ToString();
                    Student.Faculty_Start_Year = Convert.ToInt32(reader["Faculty_Start_Year"]);
                    Student.Remarks = reader["Remarks"].ToString();
                 
                    Event.Event_Name = reader["Event_Name"].ToString();
                    Event.Technology = reader["Technology"].ToString();
                    Event.Task = reader["Task"].ToString();
                    
                    Ev_Occ.Start = Convert.ToDateTime(reader["Start"]);
                    Ev_Occ.Finish = Convert.ToDateTime(reader["Finish"]);

                    ListToReturn.Add(Student);
                }
            }

            return ListToReturn;
        }
    }
}
