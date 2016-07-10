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
<<<<<<< HEAD
        //studentBO StudReceived;
        public StudentForm()
        {
           // StudReceived = Stud;
=======
        private studentBO student;
        public StudentForm(studentBO stud)
        {
            this.student = stud;
>>>>>>> origin/D.Puscu
            InitializeComponent();

        }

        private void CopyObjectInForm(studentBO student)
        {
            
        }

        private void CopyFormDataInObject(studentBO student)
        {
            student.FirstName = textFirstName.Text;
            student.LastName = textFirstName.Text;
            student.Gender = textGender.Text;
            student.BirthDate = textBirthDate.DateTime;
            student.Email = textEmail.Text;
            student.PhoneNumbers = textPhoneNumbers.Text;
            student.PhoneHomeNumbers = textPhoneHomeNumbers.Text;
            student.FacultyStarYear = Convert.ToInt32(textFacultyStartYear.Text);
            student.Faculty = textFaculty.Text;
            student.Remarks = textRemarks.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDAO studDao = new StudentDAO();

            if (this.student == null)
            {
                student = new studentBO();

                CopyFormDataInObject(student);

                studDao.AddStud(student);                
            }
            else
            {
<<<<<<< HEAD
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
                NewStudentBO.FacultyStarYear = Convert.ToInt32(textFacultyStartYear.Text);
                NewStudentBO.Faculty = textFaculty.Text;
                NewStudentBO.Remarks = textRemarks.Text;

                NewStudentDAO.AddStud(NewStudentBO);
            
 
            
=======
                CopyFormDataInObject(student);

                studDao.UpdateStud(student);
            }
>>>>>>> origin/D.Puscu
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            if (this.student != null)
            {

            }
        }
    }
}
