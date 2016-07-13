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

        private void button1_Click(object sender, EventArgs e)
        {
        studentBO NewStudentBO = new studentBO();
        StudentDAO NewStudentDAO = new StudentDAO();


            NewStudentBO.FirstName = textFirstName.Text;
            NewStudentBO.LastName = textFirstName.Text;
            NewStudentBO.Gender = textGender.Text;
            NewStudentBO.BirthDate = Convert.ToDateTime(textBirthDate.Text);
            NewStudentBO.Email = textEmail.Text;
            NewStudentBO.PhoneNumbers = textPhoneNumbers.Text;
            NewStudentBO.PhoneHomeNumbers = textPhoneHomeNumbers.Text;
            NewStudentBO.FacultyStarYear = Convert.ToInt32(textFacultyStartYear.Text);
            NewStudent.Faculty_Start_Year = Convert.ToInt32(maskedFacultyStartYear.Text);
            NewStudentBO.Faculty = textFaculty.Text;
            NewStudentBO.Remarks = textRemarks.Text;

            NewStudentDAO.AddStud(NewStudentBO);

            textFirstName.Clear();

        }
            

        }

    private void maskedFacultyStartYear_KeyPress(object sender, KeyPressEventArgs e)
    {
        char ch = e.KeyChar;
        if (!Char.IsDigit(ch) && ch != 8)
        {
            e.Handled = true;
        }
    }
}

