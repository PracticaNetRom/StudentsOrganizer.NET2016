using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           

        }   
    }
}
