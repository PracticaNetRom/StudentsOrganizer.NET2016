using Practica.StudentsOrganizer.Model;
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

namespace Practica.StudentsOrganizer.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonUpdateStd_Click(object sender, EventArgs e)
        {
            AddStudentForm stdForm = new AddStudentForm();
           
            StudentDAO stdselectDAO = new StudentDAO();

            int idSelect;
            idSelect = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id"));


            StudentBO stdSelectBO = stdselectDAO.GetStudent(idSelect);

            stdForm.PopulateStudent(stdSelectBO);

            stdForm.ShowDialog();

            RefreshData();
        }


        private void grdCtrlStudents_Click(object sender, EventArgs e)
        {
            
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshData();

        }


        private void buttInsertStd_Click(object sender, EventArgs e)
        {
            AddStudentForm stdForm = new AddStudentForm();

            stdForm.ShowDialog();

            RefreshData();
        }


        private void buttDeleteStd_Click(object sender, EventArgs e)
        {
            int selectedRow = gridView1.FocusedRowHandle;
            int id = Convert.ToInt32(gridView1.GetRowCellValue(selectedRow, "id"));
            
            StudentDAO stdDelete = new StudentDAO();
            stdDelete.DeleteStudent(id);

            MessageBox.Show("Student successfully deleted!");

            RefreshData();


        }

        private void RefreshData()
        {
            StudentDAO studDAO = new StudentDAO();

            DataTable dtret = new DataTable();
            dtret = studDAO.GetAllStudents();

            grdCtrlStudents.DataSource = dtret;
        }
    }
}
