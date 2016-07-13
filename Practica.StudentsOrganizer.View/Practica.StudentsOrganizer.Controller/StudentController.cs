using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;

namespace Practica.StudentsOrganizer.Controller
{
    public class StudentController
    {
        private IStudentForm _form;

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
                if (string.IsNullOrEmpty(_form.TxtFirstName.Text))
                {
                    MessageBox.Show("Please enter student's first name!");
                    return;
                }
                else
                {
                    std.FirstName = _form.TxtFirstName.Text;
                }

                if (string.IsNullOrEmpty(_form.TxtLastName.Text))
                {
                    MessageBox.Show("Please enter student's last name!");
                    return;
                }
                else
                {
                    std.LastName = _form.TxtLastName.Text;
                }

                if (string.IsNullOrEmpty(_form.gender.Text))
                {
                    MessageBox.Show("Please enter student's gender!");
                    return;
                }
                else
                {
                    std.Gender = _form.gender.Text;
                }

                std.BirthDate = _form.birthDate.DateTime;

                if (string.IsNullOrEmpty(_form.TxtEmail.Text))
                {
                    MessageBox.Show("Please enter student's Email!");
                    return;
                }
                else
                {
                    std.Email = _form.TxtEmail.Text;
                }

                if (string.IsNullOrEmpty(_form.TxtPhoneNumber.Text))
                {
                    MessageBox.Show("Please enter student's phone number!");
                    return;
                }
                else
                {
                    std.PhoneNumber = _form.TxtPhoneNumber.Text;
                }

                if (string.IsNullOrEmpty(_form.TxtFaculty.Text))
                {
                    MessageBox.Show("Please enter student's faculty!");
                    return;
                }
                else
                {
                    std.Faculty = _form.TxtFaculty.Text;
                }

                if (string.IsNullOrEmpty(_form.TxtFacultyStartYear.Text))
                {
                    MessageBox.Show("Please enter student's faculty start year!");
                    return;
                }
                else
                {
                    std.FacultyStartYear = Convert.ToInt32(_form.TxtFacultyStartYear.Text);
                }

                std.Remarks = _form.TxtRemarks.Text;

                dao.AddStudent(std);

                MessageBox.Show("Student successfully added!");

                Close();
            }

            else   //Update
            {
                if (string.IsNullOrEmpty(_form.TxtFirstName.Text))
                {
                    MessageBox.Show("Please enter student's first name!");
                    return;
                }
                else
                {
                    _form.Student.FirstName = _form.TxtFirstName.Text;
                }

                if (string.IsNullOrEmpty(_form.TxtLastName.Text))
                {
                    MessageBox.Show("Please enter student's last name!");
                    return;
                }
                else
                {
                    _form.Student.LastName = _form.TxtLastName.Text;
                }

                if (string.IsNullOrEmpty(_form.gender.Text))
                {
                    MessageBox.Show("Please enter student's gender!");
                    return;
                }
                else
                {
                    _form.Student.Gender = _form.gender.Text;
                }

                _form.Student.BirthDate = _form.birthDate.DateTime;

                if (string.IsNullOrEmpty(_form.TxtEmail.Text))
                {
                    MessageBox.Show("Please enter student's Email!");
                    return;
                }
                else
                {
                    _form.Student.Email = _form.TxtEmail.Text;
                }

                if (string.IsNullOrEmpty(_form.TxtPhoneNumber.Text))
                {
                    MessageBox.Show("Please enter student's phone number!");
                    return;
                }
                else
                {
                    _form.Student.PhoneNumber = _form.TxtPhoneNumber.Text;
                }

                if (string.IsNullOrEmpty(_form.TxtFaculty.Text))
                {
                    MessageBox.Show("Please enter student's faculty!");
                    return;
                }
                else
                {
                    _form.Student.Faculty = _form.TxtFaculty.Text;
                }

                if (string.IsNullOrEmpty(_form.TxtFacultyStartYear.Text))
                {
                    MessageBox.Show("Please enter student's faculty start year!");
                    return;
                }
                else
                {
                    _form.Student.FacultyStartYear = Convert.ToInt32(_form.TxtFacultyStartYear.Text);
                }

                _form.Student.Remarks = _form.TxtRemarks.Text;

                dao.UpdateStudent(_form.Student);

                MessageBox.Show("Student successfully updated!");

                Close();
            }


        }

        private void Close()
        {
            throw new NotImplementedException();
        }
        public void LoadEvents()
        {
            EventDAO dao = new EventDAO();
            DataTable dt = dao.GetAllEvents();
            _form.LookUpEditEvent.Properties.DataSource = dt;
            _form.LookUpEditEvent.Properties.DisplayMember = "Name";
            _form.LookUpEditEvent.Properties.ValueMember = "ID";
        }
        public void LoadEventOccurence()
        {
            int idEvent;
            idEvent = Convert.ToInt32(_form.LookUpEditEvent.EditValue);

            Event_OccurenceDAO dao = new Event_OccurenceDAO();
            DataTable dt = dao.GetAllEventOccurence(idEvent);
            _form.LookUpEditOccurence.Properties.DataSource = dt;
            _form.LookUpEditOccurence.Properties.DisplayMember = "StartDate";
            _form.LookUpEditOccurence.Properties.ValueMember = "ID";
        }
        public void GridControlEvents()
        {
            

        }
    }
}
