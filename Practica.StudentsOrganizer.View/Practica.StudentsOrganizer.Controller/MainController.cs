using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.StudentsOrganizer.Model;

namespace Practica.StudentsOrganizer.Controller
{
   public class MainController : IMainForm
    {
        private IMainForm _form;

        
      

        public MainController(IMainForm form)
        {
            _form = form;
        }

        public void Refresh()
        {
            StudentDAO dao = new StudentDAO();
            DataTable dt = dao.GetAllStudents();
            gridControl1.DataSource = dt;
        }

        public void Add()
        {
            StudentForm stdForm = new StudentForm();
            stdForm.ShowDialog();

            Refresh(); // RefreshForm();
        }
        public void Open()
        {
            int selectedRow = gridView1.FocusedRowHandle;
            int Id = Convert.ToInt32(gridView1.GetRowCellValue(selectedRow, "ID"));

            StudentBO st = new StudentBO();
            StudentDAO dao = new StudentDAO();
            st = dao.getStudentById(Id);

            StudentForm stdForm = new StudentForm();
            stdForm.Student = st;
            stdForm.ShowDialog();

            Refresh(); // RefreshForm();
        }
        public void Delete()
        {
            int selectedRow = gridView1.FocusedRowHandle;
            int Id = Convert.ToInt32(gridView1.GetRowCellValue(selectedRow, "ID"));

            StudentDAO dao = new StudentDAO();
            dao.DeleteStudent(Id);

            Refresh(); // RefreshForm();
        }
    }
}
