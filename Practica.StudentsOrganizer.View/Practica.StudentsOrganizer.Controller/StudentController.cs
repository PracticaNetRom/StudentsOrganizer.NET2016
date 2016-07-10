using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentsOrganizer.Controller
{
    public class StudentController
    {
        private IStudentForm _form;
        public StudentBO Student { get; set; }

        public StudentController(IStudentForm form)
        {
            _form = form;
        }

        public void Add_Update()
        {
            StudentBO std = new StudentBO();
            StudentDAO dao = new StudentDAO();

            if (_form.Student == null)    // Add
            {
                if (string.IsNullOrEmpty(_form.txtFirstName.Text))
                {
                    MessageBox.Show("Please enter student's first name!");
                    return;
                }
                else
                {
                    std.FirstName = _form.txtFirstName.Text;
                }

                if (string.IsNullOrEmpty(_form.txtLastName.Text))
                {
                    MessageBox.Show("Please enter student's last name!");
                    return;
                }
                else
                {
                    std.LastName = _form.txtLastName.Text;
                }

                if (string.IsNullOrEmpty(_form.Gender.Text))
                {
                    MessageBox.Show("Please enter student's gender!");
                    return;
                }
                else
                {
                    std.Gender = _form.Gender.Text;
                }

                std.BirthDate = _form.BirthDate.DateTime;

                if (string.IsNullOrEmpty(_form.txtEmail.Text))
                {
                    MessageBox.Show("Please enter student's Email!");
                    return;
                }
                else
                {
                    std.Email = _form.txtEmail.Text;
                }

                if (string.IsNullOrEmpty(_form.txtPhoneNumber.Text))
                {
                    MessageBox.Show("Please enter student's phone number!");
                    return;
                }
                else
                {
                    std.PhoneNumber = _form.txtPhoneNumber.Text;
                }

                if (string.IsNullOrEmpty(_form.txtFaculty.Text))
                {
                    MessageBox.Show("Please enter student's faculty!");
                    return;
                }
                else
                {
                    std.Faculty = _form.txtFaculty.Text;
                }

                if (string.IsNullOrEmpty(_form.txtFacultyStartYear.Text))
                {
                    MessageBox.Show("Please enter student's faculty start year!");
                    return;
                }
                else
                {
                    std.FacultyStartYear = Convert.ToInt32(_form.txtFacultyStartYear.Text);
                }

                std.Remarks = _form.txtRemarks.Text;

                dao.AddStudent(std);

                MessageBox.Show("Student successfully added!");

                //Close();
            }

            else   //Update
            {
                if (string.IsNullOrEmpty(_form.txtFirstName.Text))
                {
                    MessageBox.Show("Please enter student's first name!");
                    return;
                }
                else
                {
                    Student.FirstName = _form.txtFirstName.Text;
                }

                if (string.IsNullOrEmpty(_form.txtLastName.Text))
                {
                    MessageBox.Show("Please enter student's last name!");
                    return;
                }
                else
                {
                    Student.LastName = _form.txtLastName.Text;
                }

                if (string.IsNullOrEmpty(_form.Gender.Text))
                {
                    MessageBox.Show("Please enter student's gender!");
                    return;
                }
                else
                {
                    Student.Gender = _form.Gender.Text;
                }

                Student.BirthDate = _form.BirthDate.DateTime;

                if (string.IsNullOrEmpty(_form.txtEmail.Text))
                {
                    MessageBox.Show("Please enter student's Email!");
                    return;
                }
                else
                {
                    Student.Email = _form.txtEmail.Text;
                }

                if (string.IsNullOrEmpty(_form.txtPhoneNumber.Text))
                {
                    MessageBox.Show("Please enter student's phone number!");
                    return;
                }
                else
                {
                    Student.PhoneNumber = _form.txtPhoneNumber.Text;
                }

                if (string.IsNullOrEmpty(_form.txtFaculty.Text))
                {
                    MessageBox.Show("Please enter student's faculty!");
                    return;
                }
                else
                {
                    Student.Faculty = _form.txtFaculty.Text;
                }

                if (string.IsNullOrEmpty(_form.txtFacultyStartYear.Text))
                {
                    MessageBox.Show("Please enter student's faculty start year!");
                    return;
                }
                else
                {
                    Student.FacultyStartYear = Convert.ToInt32(_form.txtFacultyStartYear.Text);
                }

                Student.Remarks = _form.txtRemarks.Text;

                dao.UpdateStudent(Student);

                MessageBox.Show("Student successfully updated!");

                //Close();
            }
        }

        public void LoadStudentForm()
        {
            if (Student != null)
            {
                _form.txtFirstName.Text = Student.FirstName;
                _form.txtLastName.Text = Student.LastName;
                _form.Gender.Text = Student.Gender;
                _form.BirthDate.DateTime = Student.BirthDate;
                _form.txtEmail.Text = Student.Email;
                _form.txtPhoneNumber.Text = Student.PhoneNumber;
                _form.txtFaculty.Text = Student.Faculty;
                _form.txtFacultyStartYear.Text = Convert.ToString(Student.FacultyStartYear);
                _form.txtRemarks.Text = Student.Remarks;
            }
        }

        }
    }
}
