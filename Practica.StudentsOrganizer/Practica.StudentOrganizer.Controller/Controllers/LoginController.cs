using Practica.StudentOrganizer.Controller.Interfaces;
using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentOrganizer.Controller.Controllers
{
    public class LoginController
    {
        private ILoginForm lgnForm;

        public LoginController (ILoginForm form)
        {
            lgnForm = form;
        }


        public void Login()
        {
            if (lgnForm.TextUserName.Text == "" || lgnForm.TextPassword.Text == "")
            {
                MessageBox.Show("Please enter UserName and Password");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnString.Value;
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM loginTable where userName = '" + lgnForm.TextUserName.Text + "'and passwordL = '" + lgnForm.TextPassword.Text + "'", con);

                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while(reader.Read())
                {
                    count += 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");

                    IMainForm fm = lgnForm.createMainForm();
                    ((Form)fm).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            
        }
    }
}

