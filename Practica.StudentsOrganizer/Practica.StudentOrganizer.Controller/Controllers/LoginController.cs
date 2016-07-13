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

                SqlCommand cmd = new SqlCommand("SELECT * FROM loginTable where userName = '" + lgnForm.TextUserName.Text + "'and passwordL = '" + lgnForm.TextPassword.Text + "'", con);


                //cmd.Parameters.AddWithValue("@userName", textUserName.Text);
                //cmd.Parameters.AddWithValue("@passwordL", textPassword.Text);

                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();

                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    //this.Close();

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

