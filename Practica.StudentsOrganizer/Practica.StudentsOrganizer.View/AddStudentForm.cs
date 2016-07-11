using DevExpress.XtraEditors;
using Practica.StudentOrganizer.Controller.Controllers;
using Practica.StudentOrganizer.Controller.Interfaces;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.DAO;
using Practica.StudentsOrganizer.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica.StudentsOrganizer.View
{
    public partial class AddStudentForm : Form, IAddStudentForm
    {
        private AddStudentController controlerStd;


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

        public ComboBoxEdit ComboBoxGender
        {
            get
            {
                return comboBoxGender;
            }
        }

        public DateEdit DateTimeBirthDate
        {
            get
            {
                return dateTimeBirthDate;
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

        public TextEdit TxtFaculty
        {
            get
            {
                return txtFaculty;
            }
        }

        public TextEdit TxtFacultyStartYear
        {
            get
            {
                return txtFacultyStartYear;
            }
        }

        public TextEdit TxtRemarks
        {
            get
            {
                return txtRemarks;
            }
        }


        public AddStudentForm()
        {
            InitializeComponent();
            dateTimeBirthDate.Properties.MaxValue = DateTime.Now;
            dateTimeBirthDate.Properties.MinValue = DateTime.Now.AddYears(-50);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            controlerStd.AddOrUpdate();
        }

        public void PopulateStudent(StudentBO s)
        {
            controlerStd.PopulateStudent(s);
        }

       // StudentBO student;

       /* 
        public void PopulateStudent(StudentBO s)
        {
            txtFirstName.Text = s.firstName;
            txtLastName.Text = s.lastName;
            comboBoxGender.Text = s.gender;
            dateTimeBirthDate.DateTime = s.birthDate;
            txtEmail.Text = s.email;
            txtPhoneNumber.Text = s.phoneNumber;
            txtFaculty.Text = s.faculty;
            txtFacultyStartYear.Text = Convert.ToString(s.facultyStartYear);
            txtRemarks.Text = s.remarks;

            student = s;

        }
        
      */  

    }
}
