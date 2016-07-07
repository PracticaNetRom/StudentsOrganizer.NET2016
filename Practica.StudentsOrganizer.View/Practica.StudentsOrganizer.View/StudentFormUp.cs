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
    public partial class StudentFormUp : Form
    {
        public StudentFormUp()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                studentBO UpdateStudentBO = new studentBO();
                StudentDAO UpdateStudentDAO = new StudentDAO();
                if (labelFirstName.Text == "")
                {
                    MessageBox.Show("Nu ati introdus FistName!!");
                    return;
                }

                if (labelLastName.Text == "")
                {
                    MessageBox.Show("Nu ati introdus LastName");
                    return;
                }

                if (labelBirthDate.Text == "")
                {
                    MessageBox.Show("Nu ati introdus BirthDate");
                    return;
                }

                if (labelPhoneNumbers.Text == "")
                {
                    MessageBox.Show("Nu ati introdus PhoneNumbers");
                    return;
                }

                if (labelFaculty.Text == "")
                {
                    MessageBox.Show("Nu ati introdus Faculty");
                    return;
                }


                UpdateStudentBO.FirstName = labelFirstName.Text;
                UpdateStudentBO.LastName = labelFirstName.Text;
                UpdateStudentBO.Gender = labelGender.Text;
                UpdateStudentBO.BirthDate = dateBirthDate.DateTime;
                UpdateStudentBO.Email = textEmail.Text;
                UpdateStudentBO.PhoneNumbers = textPhoneNumbers.Text;
                UpdateStudentBO.PhoneHomeNumbers = textPhoneHomeNumbers.Text;
                UpdateStudentBO.FacultyStarYear = Convert.ToInt32(textFacultyStartYear.Text);
                UpdateStudentBO.Faculty = textFaculty.Text;
                UpdateStudentBO.Remarks = textRemarks.Text;

                UpdateStudentDAO.UpdateStud(UpdateStudentBO);



            }
        }
    }
}
