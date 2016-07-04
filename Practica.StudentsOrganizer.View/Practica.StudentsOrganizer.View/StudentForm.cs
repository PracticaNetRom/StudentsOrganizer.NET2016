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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            StudentBO std = new StudentBO();
            std.firstName = txtFirstName.Text;
            std.lastName = txtLastName.Text;
            std.gender = txtGender.Text;
            std.birthDate = dateTimeBirthDate.Value;
            std.email = txtEmail.Text;
            std.phoneNumber = txtPhoneNumber.Text;
            std.faculty = txtFaculty.Text;
            std.facultyStartYear = Convert.ToInt32( maskedTextBoxFacultyStartYear.Text);
            std.remarks = txtRemarks.Text;

            StudentDAO dao = new StudentDAO();

            dao.addStudent(std);
            
        }
    }
}
