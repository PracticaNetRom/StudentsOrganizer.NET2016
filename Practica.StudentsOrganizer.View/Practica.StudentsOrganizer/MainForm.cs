using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Practica.StudentsOrganizer;
using Practica.StudentsOrganizer.Control;
using Practica.StudentsOrganizer.Control.Interfaces;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.DAO;
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

namespace Practica.StudentsOrganizer
{
    public partial class MainForm : Form, IMainForm
    {
        private CtrlMainForm Controller;
        public SimpleButton _show_Students_Button
        {
            get
            {
                return Show_Students_Button;
            }
        }

        public SimpleButton _add_Stud_Button
        {
            get
            {
                return Add_Stud_Button;
            }
        }

        public SimpleButton _edit_Stud_Button
        {
            get
            {
                return Edit_Stud_Button;
            }
        }

        public SimpleButton _del_Stud_Button
        {
            get
            {
                return Del_Stud_Button;
            }
        }

        public SimpleButton _eventsButton
        {
            get
            {
                return EventsButton;
            }
        }

        public SimpleButton _eOButton
        {
            get
            {
                return EOButton;
            }
        }

        public SimpleButton _sEOButton
        {
            get
            {
                return SEOButton;
            }
        }

        public GridControl _gridControl1
        {
            get
            {
                return gridControl1;
            }
        }

        public GridView _gridView1
        {
            get
            {
                return gridView1;
            }
        }

        public IAddEditStudentsForm CreateAdd(Students_BO STD)
        {
            return new AddEditStudentForm(STD);
        }

        public MainForm()
        {
            InitializeComponent();
            Controller = new CtrlMainForm(this);
        }

        private void ShowStudentsForm_Load(object sender, EventArgs e)
        {
            //Students_DAO Std_DAO = new Students_DAO();
            //gridControl1.DataSource = Std_DAO.GetAllStudents();
            Controller.ShowAtLoadTime();
        }

        private void Show_Students_Button_Click(object sender, EventArgs e)
        {
            //Students_DAO Std_DAO = new Students_DAO();
            //gridControl1.DataSource = Std_DAO.GetAllStudents();
            Controller.ShowStd();
        }

        private void Add_Stud_Button_Click(object sender, EventArgs e)
        {
            //AddEditStudentForm Add_Std_Form = new AddEditStudentForm(null);
            //Add_Std_Form.ShowDialog();
            Controller.Add_Std();
        }

        private void Edit_Stud_Button_Click(object sender, EventArgs e)
        {
            //AddEditStudentForm Add_Std_Form = new AddEditStudentForm((Students_BO)gridView1.GetFocusedRow());
            //Add_Std_Form.ShowDialog();
            Controller.Edit_Std();
        }

        private void Del_Stud_Button_Click(object sender, EventArgs e)
        {
            //Students_BO Del_Stud;
            //Del_Stud = ((Students_BO)gridView1.GetFocusedRow());
            //Students_DAO Del_Stud_DAO = new Students_DAO();
            //Del_Stud_DAO.DeleteStd_ByFirstName(Del_Stud);
            Controller.Del_Stud();
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            AddEventForm Add_Ev = new AddEventForm();
            Add_Ev.ShowDialog();
        }

        private void EOButton_Click(object sender, EventArgs e)
        {
            TestEO EO = new TestEO();
            EO.ShowDialog();
        }

        private void SEOButton_Click(object sender, EventArgs e)
        {
            testSEOForm SEO = new testSEOForm();
            SEO.ShowDialog();
        }
    }
}
