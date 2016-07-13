
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class AddEditStudentForm : Form, IAddEditStudentsForm
    {
        private CtrlAddEditStudentsForm Controller;

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
        public GridControl _gridControl1
        {
            get
            {
                return gridControl1;
            }
        }
        public SimpleButton _AddEOButton
        {
            get
            {
                return AddEOButton;
            }
        }

        Students_BO StudReceived;
        Students_DAO Student_DAO = new Students_DAO();
        Students_BO Std = new Students_BO();

        public AddEditStudentForm(Students_BO Stud)
        {
            Controller = new CtrlAddEditStudentsForm(this);
            StudReceived = Stud;
            InitializeComponent();
        }
        
        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            Controller.Load(StudReceived);
        }

      
        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            Controller.SaveStud(StudReceived);
            this.Close();
        }
        

        //private void maskedFaculty_Start_Year_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //char ch = e.KeyChar;
        //    //if (!Char.IsDigit(ch) && ch != 8)
        //    //{
        //    //    e.Handled = true;
        //    //}
        //}

        private void ShowstudentsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Controller.Load_EO();
        }

        private void AddEOButton_Click(object sender, EventArgs e)
        {
            Controller.AddEvent();

        }
    }
}