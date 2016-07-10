using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Controller;

namespace Practica.StudentsOrganizer.View
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm, IMainForm
    {
        private MainController controller;
        public MainForm()
        {
            controller = new MainController(this);
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            controller.LoadMainForm();
            //StudentDAO dao = new StudentDAO();
            //DataTable dt = dao.GetAllStudents();
            //gridControl1.DataSource = dt;
        }

        public void RefreshForm()
        {
            controller.LoadMainForm();
            //StudentDAO dao = new StudentDAO();
            //DataTable dt = dao.GetAllStudents();
            //gridControl1.DataSource = dt;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            controller.Add();
            //StudentForm stdForm = new StudentForm();
            //stdForm.ShowDialog();
            
            RefreshForm();
        }

        private void btnOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            controller.Open();
            //int selectedRow = gridView1.FocusedRowHandle;
            //int Id = Convert.ToInt32(gridView1.GetRowCellValue(selectedRow, "Id"));

            //StudentBO st = new StudentBO();
            //StudentDAO dao = new StudentDAO();
            //st=dao.getStudentById(Id);

            //StudentForm stdForm = new StudentForm();
            //stdForm.Student = st;
            //stdForm.ShowDialog();

            RefreshForm();

        }



        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            controller.Delete();
            //int selectedRow = gridView1.FocusedRowHandle;
            //int Id = Convert.ToInt32(gridView1.GetRowCellValue(selectedRow, "Id"));

            //StudentDAO dao = new StudentDAO();
            //dao.DeleteStudent(Id);
           
            RefreshForm();
        }
    }
}