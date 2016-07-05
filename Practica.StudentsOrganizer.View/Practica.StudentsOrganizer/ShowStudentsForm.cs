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
    public partial class ShowStudentsForm : Form
    {
        public ShowStudentsForm()
        {
            InitializeComponent();
        }

        private void ShowStudentsButton_Click(object sender, EventArgs e)
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
            // cmd.CommandText = @"Select First_Name Last_Name Gender Birth_Date Email Phone_number
            //  Faculty Faculty_Start_Year Remarks from Students";
            SqlDataAdapter sda = new SqlDataAdapter(@"Select ID First_Name Last_Name Gender Birth_Date Email 
                                        Phone_Number Faculty Faculty_Start_Year Remarks from Students", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Add_Stud_Button_Click(object sender, EventArgs e)
        {
            AddStudentForm Add_Std_Form = new AddStudentForm();
            Add_Std_Form.Show();
        }
    }
}
