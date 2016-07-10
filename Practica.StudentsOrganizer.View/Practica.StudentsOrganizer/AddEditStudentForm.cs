
using DevExpress.XtraEditors;
using Practica.StudentsOrganizer.Control.Controlers;
using Practica.StudentsOrganizer.Control.Interfaces;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.BO;
using Practica.StudentsOrganizer.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentsOrganizer
{
    public partial class AddEditStudentForm : Form, IaddEditStudetsForm
    {
        private CtrlAddEditStudentsForm Controler;
        public TextEdit _txtFirst_Name
        {
            get
            {
                return txtFirst_Name;
            }
        }
        public TextEdit _txtLast_Name
        {
            get
            {
                return txtLast_Name;
            }
        }
        public ComboBoxEdit _comboGender
        {
            get
            {
                return comboGender;
            }
        }
        public DateEdit _dateBirth_Date
        {
            get
            {
                return dateBirth_Date;
            }
        }
        public TextEdit _txtEmail
        {
            get
            {
                return txtEmail;
            }
        }
        public TextEdit _txtPhone
        {
            get
            {
                return txtPhone;
            }
        }
        public TextEdit _txtFaculty
        {
            get
            {
                return txtFaculty;
            }
        }
        public TextEdit _maskedFaculty_Start_Year
        {
            get
            {
                return maskedFaculty_Start_Year;
            }
        }
        public TextEdit _txtRemarks
        {
            get
            {
                return txtRemarks;
            }
        }
        public LookUpEdit _lookUpEdit1
        {
            get
            {
                return lookUpEdit1;
            }
        }
        public LookUpEdit _lookUpEdit2
        {
            get
            {
                return lookUpEdit2;
            }
        }


        Students_BO StudReceived;
        public AddEditStudentForm(Students_BO Stud)
        {
            Controler = new CtrlAddEditStudentsForm();
            StudReceived = Stud;
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            Events_DAO Ev_DAO = new Events_DAO();
            List<Events_BO> events = Ev_DAO.GetAllEvents();
            Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            List<Event_Occurence_BO> EO_BO = EO_DAO.GetAllEO();

            //foreach(Events_BO ev in events)
            //{
            //    comboBoxEdit1.Properties.Items.Add(ev);
            //}

            lookUpEdit1.Properties.DataSource = events;
            lookUpEdit2.Properties.DataSource = EO_BO;



            if (StudReceived != null)
            {
                txtFirst_Name.Text = StudReceived.First_Name;
                txtLast_Name.Text = StudReceived.Last_Name;
                comboGender.Text = StudReceived.Gender;
                dateBirth_Date.DateTime = StudReceived.Birth_Date;
                txtEmail.Text = StudReceived.Email;
                txtPhone.Text = StudReceived.Phone_Number.ToString(); ;
                txtFaculty.Text = StudReceived.Faculty.ToString(); ;
                maskedFaculty_Start_Year.Text = StudReceived.Faculty_Start_Year.ToString();
                txtRemarks.Text = StudReceived.Remarks;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            Students_DAO Student_DAO = new Students_DAO();
            if (StudReceived == null)//Add
            {
                Students_BO NewStudent = new Students_BO();
                
                NewStudent.First_Name = txtFirst_Name.Text;
                NewStudent.Last_Name = txtLast_Name.Text;
                NewStudent.Gender = comboGender.Text;
                NewStudent.Birth_Date = dateBirth_Date.DateTime;
                NewStudent.Email = txtEmail.Text;
                NewStudent.Phone_Number = txtPhone.Text;
                NewStudent.Faculty = txtFaculty.Text;
                NewStudent.Faculty_Start_Year = Convert.ToInt32(maskedFaculty_Start_Year.Text);
                NewStudent.Remarks = txtRemarks.Text;

                Student_DAO.AddStudent(NewStudent);
            }
            else //Edit
            {
                
                StudReceived.First_Name = txtFirst_Name.Text;
                StudReceived.Last_Name = txtLast_Name.Text;
                StudReceived.Gender = comboGender.Text;
                StudReceived.Birth_Date = dateBirth_Date.DateTime;
                StudReceived.Email = txtEmail.Text;
                StudReceived.Phone_Number = txtPhone.Text;
                StudReceived.Faculty = txtFaculty.Text;
                StudReceived.Faculty_Start_Year = Convert.ToInt32(maskedFaculty_Start_Year.Text);
                StudReceived.Remarks = txtRemarks.Text;

                Student_DAO.UpdateStud(StudReceived);
            }
            this.Close();
        }

        private void maskedFaculty_Start_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ShowstudentsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateBirth_Date_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}