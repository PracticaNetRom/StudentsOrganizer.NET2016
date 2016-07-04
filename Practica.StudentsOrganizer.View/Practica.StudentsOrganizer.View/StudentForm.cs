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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentBO std = new StudentBO();
            Model.StudentDAO dao = new Model.StudentDAO();
            std.FirstName = txtFirstName.Text;
            std.LastName = txtLastName.Text;
            std.Gender = txtGender.Text;
            std.BirthDate = BirthDate.Value;
            std.Email = txtEmail.Text;
            std.PhoneNumber = txtPhoneNumber.Text;
            std.Faculty = txtFaculty.Text;
            std.FacultyStartYear = Convert.ToInt32(maskedTxtFacultyStartYear.Text);
            std.Remarks = txtRemarks.Text;

            dao.AddStudent(std);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
