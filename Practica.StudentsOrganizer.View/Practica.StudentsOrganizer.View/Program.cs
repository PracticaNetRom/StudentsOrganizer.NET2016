using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


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

          

            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString ="Data Source=netsrv-db01\\sql2014;" + "Initial Catalog=NetRom.Practice1;" + "Integrated Security=SSPI;";
            //conn.Open();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
