using Practica.StudentsOrganizer.Control.Interfaces;
using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentsOrganizer.Control.Controlers
{
    public class CtrlLogin
    {
        private ILoginForm form;
        public CtrlLogin (ILoginForm form1) 
        {
            form = form1;
        }

        public void Login()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select *from Login where Username = '" + form._txtUsername.Text + "'and Password = '" + form._txtPassword.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Welcome!");
                IMainForm Log = form.OpenMain();
                ((Form)Log).ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }
    }
}
