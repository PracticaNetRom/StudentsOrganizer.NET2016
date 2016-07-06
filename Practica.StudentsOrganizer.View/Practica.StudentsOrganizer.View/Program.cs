using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.View;

namespace Practica.StudentsOrganizer.View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          /*  studentBO STD_BO = new studentBO();
            STD_BO.FirstName = "Dragos";
            STD_BO.LastName = "Puscu";
            STD_BO.Gender = "M";
            STD_BO.BirthDate = new DateTime(1995,5,9);
            STD_BO.Email = "psucu.dragos@yahoo.com";
            STD_BO.PhoneNumbers = "214165";
            STD_BO.PhoneHomeNumbers = "0122154";
            STD_BO.FacultyStarYear = 2014;
            STD_BO.Faculty = "Universitatea din Craiova";
            STD_BO.Remarks = ".....";


            StudentDAO STD_DAO = new StudentDAO();
            STD_DAO.AddStud(STD_BO);

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice5;" +
            "Integrated Security=SSPI;";
            conn.Open();

           // var conn2 = new SqlConnection("Data Source = netsrv - db01\\sql2014; Initial Catalog=NetRom.Practice5; Integrated Security=SSPI;");
           // conn2.Open();

            if (conn.State == ConnectionState.Open) {
                MessageBox.Show("Conectare efectuata cu scces!!");
            }
*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
           

        }   
    }
}
