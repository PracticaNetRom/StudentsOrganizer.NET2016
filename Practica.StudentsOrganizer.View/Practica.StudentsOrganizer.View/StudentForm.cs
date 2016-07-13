using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Practica.StudentsOrganizer.Controller;
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
    public partial class StudentForm : Form, IStudentForm
    {
        private StudentController controller;
        public StudentBO Student { get; set; }

        public GridControl GridControlEvent
        {
            get
            {
                return gridControlEvent;
            }
        }
        public GridView GridViewEvent
        {
            get
            {
                return gridViewEvent;
            }
        }
        public LookUpEdit LookUpEditEvent
        {
            get
            {
                return lookUpEditEvent;
            }
        }
        public LookUpEdit LookUpEditOccurence
        {
            get
            {
                return lookUpEditOccurence;
            }
        }
        public TextEdit TxtFirstName
        {
            get
            {
                return txtFirstName;
            }
        }
        public TextEdit TxtLastName
        {
            get
            {
                return txtLastName;
            }
        }
        public TextEdit TxtFaculty
        {
            get
            {
                return txtFaculty;
            }
        }
        public TextEdit TxtRemarks
        {
            get
            {
                return txtRemarks;
            }
        }
        public TextEdit TxtEmail
        {
            get
            {
                return txtEmail;
            }
        }
        public TextEdit TxtPhoneNumber
        {
            get
            {
                return txtPhoneNumber;
            }
        }
        public ComboBoxEdit gender
        {
            get
            {
                return Gender;
            }
        }
      public  DateEdit birthDate
        {
            get
            {
                return BirthDate;
            }
            
        }
        public TextEdit TxtFacultyStartYear
        {
            get
            {
                return TxtFacultyStartYear;
            }
        }
        public StudentForm()
        {
            InitializeComponent();

            controller = new StudentController(this);

            BirthDate.Properties.MaxValue = DateTime.Now;
            BirthDate.Properties.MinValue = DateTime.Now.AddYears(-100);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            
            controller.Add_Update();
            
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            if (Student != null)
            {
                txtFirstName.Text = Student.FirstName;
                txtLastName.Text = Student.LastName;
                Gender.Text = Student.Gender;
                BirthDate.DateTime = Student.BirthDate;
                txtEmail.Text = Student.Email;
                txtPhoneNumber.Text = Student.PhoneNumber;
                txtFaculty.Text = Student.Faculty;
                txtFacultyStartYear.Text = Convert.ToString(Student.FacultyStartYear);
                txtRemarks.Text = Student.Remarks;
            }

            controller.LoadEvents();
           
        }

        private void lookUpEditEvent_EditValueChanged(object sender, EventArgs e)
        {    controller.LoadEventOccurence();
           
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            controller.GridControlEvents();
        }
    }
}
