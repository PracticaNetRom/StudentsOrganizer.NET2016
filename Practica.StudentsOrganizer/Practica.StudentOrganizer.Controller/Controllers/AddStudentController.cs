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
            

            stdBO.firstName = _form.txtFirstName.Text;
            stdBO.lastName = _form.txtLastName.Text;
            stdBO.gender = _form.comboBoxGender.Text;
            stdBO.birthDate = _form.dateTimeBirthDate.DateTime;
            stdBO.email = _form.txtEmail.Text;
            stdBO.phoneNumber = _form.txtPhoneNumber.Text;
            stdBO.faculty = _form.txtFaculty.Text;
            stdBO.facultyStartYear = Convert.ToInt32(_form.txtFacultyStartYear.Text);
            stdBO.remarks = _form.txtRemarks.Text;



            if (student == null)  //Add
            {
                stdBO = new StudentBO();
            }
            else        //Update
            {
                stdBO = student;
            }


            if (string.IsNullOrEmpty(_form.txtFirstName.Text))
            {
                MessageBox.Show("Please enter student's FIRST NAME!");
                return;
            }
            else
            {
                stdBO.firstName = _form.txtFirstName.Text;
            }


            if (string.IsNullOrEmpty(_form.txtLastName.Text))
            {
                MessageBox.Show("Please enter student's LAST NAME!");
                return;
            }
            else
            {
                stdBO.lastName = _form.txtLastName.Text;
            }


            stdBO.gender = _form.comboBoxGender.Text;


            if (string.IsNullOrEmpty(_form.dateTimeBirthDate.Text))
            {
                MessageBox.Show("Please enter student's BIRTH DATE!");
                return;
            }
            else
            {
                stdBO.birthDate = Convert.ToDateTime(_form.dateTimeBirthDate.Text);
            }

            if (string.IsNullOrEmpty(_form.txtEmail.Text))
            {
                MessageBox.Show("Please enter student's EMAIL");
                return;
            }
            else
            {
                stdBO.email = _form.txtEmail.Text;
            }


            stdBO.phoneNumber = _form.txtPhoneNumber.Text;


            if (string.IsNullOrEmpty(_form.txtFaculty.Text))
            {
                MessageBox.Show("Please enter student's FACULTY!");
                return;
            }
            else
            {
                stdBO.faculty = _form.txtFaculty.Text;
            }


            if (string.IsNullOrEmpty(_form.txtFacultyStartYear.Text))
            {
                MessageBox.Show("Please enter student's FACULTY START YEAR!");
                return;
            }
            else
            {
                stdBO.facultyStartYear = Convert.ToInt32(_form.txtFacultyStartYear.Text);
            }

            stdBO.remarks = _form.txtRemarks.Text;


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

            _form.txtFirstName.Text = string.Empty;
            _form.txtLastName.Text = string.Empty;
            _form.comboBoxGender.Text = string.Empty;
            _form.comboBoxGender.Text = string.Empty;
            _form.dateTimeBirthDate.Text = string.Empty;
            _form.txtEmail.Text = string.Empty;
            _form.txtPhoneNumber.Text = string.Empty;
            _form.txtFaculty.Text = string.Empty;
            _form.txtFacultyStartYear.Text = string.Empty;
            _form.txtRemarks.Text = string.Empty;
        }

        StudentBO student;


        public void PopulateStudent(StudentBO s)
        {
            _form.txtFirstName.Text = s.firstName;
            _form.txtLastName.Text = s.lastName;
            _form.comboBoxGender.Text = s.gender;
            _form.dateTimeBirthDate.DateTime = s.birthDate;
            _form.txtEmail.Text = s.email;
            _form.txtPhoneNumber.Text = s.phoneNumber;
            _form.txtFaculty.Text = s.faculty;
            _form.txtFacultyStartYear.Text = Convert.ToString(s.facultyStartYear);
            _form.txtRemarks.Text = s.remarks;

            student = s;
        }
    }
}
