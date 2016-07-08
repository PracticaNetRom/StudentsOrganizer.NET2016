using Practica.StudentOrganizer.Controller;
using Practice.StudentsOrganizer.Model;
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
    public partial class StudentForm : Form,IStudentForm
    {
         public StudentBO Student { get; set; }
        private StudentController controller;

          
        public StudentForm()
        {
            InitializeComponent();

            controller = new StudentController(this);
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            StudentBO std = new StudentBO();

            std.firstName = txtFirstName.Text;
            std.lastName = txtLastName.Text;
            std.gender = comboBoxGender.Text;
            std.birthDate = dateTimeBirthDate.DateTime;
            std.email = txtEmail.Text;
            std.phoneNumber = txtPhoneNumber.Text;
            std.faculty = txtFaculty.Text;
            std.facultyStartYear = Convert.ToInt32( maskedTextBoxFacultyStartYear.Text);
            std.remarks = txtRemarks.Text;

            StudentDAO dao = new StudentDAO();

            dao.addStudent(std);

            MessageBox.Show("Student added");

            //txtFirstName.Clear();
           // txtLastName.Clear();
           // comboBoxGender.Clear();
            //dateTimeBirthDate
           // txtEmail.Clear();
            //txtPhoneNumber.Clear();
            //txtFaculty.Clear();
           // maskedTextBoxFacultyStartYear.Clear();
           // txtRemarks.Clear();
            
        }
        private void StudentForm_Load(object sender,EventArgs e)
        {
            if(Student != null)
            {
                txtFirstName.Text = Student.firstName;
                txtLastName.Text = Student.lastName;
                comboBoxGender.Text = Student.gender;
                dateTimeBirthDate.DateTime = Student.birthDate;
                txtEmail.Text = Student.email;
                txtPhoneNumber.Text = Student.phoneNumber;
                txtFaculty.Text = Student.faculty;
                txtRemarks.Text = Student.remarks;
            }
        }
    }
}
