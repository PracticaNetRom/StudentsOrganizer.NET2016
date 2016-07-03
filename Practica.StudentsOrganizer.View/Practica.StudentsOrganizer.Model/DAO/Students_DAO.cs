using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Convert

namespace Practica.StudentsOrganizer.Model.DAO
{
    class Students_DAO
    {
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
                    //Student.Birth_Date = reader["Birth_Date"].ToInt32.Parse();
                    Student.Email = reader["Email"].ToString();
                    Student.Phone_Number = reader["Phone_Number"].ToString();
                    Student.Faculty = reader["Faculty"].ToString();
                    //Student.Faculty_Start_Year = reader["Faculty_Start_Year"].GetInt32();
                    Student.Remarks = reader["Remarks"].ToString();
                                      
                    return Student;
                }
            }

            return null;
            
        }
    }
}
