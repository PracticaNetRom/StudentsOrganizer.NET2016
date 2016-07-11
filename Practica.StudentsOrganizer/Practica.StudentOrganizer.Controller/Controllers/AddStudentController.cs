using Practica.StudentOrganizer.Controller.Interfaces;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentOrganizer.Controller.Controllers
{
    public class AddStudentController
    {
        private IAddStudentForm _form;

        
        public AddStudentController(IAddStudentForm form)
        {
            _form = form;
        }
        
        
        public void AddOrUpdate()
        {
            StudentBO stdBO = new StudentBO();
            StudentDAO stdDAO = new StudentDAO();
            

            stdBO.firstName = _form.TxtFirstName.Text;
            stdBO.lastName = _form.TxtLastName.Text;
            stdBO.gender = _form.ComboBoxGender.Text;
            stdBO.birthDate = _form.DateTimeBirthDate.DateTime;
            stdBO.email = _form.TxtEmail.Text;
            stdBO.phoneNumber = _form.TxtPhoneNumber.Text;
            stdBO.faculty = _form.TxtFaculty.Text;
            stdBO.facultyStartYear = Convert.ToInt32(_form.TxtFacultyStartYear.Text);
            stdBO.remarks = _form.TxtRemarks.Text;



            if (student == null)  //Add
            {
                stdBO = new StudentBO();
            }
            else        //Update
            {
                stdBO = student;
            }


            if (string.IsNullOrEmpty(_form.TxtFirstName.Text))
            {
                MessageBox.Show("Please enter student's FIRST NAME!");
                return;
            }
            else
            {
                stdBO.firstName = _form.TxtFirstName.Text;
            }


            if (string.IsNullOrEmpty(_form.TxtLastName.Text))
            {
                MessageBox.Show("Please enter student's LAST NAME!");
                return;
            }
            else
            {
                stdBO.lastName = _form.TxtLastName.Text;
            }


            stdBO.gender = _form.ComboBoxGender.Text;


            if (string.IsNullOrEmpty(_form.DateTimeBirthDate.Text))
            {
                MessageBox.Show("Please enter student's BIRTH DATE!");
                return;
            }
            else
            {
                stdBO.birthDate = Convert.ToDateTime(_form.DateTimeBirthDate.Text);
            }

            if (string.IsNullOrEmpty(_form.TxtEmail.Text))
            {
                MessageBox.Show("Please enter student's EMAIL");
                return;
            }
            else
            {
                stdBO.email = _form.TxtEmail.Text;
            }


            stdBO.phoneNumber = _form.TxtPhoneNumber.Text;


            if (string.IsNullOrEmpty(_form.TxtFaculty.Text))
            {
                MessageBox.Show("Please enter student's FACULTY!");
                return;
            }
            else
            {
                stdBO.faculty = _form.TxtFaculty.Text;
            }


            if (string.IsNullOrEmpty(_form.TxtFacultyStartYear.Text))
            {
                MessageBox.Show("Please enter student's FACULTY START YEAR!");
                return;
            }
            else
            {
                stdBO.facultyStartYear = Convert.ToInt32(_form.TxtFacultyStartYear.Text);
            }

            stdBO.remarks = _form.TxtRemarks.Text;


            if (student == null)      // Add
            {
                stdDAO.AddStudent(stdBO);
                MessageBox.Show("Student successfully added!");
            }
            else              // Update
            {
                stdDAO.updateStudent(stdBO);
                MessageBox.Show("Student successfully updated!");
                // this.Close();
            }

            _form.TxtFirstName.Text = string.Empty;
            _form.TxtLastName.Text = string.Empty;
            _form.ComboBoxGender.Text = string.Empty;
            _form.ComboBoxGender.Text = string.Empty;
            _form.DateTimeBirthDate.Text = string.Empty;
            _form.TxtEmail.Text = string.Empty;
            _form.TxtPhoneNumber.Text = string.Empty;
            _form.TxtFaculty.Text = string.Empty;
            _form.TxtFacultyStartYear.Text = string.Empty;
            _form.TxtRemarks.Text = string.Empty;
        }

        public StudentBO student;


        public void PopulateStudent(StudentBO s)
        {
            _form.TxtFirstName.Text = s.firstName;
            _form.TxtLastName.Text = s.lastName;
            _form.ComboBoxGender.Text = s.gender;
            _form.DateTimeBirthDate.DateTime = s.birthDate;
            _form.TxtEmail.Text = s.email;
            _form.TxtPhoneNumber.Text = s.phoneNumber;
            _form.TxtFaculty.Text = s.faculty;
            _form.TxtFacultyStartYear.Text = Convert.ToString(s.facultyStartYear);
            _form.TxtRemarks.Text = s.remarks;

            student = s;
        }
    }
}
