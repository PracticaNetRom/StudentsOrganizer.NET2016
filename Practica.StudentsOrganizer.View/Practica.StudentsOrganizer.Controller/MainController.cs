using DevExpress.XtraGrid.Views.Grid;
using Practica.StudentsOrganizer.Controller;
using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentsOrganizer.Controller
{
    public class MainController
    {
        private IMainForm _form;       

        public MainController(IMainForm form)
        {
            _form = form;
        }
        public void RefreshStudents()
        {
            StudentDAO dao = new StudentDAO();
            DataTable dt = dao.GetAllStudents();
            _form.GridControl1.DataSource = dt;
        }

        public void Add()
        {
            IStudentForm studentForm = _form.CreateStudentForm();
            ((Form)studentForm).ShowDialog();

            RefreshStudents();
        }

        public void Open()
        {
            int selectedRow = ((GridView)_form.GridControl1.MainView).FocusedRowHandle;
            int Id = Convert.ToInt32(((GridView)_form.GridControl1.MainView).GetRowCellValue(selectedRow, "Id"));

            StudentBO st = new StudentBO();
            StudentDAO dao = new StudentDAO();
            st = dao.getStudentById(Id);

            IStudentForm stdForm = _form.CreateStudentForm();
            stdForm.Student = st;
            ((Form)stdForm).ShowDialog();

            RefreshStudents();
        }

        public void Delete()
        {
            int selectedRow = ((GridView)_form.GridControl1.MainView).FocusedRowHandle;
            int Id = Convert.ToInt32(((GridView)_form.GridControl1.MainView).GetRowCellValue(selectedRow, "Id"));

            StudentDAO dao = new StudentDAO();
            dao.DeleteStudent(Id);

            RefreshStudents();
        }
    }
}
