using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentsOrganizer.View
{
    public partial class UpdateStudentForm : Form
    {
        private StudentBO studentBO;

        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        public UpdateStudentForm(StudentBO studentBO)
        {
            this.studentBO = studentBO;
        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void butnUpdate_Click(object sender, EventArgs e)
        {
            
            StudentBO stdBO = new StudentBO();
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


            if (string.IsNullOrEmpty(dateTimeBirthDate.Text))
            {
                MessageBox.Show("Please enter student's BIRTH DATE!");
                return;
            }
            else
            {
                stdBO.birthDate = Convert.ToDateTime(dateTimeBirthDate.Text);
            }


            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please enter student's EMAIL");
                return;
            }
            else
            {
                stdBO.email = txtEmail.Text;
            }


            stdBO.phoneNumber = txtPhoneNumber.Text;


            if (string.IsNullOrEmpty(txtFaculty.Text))
            {
                MessageBox.Show("Please enter student's FACULTY!");
                return;
            }
            else
            {
                stdBO.faculty = txtFaculty.Text;
            }


            if (string.IsNullOrEmpty(txtFacultyStartYear.Text))
            {
                MessageBox.Show("Please enter student's FACULTY START YEAR!");
                return;
            }
            else
            {
                stdBO.facultyStartYear = Convert.ToInt32(txtFacultyStartYear.Text);
            }


            stdBO.remarks = txtRemarks.Text;


            //stdDAO.updateStudent(stdBO);

            MessageBox.Show("Student successfully updated!");

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

            this.Close();
        }

        
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


        }

        
        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
