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
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Practica.StudentsOrganizer.View
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm,IMainForm
    {
        public IStudentForm CreateAddStudentForm()
        {
            return new StudentForm();
        }

        private MainController controller;

       public GridControl GridControl1
       {
            get
            {
                return gridControl1;
            }
        }
        public GridView GridView1
        {
            get
            {
                return gridView1;
            }
        }
        public BarButtonItem BtnAdd
        {
            get
            {
                return btnAdd;
            }
           
        }
        


        public BarButtonItem BtnOpen
        {
            get
            {
                return btnAdd;
            }
           
        }

        public BarButtonItem BtnDelete
        {
            get
            {
                return btnAdd;
            }
           
        }

        public MainForm()
        {
            InitializeComponent();

            controller = new MainController(this);
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            controller.LoadMainForm();
           // StudentDAO dao = new StudentDAO();
            //DataTable dt = dao.GetAllStudents();
            //gridControl1.DataSource = dt;
        }

        public void RefreshForm()
        {
            controller.Refresh();
           // StudentDAO dao = new StudentDAO();
           // DataTable dt = dao.GetAllStudents();
           // gridControl1.DataSource = dt;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            controller.Add();
          // StudentForm stdForm = new StudentForm();
         //  stdForm.ShowDialog();
            
            RefreshForm();
        }

        private void btnOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //   int selectedRow = gridView1.FocusedRowHandle;
            //  int Id = Convert.ToInt32(gridView1.GetRowCellValue(selectedRow, "ID"));

            // StudentBO st = new StudentBO();
            //   StudentDAO dao = new StudentDAO();
            //  st=dao.getStudentById(Id);


            // StudentForm stdForm = new StudentForm();
            // stdForm.Student = st;
            //  stdForm.ShowDialog();
            controller.Open();
            RefreshForm();

        }



        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //  int selectedRow = gridView1.FocusedRowHandle;
            //  int Id = Convert.ToInt32(gridView1.GetRowCellValue(selectedRow, "ID"));

            //  StudentDAO dao = new StudentDAO();
            // dao.DeleteStudent(Id);

            controller.Delete();
            RefreshForm();
        }
    }
}