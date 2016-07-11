using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.StudentsOrganizer.Model;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using System.Data;

namespace Practica.StudentsOrganizer.Controller
{
   public class MainController 
    {
        private IMainForm _form;
       // StudentBO Student { get; set; }



        public MainController(IMainForm form)
        {
            _form = form;
        }
        public void LoadMainForm()
        {
            StudentDAO dao = new StudentDAO();
            DataTable dt = dao.GetAllStudents();
            _form.GridControl1.DataSource = dt;
        }

        public void Refresh()
        {
            StudentDAO dao = new StudentDAO();
            DataTable dt = dao.GetAllStudents();
            _form.GridControl1.DataSource = dt;
        }

        public void Add()
        {
             IStudentForm studentForm =  _form.CreateAddStudentForm();
            ((Form)studentForm).ShowDialog();

           
        }
        public void Open()
        {
            int selectedRow = _form.GridView1.FocusedRowHandle;
            int Id = Convert.ToInt32(_form.GridView1.GetRowCellValue(selectedRow, "ID"));

             StudentBO st = new StudentBO();
             StudentDAO dao = new StudentDAO();
             st=dao.getStudentById(Id);


            IStudentForm studentForm = _form.CreateAddStudentForm();
            studentForm.Student = st;
            ((Form)studentForm).ShowDialog();

        }
        public void Delete()
        {

            int selectedRow = _form.GridView1.FocusedRowHandle;
            int Id = Convert.ToInt32(_form.GridView1.GetRowCellValue(selectedRow, "ID"));

             StudentDAO dao = new StudentDAO();
            dao.DeleteStudent(Id);   
        }
    }
}
