using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Controller
{
    public class MainController
    {
        private IMainForm _form;       

        public MainController(IMainForm form)
        {
            _form = form;
        }
        public void LoadMainForm()
        {
            StudentDAO dao = new StudentDAO();
            DataTable dt = dao.GetAllStudents();
            _form.gridControl1.DataSource = dt;
        }

        public void Add()
        {
            StudentForm stdForm = new StudentForm();
            stdForm.ShowDialog();

           // RefreshForm();
        }

        public void Open()
        {
            int selectedRow = gridView1.FocusedRowHandle;
            int Id = Convert.ToInt32(gridView1.GetRowCellValue(selectedRow, "Id"));

            StudentBO st = new StudentBO();
            StudentDAO dao = new StudentDAO();
            st = dao.getStudentById(Id);

            StudentForm stdForm = new StudentForm();
            stdForm.Student = st;
            stdForm.ShowDialog();

           // RefreshForm();
        }

        public void Delete()
        {
            int selectedRow = gridView1.FocusedRowHandle;
            int Id = Convert.ToInt32(gridView1.GetRowCellValue(selectedRow, "Id"));

            StudentDAO dao = new StudentDAO();
            dao.DeleteStudent(Id);

           // RefreshForm();
        }
    }
}
