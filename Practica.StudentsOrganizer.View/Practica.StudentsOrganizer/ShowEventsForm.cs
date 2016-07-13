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
    public partial class ShowEventsForm : Form
    {
        public ShowEventsForm()
        {
            InitializeComponent();
        }

        private void ShowEventsButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            /*"Data Source=netsrv-db01\\sql2014;" +
            "Initial Catalog=NetRom.Practice4;" +
            "Integrated Security=SSPI;";*/

           "Data Source=ROXXANA\\SQLEXPRESS;" +
          "Initial Catalog=PracticaNETROM;" +
          "Integrated Security=SSPI;";

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter(@"Select 
                            Event_Name Technology Task from Students", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Add_Event_Button_Click(object sender, EventArgs e)
        {
            EventForm EvForm = new EventForm();
            EvForm.Show();
        }
    }
}
