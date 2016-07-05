using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.DAO;
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
            
            /*
            StudentBO stdBO = new StudentBO();
            stdBO.id = 5;
            stdBO.firstName = "Cristina";
            stdBO.lastName = "Popescu";
            stdBO.gender = "F";
            stdBO.birthDate = new DateTime(2016, 4, 2);
            stdBO.email = "popescu@yahoo.com";
            stdBO.phoneNumber = "0936312";
            stdBO.faculty = "ACE";
            stdBO.facultyStartYear = 2014;
            stdBO.remarks = "good!";

            StudentDAO stdDAO = new StudentDAO();
            stdDAO.AddStudent(stdBO);

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = netsrv-db01\\sql2014;" +
            "Initial Catalog = NetRom.Practice3;" +
            "Integrated Security = SSPI;";
     
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("S-a conectat cu succes!");
            }
            else
            {
                MessageBox.Show("Eroare!");
            }
            */
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AddStudentForm());
            Application.Run(new AddEvenimentForm());
            Application.Run(new AddEventOccurenceForm());
            Application.Run(new AddStudentEventOccurence());

           
        }
    }
}
