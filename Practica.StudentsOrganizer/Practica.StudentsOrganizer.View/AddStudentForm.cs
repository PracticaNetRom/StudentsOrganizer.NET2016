using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.DAO;
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


namespace Practica.StudentsOrganizer.View
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StudentBO stdBO = new StudentBO();
            //stdBO.id = 6;
            stdBO.firstName = txtFirstName.Text;
            stdBO.lastName = txtLastName.Text;
            stdBO.gender = comboBoxGender.Text;
            stdBO.birthDate = Convert.ToDateTime(dateTimeBirthDate.Text);
            stdBO.email = txtEmail.Text;
            stdBO.phoneNumber = txtPhoneNumber.Text;
            stdBO.faculty = txtFaculty.Text;
            stdBO.facultyStartYear = Convert.ToInt32(txtFacultyStartYear.Text);
            stdBO.remarks = txtRemarks.Text;

            StudentDAO stdDAO = new StudentDAO();


            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please enter student's FIRST NAME!");
            }
            else
            {
                stdBO.firstName = txtFirstName.Text;
            }


            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter student's LAST NAME!");
            }
            else
            {
                stdBO.lastName = txtLastName.Text;
            }


            stdBO.gender = comboBoxGender.Text;


            if(string.IsNullOrEmpty(dateTimeBirthDate.Text))
            {
                MessageBox.Show("Please enter student's BIRTH DATE!");
            }
            else
            {
                stdBO.birthDate = Convert.ToDateTime(dateTimeBirthDate.Text);
            }


            if(string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please enter student's EMAIL");
            }
            else
            {
                stdBO.email = txtEmail.Text;
            }


            stdBO.phoneNumber = txtPhoneNumber.Text;


            if(string.IsNullOrEmpty(txtFaculty.Text))
            {
                MessageBox.Show("Please enter student's FACULTY!");
            }
            else
            {
                stdBO.faculty = txtFaculty.Text;
            }


            if(string.IsNullOrEmpty(txtFacultyStartYear.Text))
            {
                MessageBox.Show("Please enter student's FACULTY START YEAR!");
            }
            else
            {
                stdBO.facultyStartYear = Convert.ToInt32(txtFacultyStartYear.Text);
            }


            stdBO.remarks = txtRemarks.Text;


            stdDAO.AddStudent(stdBO);


            txtFirstName.Clear();
            txtLastName.Clear();
            comboBoxGender.Enabled = false;
            comboBoxGender.Enabled = false;
            dateTimeBirthDate.Enabled = false;
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtFaculty.Clear();
            txtFacultyStartYear.Clear();
            txtRemarks.Clear();
        }

        private void dateTimeBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtFaculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
