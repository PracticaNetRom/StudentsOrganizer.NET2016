using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Practica.StudentsOrganizer.Model.DAO
{
    public class Students_DAO
    {
        public string Last_Name { get; private set; }
        public string First_Name { get; private set; }

        public Students_BO GetStudent_ById(int ID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
           /* "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice4;" +
            "Integrated Security=SSPI;";*/

            "Data Source=ROXXANA\\SQLEXPRESS;" +
           "Initial Catalog=PracticaNETROM;" +
           "Integrated Security=SSPI;";

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

        public void AddStudent(Students_BO StudI)
        {
         
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            /*"Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice4;" +
            "Integrated Security=SSPI;";*/

           "Data Source=ROXXANA\\SQLEXPRESS;" +
          "Initial Catalog=PracticaNETROM;" +
          "Integrated Security=SSPI;";

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
            cmd.Parameters.Add("@Faculty_Start_Year", SqlDbType.VarChar).Value = StudI.Faculty_Start_Year;
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 100).Value = StudI.Remarks;

            
            conn.Open();
            cmd.ExecuteNonQuery();
            




        }

        public void DeleteStd_ByFirstName (Students_BO DelStud)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
                 "Data Source=ROXXANA\\SQLEXPRESS;" +
            "Initial Catalog=PracticaNETROM;" +
            "Integrated Security=SSPI;";
            /*"Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice4;" +
            "Integrated Security=SSPI;";*/
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE from Students where First_Name =" + DelStud.First_Name;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();

        }

        public void UpdateStud(Students_BO StudUp )
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
                 "Data Source=ROXXANA\\SQLEXPRESS;" +
            "Initial Catalog=PracticaNETROM;" +
            "Integrated Security=SSPI;";
            /*"Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice4;" +
            "Integrated Security=SSPI;";*/



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
                                    Remarks =  @Remarks )";

            cmd.Connection = conn;

            cmd.Parameters.Add("@First_Name", SqlDbType.VarChar, 30).Value = StudUp.First_Name;
            cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar, 30).Value = StudUp.Last_Name;
            cmd.Parameters.Add("@Gender", SqlDbType.VarChar, 15).Value = StudUp.Gender;
            cmd.Parameters.Add("@Birth_Date", SqlDbType.Date).Value = StudUp.Birth_Date;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 30).Value = StudUp.Email;
            cmd.Parameters.Add("@Phone_number", SqlDbType.VarChar, 30).Value = StudUp.Phone_Number;
            cmd.Parameters.Add("@Faculty", SqlDbType.VarChar, 100).Value = StudUp.Faculty;
            cmd.Parameters.Add("@Faculty_Start_Year", SqlDbType.VarChar).Value = StudUp.Faculty_Start_Year;
            cmd.Parameters.Add("@Remarks", SqlDbType.VarChar, 100).Value = StudUp.Remarks;
            
            conn.Open();
            cmd.ExecuteNonQuery();

        }
    }
}
