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
using DevExpress.XtraGrid;
using DevExpress.XtraBars;

namespace Practica.StudentsOrganizer.View
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm, IMainForm
    {
        public BarButtonItem BtnAdd {
            get
            {
                return btnAdd;
            }
        }
        public BarButtonItem BtnOpen {
            get
            {
                return btnOpen;
            }
        }
        public BarButtonItem BtnDelete {
            get
            {
                return btnDelete;
            }
        }
        public GridControl GridControl1 {
            get
            {
                return gridControl1;
            }
        }

        private MainController controller;
        
        public MainForm()
        {
            controller = new MainController(this);
            InitializeComponent();
        }

        public IStudentForm CreateStudentForm()
        {
            return new StudentForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            controller.RefreshStudents();
        }
        
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            controller.Add();
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

           // RefreshForm();

        }



        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            controller.Delete();
            //int selectedRow = gridView1.FocusedRowHandle;
            //int Id = Convert.ToInt32(gridView1.GetRowCellValue(selectedRow, "Id"));

            //StudentDAO dao = new StudentDAO();
            //dao.DeleteStudent(Id);
           
           // RefreshForm();
        }
    }
}