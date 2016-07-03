using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            /*"Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice4;" +
            "Integrated Security=SSPI;";*/

            "Data Source=ROXXANA\\SQLEXPRESS;" +
            "Initial Catalog=PracticaNETROM;" +
            "Integrated Security=SSPI;";

            conn.Open();

            if(conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("ok");
            };

   

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
