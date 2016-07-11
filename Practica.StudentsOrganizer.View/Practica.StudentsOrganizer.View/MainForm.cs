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
            StudentDAO ListStudentDAO = new StudentDAO();
                        
            List<studentBO> students = ListStudentDAO.GetAllStudent();

            gridControlStudent.DataSource = students;
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            StudentForm btnNewStudent = new StudentForm(null);
            btnNewStudent.ShowDialog();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            studentBO student = (studentBO)gridView1.GetFocusedRow();
            StudentForm btnEditStudent = new StudentForm(student);
            btnEditStudent.ShowDialog();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            studentBO Del;
            Del = ((studentBO)gridView1.GetFocusedRow());
            StudentDAO DelDAO = new StudentDAO();
            DelDAO.DeleteStud(Del);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            StudentDAO ListStudentDAO = new StudentDAO();

            List<studentBO> students = ListStudentDAO.GetAllStudent();

            gridControlStudent.DataSource = students;
        }
    }
}