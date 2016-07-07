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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       


        private void ShowStudentsForm_Load(object sender, EventArgs e)
        {
            Students_DAO Std_DAO = new Students_DAO();
            gridControl1.DataSource = Std_DAO.GetAllStudents();
        }

        

        private void Show_Students_Button_Click(object sender, EventArgs e)
        {
            Students_DAO Std_DAO = new Students_DAO();
            gridControl1.DataSource = Std_DAO.GetAllStudents();
        }

        private void Add_Stud_Button_Click(object sender, EventArgs e)
        {
            AddEditStudentForm Add_Std_Form = new AddEditStudentForm(null);
            Add_Std_Form.ShowDialog();
        }

        private void Edit_Stud_Button_Click(object sender, EventArgs e)
        {
            AddEditStudentForm Add_Std_Form = new AddEditStudentForm((Students_BO)gridView1.GetFocusedRow());
            Add_Std_Form.ShowDialog();
        }

        private void Del_Stud_Button_Click(object sender, EventArgs e)
        {
            Students_BO Del_Stud = new Students_BO();
            Students_DAO Del_Stud_DAO = new Students_DAO();
            Del_Stud_DAO.DeleteStd_ByFirstName(Del_Stud);
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
