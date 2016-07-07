
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
using Practice.StudentsOrganizer.Model;

namespace Practica.StudentsOrganizer.View
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StudentDAO dao = new StudentDAO();
            DataTable dt = dao.GetAllStudents();
            gridControl1.DataSource = dt;
        }

      //DevExpress.XtraBars.ItemClickEventArgs e
        

        private void btnAdd_ItemClick(object sender, EventArgs e)
        {
            StudentForm stdForm = new StudentForm();
            stdForm.Show();
        }

        private void btnOpen_ItemClick(object sender, EventArgs e)
        {
            int selectedRow = gridView1.FocusedRowHandle;
            int ID = Convert.ToInt32(gridView1.GetRowCellValue(selectedRow, "ID"));

            StudentBO student = new StudentBO();
            StudentDAO dao = new StudentDAO();
            student = dao.getStudentByID(ID);

            StudentForm stdForm = new StudentForm();
            stdForm.Student = student;
            stdForm.Show();
        }
    }
}
