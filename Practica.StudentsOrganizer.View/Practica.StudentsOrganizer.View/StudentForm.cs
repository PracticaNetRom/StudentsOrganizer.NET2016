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
        private studentBO student;

        public StudentForm(studentBO stud)
        {
            this.student = stud;
            InitializeComponent();
        }

        private void CopyFormDataInObject(studentBO student)
        {
            student.FirstName = textFirstName.Text;
            student.LastName = textLastName.Text;
            student.Gender = textGender.Text;
            student.BirthDate = textBirthDate.DateTime;
            student.Email = textEmail.Text;
            student.PhoneNumbers = textPhoneNumbers.Text;
            student.PhoneHomeNumbers = textPhoneHomeNumbers.Text;
            student.FacultyStarYear = Convert.ToInt32(textFacultyStartYear.Text);
            student.Faculty = textFaculty.Text;
            student.Remarks = textRemarks.Text;
        }

        private void CopyObjectInData(studentBO student)
        {
            textFirstName.Text = student.FirstName;
            textLastName.Text = student.LastName;
            textGender.Text = student.Gender;
            textBirthDate.DateTime = student.BirthDate;
            textEmail.Text = student.Email;
            textPhoneNumbers.Text = student.PhoneNumbers;
            textPhoneHomeNumbers.Text = student.PhoneHomeNumbers;
            textFacultyStartYear.Text = Convert.ToString(student.FacultyStarYear);
            textFaculty.Text = student.Faculty;
            textRemarks.Text = student.Remarks;

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            if (this.student != null)
            {
                CopyObjectInData(student);

            }

            evenimentDAO ListEventDAO = new evenimentDAO();
            List<evenimentBO> events = ListEventDAO.GetAllEvents();
            lookUpEditEvent.Properties.DataSource= events;


            student_event_occurenceDAO ListEventOcc = new student_event_occurenceDAO();
            List<student_event_occurenceBO> eventOcc = ListEventOcc.GetAllEO();
            lookUpEditEventOc.Properties.DataSource=eventOcc;

        }

        private void btnSave_Click(object sender, EventArgs e)
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
               
                studDao.UpdateStud(student);
            }

        }

        private void textFacultyStartYear_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddChage_Click(object sender, EventArgs e)
        {


        }

        private void lookUpEditEvent_EditValueChanged(object sender, EventArgs e)
        {
            //Selected event from lookupEdit1

            evenimentBO selectedEvent =new evenimentBO();
            selectedEvent = (evenimentBO)lookUpEditEvent.GetSelectedDataRow();


            //Create EventOcurrence DAO and get all event ocurrences for selectedEvent.ID

            student_event_occurenceDAO selectedEventDAO = new student_event_occurenceDAO();
            List<student_event_occurenceBO> EventSelect = selectedEventDAO.Select_Student_Event(selectedEvent.IdEvent);




            //Populate retrieved List of event ocurrences into lookupEdit2

            lookUpEditEventOc.Properties.DataSource = EventSelect;
        }
    }
}
