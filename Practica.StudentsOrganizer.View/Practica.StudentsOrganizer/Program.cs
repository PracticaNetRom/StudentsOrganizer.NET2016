using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.DAO;

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
            /*Students_BO Std = new Students_BO();
            Std.First_Name = "Maria";
            Std.Last_Name = "Popescu";
            Std.Gender = "Female";
            Std.Birth_Date = new DateTime(1992, 02, 15);
            Std.Email = "Mar@hdy.com";
            Std.Phone_Number = "0756023048";
            Std.Faculty = "Ace";
            Std.Faculty_Start_Year = 2014;
            Std.Remarks = "hjgfjuehfuheuhfie";



            Students_DAO Std_DAO = new Students_DAO();
            Std_DAO.AddStudent(Std);


            SqlConnection conn = new SqlConnection();
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
            Application.Run(new AddStudentForm());
        }
    }
}
