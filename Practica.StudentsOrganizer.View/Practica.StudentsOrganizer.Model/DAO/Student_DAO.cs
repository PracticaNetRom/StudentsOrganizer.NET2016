using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.DAO
{
    class Student_DAO
    {
        public Students_BO GetStudent(int ID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice4;" +
            "Integrated Security=SSPI;";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select First_Name Last_Name from Students where ID = " + ID;
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

                    return Student;
                }
            }

            return null;
            
        }
    }
}
