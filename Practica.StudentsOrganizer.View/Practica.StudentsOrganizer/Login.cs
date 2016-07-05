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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            /* "Data Source=netsrv-db01\\sql2014;" +
             "Initial Catalog=NetRom.Practice4;" +
             "Integrated Security=SSPI;";*/

            "Data Source=ROXXANA\\SQLEXPRESS;" +
           "Initial Catalog=PracticaNETROM;" +
           "Integrated Security=SSPI;";
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select *from Login where Username = '" + txtUsername.Text + "'and Password = '" + txtPassword.Text + "'", conn);
            //cmd.CommandText = "Select *from Login where Username = '" + txtUsername.Text + "'and Password = '" + txtPassword.Text +"'",conn);
            //cmd.Connection = conn;
            //conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }
            if(count == 1)
            {
                MessageBox.Show("Welcome!");
                OperationTablesForm Op1 = new OperationTablesForm();
                Op1.Show();

            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
