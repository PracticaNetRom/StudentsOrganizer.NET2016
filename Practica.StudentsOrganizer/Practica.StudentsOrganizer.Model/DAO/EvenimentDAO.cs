﻿using Practica.StudentsOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.DAO
{
    class EvenimentDAO
    {
        public EvenimentBO GetEveniment (int id)
            {
            SqlConnection conn = new SqlConnection();
            
            conn.ConnectionString =
            "Data Source = netsrv-db01\\sql2014;" +
            "Initial Catalog = NetRom.Practice3;" +
            "Integrated Security = SSPI;";
            

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " Select id, eventName, task, departamentOrTehnology from Eveniment where ID = " + id;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.Read() == true)
            {
                if (reader.HasRows)
                {
                    EvenimentBO eveniment = new EvenimentBO();
                    //eveniment.id = reader["id"].();
                    eveniment.eventName = reader["eventName"].ToString();
                    eveniment.task = reader["task"].ToString();
                    eveniment.departamentOrTehnology = reader["departamentOrTehnology"].ToString();
                    
                    return eveniment;
                }
            }

            return null;
        }
    }
}
