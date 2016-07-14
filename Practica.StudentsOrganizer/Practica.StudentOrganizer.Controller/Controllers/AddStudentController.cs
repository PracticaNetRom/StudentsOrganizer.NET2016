using Practica.StudentOrganizer.Controller.Interfaces;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.BO;
using Practica.StudentsOrganizer.Model.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentOrganizer.Controller.Controllers
{
    public class AddStudentController
    {
        private IAddStudentForm stdForm;

        
        public AddStudentController(IAddStudentForm form)
        {
            stdForm = form;
        }
        
        
        public void AddOrUpdate()
        {
            StudentBO stdBO = new StudentBO();
            StudentDAO stdDAO = new StudentDAO();
            
            stdBO.firstName = stdForm.TxtFirstName.Text;
            stdBO.lastName = stdForm.TxtLastName.Text;
            stdBO.gender = stdForm.ComboBoxGender.Text;
            stdBO.birthDate = stdForm.DateTimeBirthDate.DateTime;
            stdBO.email = stdForm.TxtEmail.Text;
            stdBO.phoneNumber = stdForm.TxtPhoneNumber.Text;
            stdBO.faculty = stdForm.TxtFaculty.Text;
            stdBO.facultyStartYear = Convert.ToInt32(stdForm.TxtFacultyStartYear.Text);
            stdBO.remarks = stdForm.TxtRemarks.Text;
            
            if (student == null)  //Add
            {
                stdBO = new StudentBO();
            }
            else        //Update
            {
                stdBO = student;
            }


            if (string.IsNullOrEmpty(stdForm.TxtFirstName.Text) || stdForm.TxtFirstName.Text.Length < 2)
            {
                MessageBox.Show("Please enter student's FIRST NAME!");
                return;
            }
            else
            {
                stdBO.firstName = stdForm.TxtFirstName.Text;
            }

            if (string.IsNullOrEmpty(stdForm.TxtLastName.Text) || stdForm.TxtLastName.Text.Length < 2 )
            {
                MessageBox.Show("Please enter student's LAST NAME!");
                return;
            }
            else
            {
                stdBO.lastName = stdForm.TxtLastName.Text;
            }

            stdBO.gender = stdForm.ComboBoxGender.Text;

            if (string.IsNullOrEmpty(stdForm.DateTimeBirthDate.Text))
            {
                MessageBox.Show("Please enter student's BIRTH DATE!");
                return;
            }
            else
            {
                stdBO.birthDate = Convert.ToDateTime(stdForm.DateTimeBirthDate.Text);
            }

            if (string.IsNullOrEmpty(stdForm.TxtEmail.Text) || stdForm.TxtEmail.Text.Length < 10)
            {
                MessageBox.Show("Please enter student's EMAIL");
                return;
            }
            else
            {
                stdBO.email = stdForm.TxtEmail.Text;
            }

            stdBO.phoneNumber = stdForm.TxtPhoneNumber.Text;

            if (string.IsNullOrEmpty(stdForm.TxtFaculty.Text) || stdForm.TxtFaculty.Text.Length < 3)
            {
                MessageBox.Show("Please enter student's FACULTY!");
                return;
            }
            else
            {
                stdBO.faculty = stdForm.TxtFaculty.Text;
            }

            if (string.IsNullOrEmpty(stdForm.TxtFacultyStartYear.Text))
            {
                MessageBox.Show("Please enter student's FACULTY START YEAR!");
                return;
            }
            else
            {
                stdBO.facultyStartYear = Convert.ToInt32(stdForm.TxtFacultyStartYear.Text);
            }

            stdBO.remarks = stdForm.TxtRemarks.Text;


            if (student == null)      // Add
            {
                stdDAO.AddStudent(stdBO);
                MessageBox.Show("Student successfully added!");
            }
            else              // Update
            {
                stdDAO.updateStudent(stdBO);
                MessageBox.Show("Student successfully updated!");
            }

            stdForm.TxtFirstName.Text = string.Empty;
            stdForm.TxtLastName.Text = string.Empty;
            stdForm.ComboBoxGender.Text = string.Empty;
            stdForm.ComboBoxGender.Text = string.Empty;
            stdForm.DateTimeBirthDate.Text = string.Empty;
            stdForm.TxtEmail.Text = string.Empty;
            stdForm.TxtPhoneNumber.Text = string.Empty;
            stdForm.TxtFaculty.Text = string.Empty;
            stdForm.TxtFacultyStartYear.Text = string.Empty;
            stdForm.TxtRemarks.Text = string.Empty;
        }


        public void AddEvent()
        {
            string ev = stdForm.ComboBoxEventName.Text;

            EventOccurenceBO evo = (EventOccurenceBO)(stdForm.ComboBoxEvtOccur.GetSelectedDataRow());
        }


        public StudentBO student;


        public void PopulateStudent(StudentBO s)
        {
            stdForm.TxtFirstName.Text = s.firstName;
            stdForm.TxtLastName.Text = s.lastName;
            stdForm.ComboBoxGender.Text = s.gender;
            stdForm.DateTimeBirthDate.DateTime = s.birthDate;
            stdForm.TxtEmail.Text = s.email;
            stdForm.TxtPhoneNumber.Text = s.phoneNumber;
            stdForm.TxtFaculty.Text = s.faculty;
            stdForm.TxtFacultyStartYear.Text = Convert.ToString(s.facultyStartYear);
            stdForm.TxtRemarks.Text = s.remarks;

            student = s;
        }


        public void PopulateEvents()
        {
            EvenimentDAO eventselectDAO = new EvenimentDAO ();

            DataTable dtEven = eventselectDAO.GetAllEvents();

            stdForm.ComboBoxEventName.Properties.DataSource = dtEven ;

            stdForm.ComboBoxEventName.Properties.DisplayMember = "eventName";
            stdForm.ComboBoxEventName.Properties.ValueMember = "id";
        }


        public void PopulateEventOccurence()
        {
            int id = Convert.ToInt32(stdForm.ComboBoxEventName.EditValue);

            EventOccurenceDAO eventselectDAO = new EventOccurenceDAO();

            List<EventOccurenceBO> dtEven = eventselectDAO.GetEventOccurence(id);

            stdForm.ComboBoxEvtOccur.Properties.DataSource = dtEven;

            stdForm.ComboBoxEvtOccur.Properties.DisplayMember = "DisplayValue";
            stdForm.ComboBoxEvtOccur.Properties.ValueMember = "id";
        }

    }
}
