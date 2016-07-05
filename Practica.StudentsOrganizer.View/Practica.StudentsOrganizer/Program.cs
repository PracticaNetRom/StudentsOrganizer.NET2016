using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.DAO;
using Practica.StudentsOrganizer.Model.BO;

namespace Practica.StudentsOrganizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Events_BO Ev = new Events_BO();
            Events_DAO EvDAO = new Events_DAO();
           
            Ev.Event_Name = "Shadowday";
            Ev.Technology = "All";
            Ev.Task = "ndjininvi";
            EvDAO.AddEvent(Ev);

            /*Students_BO Std = new Students_BO();
            Std.First_Name = "Maria";
            Std.Last_Name = "Popescu";
            Std.Gender = "Female";
            Std.Birth_Date = new DateTime(1992, 02, 15);
            Std.Email = "Mar@hdy.com";
            Std.Phone_Number = "0756023048";
            Std.Faculty = "Ace";
            Std.Faculty_Start_Year = 2014;
            Std.Remarks = "hjgfjuehfuheuhfie";*/


            /*Students_BO Std = new Students_BO();
            Students_DAO Std_DAO = new Students_DAO();
            Std_DAO.GetStudent_ById(3);*/


            /*SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice4;" +
            "Integrated Security=SSPI;";

            /*"Data Source=ROXXANA\\SQLEXPRESS;" +
            "Initial Catalog=PracticaNETROM;" +
            "Integrated Security=SSPI;";*/

            /* conn.Open();

             if (conn.State == System.Data.ConnectionState.Open)
             {
                 MessageBox.Show("ok");
             };
             */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
