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
            stdBO.id = 6;
            stdBO.firstName = txtFirstName.Text;
            stdBO.lastName = txtLastName.Text;
            stdBO.gender = txtGender.Text;
            stdBO.birthDate = Convert.ToDateTime(dateTimeBirthDate.Text);
            stdBO.email = txtEmail.Text;
            stdBO.phoneNumber = txtPhoneNumber.Text;
            stdBO.faculty = txtFaculty.Text;
            stdBO.facultyStartYear = Convert.ToInt32 (txtFacultyStartYear.Text);
            stdBO.remarks = txtRemarks.Text;

            StudentDAO stdDAO = new StudentDAO();
            stdDAO.AddStudent(stdBO);


        }

        private void dateTimeBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
