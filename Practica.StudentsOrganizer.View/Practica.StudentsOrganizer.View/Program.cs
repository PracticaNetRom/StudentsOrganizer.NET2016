using Practice.StudentsOrganizer.Model;
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
            //StudentBO std = new StudentBO();
            //std.firstName = "and";
            //std.lastName = "aaa";
            //std.gender = "F";
            //std.birthDate =  new DateTime(1998,4,11);
            //std.email = "and55";
            //std.phoneNumber = "0950586";
            //std.faculty = "ACE";
            //std.facultyStartYear = "200";
            //std.remarks = "bursiera";

            //StudentDAO dao = new StudentDAO();

            //dao.addStudent(std);


            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString =
            //"Data Source = netsrv-db01\\sql2014;" +
            //"Initial Catalog=NetRom.Practice2;" +
            //"Integrated Security=SSPI;";
            //conn.Open();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
