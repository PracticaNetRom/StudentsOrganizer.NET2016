using DevExpress.XtraGrid.Views.Grid;
using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                //Close();
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

                //Close();
            }
        }

        public void LoadStudentForm()
        {

            if (_form.Student != null)
            {
                _form.TxtFirstName.Text = _form.Student.FirstName;
                _form.TxtLastName.Text = _form.Student.LastName;
                _form.gender.Text = _form.Student.Gender;
                _form.birthDate.DateTime = _form.Student.BirthDate;
                _form.TxtEmail.Text = _form.Student.Email;
                _form.TxtPhoneNumber.Text = _form.Student.PhoneNumber;
                _form.TxtFaculty.Text = _form.Student.Faculty;
                _form.TxtFacultyStartYear.Text = Convert.ToString(_form.Student.FacultyStartYear);
                _form.TxtRemarks.Text = _form.Student.Remarks;
            }
        }

        public void PopulateEventDropDown()
        {
            EventDAO ev_dao = new EventDAO();
            _form.LookUpEdit1.Properties.DataSource = ev_dao.GetAllEvents();

        }

        public void PopulateEvent_OccurenceDropDown()
        {
            int id = Convert.ToInt32(_form.LookUpEdit1.EditValue);          
            Event_OccurenceDAO ev_occ_dao = new Event_OccurenceDAO();            
            _form.LookUpEdit2.Properties.DataSource = ev_occ_dao.GetAllEvent_Occurences(id);
            _form.LookUpEdit2.Properties.DisplayMember = "Start date";
            _form.LookUpEdit2.Properties.ValueMember = "Id";

        }

        public void RefreshEvents()
        {
            StudentDAO dao = new StudentDAO();
            int id = _form.Student.Id;
            DataTable dt = dao.SelectEventsAndOccurences(id);
            _form.GridControlEvent.DataSource = dt;
        }


        public void AddEventsAndOccurences()
        {
            
            Std_Event_OccurenceDAO dao_seo = new Std_Event_OccurenceDAO();
            Std_Event_OccurenceBO seo = new Std_Event_OccurenceBO();
            int id = this._form.Student.Id;
            seo.Id_Student = id;
            seo.Id_Event_Occurence = ((int)_form.LookUpEdit2.EditValue);
            dao_seo.AddStd_Event_Occurence(seo);

            RefreshEvents();
            
        }


        public void DeleteStd_Event_Occ()
        {
            int selectedRow = ((GridView)_form.GridControlEvent.MainView).FocusedRowHandle;
            int Id = Convert.ToInt32(((GridView)_form.GridControlEvent.MainView).GetRowCellValue(selectedRow, "Student Event Occ Id"));

            Std_Event_OccurenceDAO dao = new Std_Event_OccurenceDAO();
            dao.DeleteStd_Event_Occurence(Id);

            RefreshEvents();
        }

    }
}

