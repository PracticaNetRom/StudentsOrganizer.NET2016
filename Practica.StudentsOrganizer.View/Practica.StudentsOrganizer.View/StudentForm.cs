using Practica.StudentsOrganizer.Controller;
using Practica.StudentsOrganizer.Model;
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
    public partial class StudentForm : Form, IStudentForm
    {
        private StudentController controller;
        public StudentBO Student { get; set; }

        public StudentForm()
        {
            InitializeComponent();

            controller = new StudentController(this);

            BirthDate.Properties.MaxValue = DateTime.Now;
            BirthDate.Properties.MinValue = DateTime.Now.AddYears(-100);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            controller.Add_Update();
            Close();

            //StudentBO std = new StudentBO();
            //StudentDAO dao = new StudentDAO();

            //if (Student == null)    // Add
            //{
            //    if (string.IsNullOrEmpty(txtFirstName.Text))
            //    {
            //        MessageBox.Show("Please enter student's first name!");
            //        return;
            //    }
            //    else
            //    {
            //        std.FirstName = txtFirstName.Text;
            //    }

            //    if (string.IsNullOrEmpty(txtLastName.Text))
            //    {
            //        MessageBox.Show("Please enter student's last name!");
            //        return;
            //    }
            //    else
            //    {
            //        std.LastName = txtLastName.Text;
            //    }

            //    if (string.IsNullOrEmpty(Gender.Text))
            //    {
            //        MessageBox.Show("Please enter student's gender!");
            //        return;
            //    }
            //    else
            //    {
            //        std.Gender = Gender.Text;
            //    }

            //    std.BirthDate = BirthDate.DateTime;

            //    if (string.IsNullOrEmpty(txtEmail.Text))
            //    {
            //        MessageBox.Show("Please enter student's Email!");
            //        return;
            //    }
            //    else
            //    {
            //        std.Email = txtEmail.Text;
            //    }

            //    if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            //    {
            //        MessageBox.Show("Please enter student's phone number!");
            //        return;
            //    }
            //    else
            //    {
            //        std.PhoneNumber = txtPhoneNumber.Text;
            //    }

            //    if (string.IsNullOrEmpty(txtFaculty.Text))
            //    {
            //        MessageBox.Show("Please enter student's faculty!");
            //        return;
            //    }
            //    else
            //    {
            //        std.Faculty = txtFaculty.Text;
            //    }

            //    if (string.IsNullOrEmpty(txtFacultyStartYear.Text))
            //    {
            //        MessageBox.Show("Please enter student's faculty start year!");
            //        return;
            //    }
            //    else
            //    {
            //        std.FacultyStartYear = Convert.ToInt32(txtFacultyStartYear.Text);
            //    }

            //    std.Remarks = txtRemarks.Text;

            //    dao.AddStudent(std);

            //    MessageBox.Show("Student successfully added!");

            //    Close();
            //}

            //else   //Update
            //{
            //    if (string.IsNullOrEmpty(txtFirstName.Text))
            //    {
            //        MessageBox.Show("Please enter student's first name!");
            //        return;
            //    }
            //    else
            //    {
            //        Student.FirstName = txtFirstName.Text;
            //    }

            //    if (string.IsNullOrEmpty(txtLastName.Text))
            //    {
            //        MessageBox.Show("Please enter student's last name!");
            //        return;
            //    }
            //    else
            //    {
            //        Student.LastName = txtLastName.Text;
            //    }

            //    if (string.IsNullOrEmpty(Gender.Text))
            //    {
            //        MessageBox.Show("Please enter student's gender!");
            //        return;
            //    }
            //    else
            //    {
            //        Student.Gender = Gender.Text;
            //    }

            //    Student.BirthDate = BirthDate.DateTime;

            //    if (string.IsNullOrEmpty(txtEmail.Text))
            //    {
            //        MessageBox.Show("Please enter student's Email!");
            //        return;
            //    }
            //    else
            //    {
            //        Student.Email = txtEmail.Text;
            //    }

            //    if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            //    {
            //        MessageBox.Show("Please enter student's phone number!");
            //        return;
            //    }
            //    else
            //    {
            //        Student.PhoneNumber = txtPhoneNumber.Text;
            //    }

            //    if (string.IsNullOrEmpty(txtFaculty.Text))
            //    {
            //        MessageBox.Show("Please enter student's faculty!");
            //        return;
            //    }
            //    else
            //    {
            //        Student.Faculty = txtFaculty.Text;
            //    }

            //    if (string.IsNullOrEmpty(txtFacultyStartYear.Text))
            //    {
            //        MessageBox.Show("Please enter student's faculty start year!");
            //        return;
            //    }
            //    else
            //    {
            //        Student.FacultyStartYear = Convert.ToInt32(txtFacultyStartYear.Text);
            //    }

            //    Student.Remarks = txtRemarks.Text;

            //    dao.UpdateStudent(Student);

            //    MessageBox.Show("Student successfully updated!");

            //    Close();
            //}

            
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

            controller.LoadStudentForm();

            //if (Student != null)
            //{
            //    txtFirstName.Text = Student.FirstName;
            //    txtLastName.Text = Student.LastName;
            //    Gender.Text = Student.Gender;
            //    BirthDate.DateTime = Student.BirthDate;
            //    txtEmail.Text = Student.Email;
            //    txtPhoneNumber.Text = Student.PhoneNumber;
            //    txtFaculty.Text = Student.Faculty;
            //    txtFacultyStartYear.Text = Convert.ToString(Student.FacultyStartYear);
            //    txtRemarks.Text = Student.Remarks;
            //}
        }
    }
}
