using Practica.StudentsOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.DAO
{
    class Stud_Event_Occurence_DAO
    {
        public Stud_Event_Occurence_BO GetStudEvOcc_ById(int ID)
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
            cmd.CommandText = "Select StudentId Event_OccurenceId from Stud_Event_Occurence where ID = " + ID;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //reader.Read() true a reusit sa citeasca, false nu a gasit informatii
            if (reader.Read())
            {
                if (reader.HasRows)
                {
                    Stud_Event_Occurence_BO Stud_Ev_Occ = new Stud_Event_Occurence_BO();

                    //Stud_Ev_Occ.StudentsId = reader.GetInt32(reader.GetOrdinal("StudentsId"));
                    Stud_Ev_Occ.StudentsId = Convert.ToInt32(reader["StudentsId"]);
                    Stud_Ev_Occ.Event_OccurenceId =Convert.ToInt32(reader["Event_OccurenceId"]);

                    return Stud_Ev_Occ;
                }
            }

            return null;

        }
    }
}
