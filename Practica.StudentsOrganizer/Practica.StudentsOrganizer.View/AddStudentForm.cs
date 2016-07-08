using Practica.StudentOrganizer.Controller.Interfaces;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.DAO;
using Practica.StudentsOrganizer.View;
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
    public partial class AddStudentForm : Form, IAddStudentForm

    {    
 

        public AddStudentForm()
        {
            InitializeComponent();
            dateTimeBirthDate.Properties.MaxValue = DateTime.Now;
            dateTimeBirthDate.Properties.MinValue = DateTime.Now.AddYears(-50);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StudentBO stdBO;
            if (student == null)  //student nou
            {
                stdBO = new StudentBO();
            }
            else
            {
                stdBO = student;
            }

           
            //stdBO.id = 6;
            stdBO.firstName = txtFirstName.Text;
            stdBO.lastName = txtLastName.Text;
            stdBO.gender = comboBoxGender.Text;
            stdBO.birthDate = dateTimeBirthDate.DateTime;
            stdBO.email = txtEmail.Text;
            stdBO.phoneNumber = txtPhoneNumber.Text;
            stdBO.faculty = txtFaculty.Text;
            stdBO.facultyStartYear = Convert.ToInt32(txtFacultyStartYear.Text);
            stdBO.remarks = txtRemarks.Text;

            StudentDAO stdDAO = new StudentDAO();


            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please enter student's FIRST NAME!");
                return;
            }
            else
            {
                stdBO.firstName = txtFirstName.Text;
            }


            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter student's LAST NAME!");
                return;
            }
            else
            {
                stdBO.lastName = txtLastName.Text;
            }


            stdBO.gender = comboBoxGender.Text;


            if(string.IsNullOrEmpty(dateTimeBirthDate.Text))
            {
                MessageBox.Show("Please enter student's BIRTH DATE!");
                return;
            }
            else
            {
                stdBO.birthDate = Convert.ToDateTime(dateTimeBirthDate.Text);
            }


            if(string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please enter student's EMAIL");
                return;
            }
            else
            {
                stdBO.email = txtEmail.Text;
            }


            stdBO.phoneNumber = txtPhoneNumber.Text;


            if(string.IsNullOrEmpty(txtFaculty.Text))
            {
                MessageBox.Show("Please enter student's FACULTY!");
                return;
            }
            else
            {
                stdBO.faculty = txtFaculty.Text;
            }


            if(string.IsNullOrEmpty(txtFacultyStartYear.Text))
            {
                MessageBox.Show("Please enter student's FACULTY START YEAR!");
                return;
            }
            else
            {
                stdBO.facultyStartYear = Convert.ToInt32(txtFacultyStartYear.Text);
            }

            stdBO.remarks = txtRemarks.Text;


            if (student == null)  //student nou
            {
                stdDAO.AddStudent(stdBO);
                MessageBox.Show("Student successfully added!");
            }
            else
            {
                stdDAO.updateStudent(stdBO);
                MessageBox.Show("Student successfully updated!");
                this.Close();
            }

            

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            comboBoxGender.Text = string.Empty;
            comboBoxGender.Text = string.Empty;
            dateTimeBirthDate.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtFaculty.Text = string.Empty;
            txtFacultyStartYear.Text = string.Empty;
            txtRemarks.Text = string.Empty;
        }


        StudentBO student;
        
        public void PopulateStudent(StudentBO s)
        {
            txtFirstName.Text = s.firstName;
            txtLastName.Text = s.lastName;
            comboBoxGender.Text = s.gender;
            dateTimeBirthDate.DateTime = s.birthDate;
            txtEmail.Text = s.email;
            txtPhoneNumber.Text = s.phoneNumber;
            txtFaculty.Text = s.faculty;
            txtFacultyStartYear.Text = Convert.ToString(s.facultyStartYear);
            txtRemarks.Text = s.remarks;

            student = s;

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

        private void txtFirstName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
