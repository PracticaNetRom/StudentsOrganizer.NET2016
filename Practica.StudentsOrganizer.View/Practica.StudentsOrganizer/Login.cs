using DevExpress.XtraEditors;
using Practica.StudentsOrganizer.Control.Controlers;
using Practica.StudentsOrganizer.Control.Interfaces;
using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentsOrganizer
{
    public partial class Login : Form, ILoginForm
    {
        private CtrlLogin Controler;
        public TextEdit _txtUsername
        {
            get
            {
                return txtUsername;
            }
        }
        public TextEdit _txtPassword
        {
            get
            {
                return txtPassword;
            }
        }
        //public ButtonEdit _Login_Button
        //{
        //    get
        //    {
        //        return Login_Button;
        //    }
        //}

        public Login()
        {
            Controler = new CtrlLogin();
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connection.ConnValue;
         
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select *from Login where Username = '" + txtUsername.Text + "'and Password = '" + txtPassword.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Welcome!");
                MainForm Op1 = new MainForm();
                Op1.Show();

            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
            
            
        }
    }
}
