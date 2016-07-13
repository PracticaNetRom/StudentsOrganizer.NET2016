using Practica.StudentsOrganizer.Model.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentsOrganizer.Model.DAO
{
    public class Stud_Event_Occurence_DAO
    {
        public List<Stud_Event_Occurence_DAO> GetAllSEO()
        {
            List<Stud_Event_Occurence_BO> ListToReturn = new List<Stud_Event_Occurence_BO>();
           
            List<Stud_Event_Occurence_DAO> ListSEO_DAO = new List<Stud_Event_Occurence_DAO>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select ID, StudentsId, Event_OccurenceId from Stud_Event_Occurence";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //reader.Read() true a reusit sa citeasca, false nu a gasit informatii
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    Stud_Event_Occurence_BO SEO = new Stud_Event_Occurence_BO();
                    SEO.ID = Convert.ToInt32(reader["ID"]);
                    SEO.StudentsId = Convert.ToInt32(reader["StudentsId"]);
                    SEO.Event_OccurenceId = Convert.ToInt32(reader["Event_OccurenceId"]);


                    ListToReturn.Add(SEO);
                }
            }

            return ListSEO_DAO;



        }
        public void AddSEO(Stud_Event_Occurence_BO StudSEO)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Stud_Event_Occurence ( 
                                      Event_OccurenceId ,
                                      StudentsId)
                                      VALUES ( @Event_OccurenceId ,
                                      @StudentsId)";

            cmd.Connection = conn;


            cmd.Parameters.Add("@Event_OccurenceId", SqlDbType.Int).Value = StudSEO.Event_OccurenceId;
            cmd.Parameters.Add("@StudentsId", SqlDbType.Int).Value = StudSEO.StudentsId;


            conn.Open();
            cmd.ExecuteNonQuery();

        }

        public void UpdateSEO(Stud_Event_Occurence_BO SEOUp)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Stud_Event_Occurence SET  
                                    StudentsId = @StudentsId,
                                    Event_OccurenceId = @Event_OccurenceId 
                                    WHERE ID = @ID";

            cmd.Connection = conn;
            cmd.Parameters.Add("ID", SqlDbType.Int).Value = SEOUp.ID;
            cmd.Parameters.Add("StudentsId", SqlDbType.Int).Value = SEOUp.StudentsId;
            cmd.Parameters.Add("Event_OccurenceId", SqlDbType.Int).Value = SEOUp.Event_OccurenceId;


            conn.Open();
            cmd.ExecuteNonQuery();

        }

        public void DeleteSEO_ById(Stud_Event_Occurence_BO DelSEO)
        {

            SqlCommand cmd;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
            conn.Close();
            cmd = new SqlCommand("DELETE FROM Stud_Event_Occurence WHERE ID = @ID", conn);
            conn.Open();

            //Students_BO DelStud = new Students_BO();
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = DelSEO.ID;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Successful.");
            }
            conn.Close();

        }

    }








}
