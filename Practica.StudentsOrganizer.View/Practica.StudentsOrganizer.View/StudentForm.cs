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
            if (textFirstName.Text == "")
            {
                MessageBox.Show("Nu ati introdus FistName!!");
                return;
            }

            if (textLastName.Text == "")
            {
                MessageBox.Show("Nu ati introdus LastName");
                return;
            }

            if (textBirthDate.Text == "")
            {
                MessageBox.Show("Nu ati introdus BirthDate");
                return;
            }

            if (textPhoneNumbers.Text=="")
            {
                MessageBox.Show("Nu ati introdus PhoneNumbers");
                return;
            }

            if (textFaculty.Text == "")
            {
                MessageBox.Show("Nu ati introdus Faculty");
                return;
            }


            NewStudentBO.FirstName = textFirstName.Text;
            NewStudentBO.LastName = textFirstName.Text;
            NewStudentBO.Gender = textGender.Text;
            NewStudentBO.BirthDate = textBirthDate.DateTime;
            NewStudentBO.Email = textEmail.Text;
            NewStudentBO.PhoneNumbers = textPhoneNumbers.Text;
            NewStudentBO.PhoneHomeNumbers = textPhoneHomeNumbers.Text;
            NewStudentBO.FacultyStarYear =Convert.ToInt32(textFacultyStartYear.Text);
            NewStudentBO.Faculty = textFaculty.Text;
            NewStudentBO.Remarks = textRemarks.Text;

            NewStudentDAO.AddStud(NewStudentBO);

        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void textFaculty_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
