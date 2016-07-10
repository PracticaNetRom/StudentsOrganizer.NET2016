using Practica.StudentOrganizer.Controller.Interfaces;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentOrganizer.Controller.Controllers
{
    public class MainFormController
    {
        private object grdCtrlStudents;
        private IMainForm _form;

        public MainFormController(IMainForm form)
        {
            _form = form;
        }
       

        public void Add()
        {
            AddStudentForm stdForm = new AddStudentForm();
            stdForm.ShowDialog();
            RefreshData();
        }


        public void Delete()
        {
            int selectedRow = gridView1.FocusedRowHandle;
            int id = Convert.ToInt32(gridView1.GetRowCellValue(selectedRow, "id"));

            StudentDAO stdDelete = new StudentDAO();
            stdDelete.DeleteStudent(id);

            MessageBox.Show("Student successfully deleted!");

            RefreshData();
        }


        public void Update()
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


        public void RefreshData()
        {
            StudentDAO studDAO = new StudentDAO();

            DataTable dtret = new DataTable();
            dtret = studDAO.GetAllStudents();

            grdCtrlStudents.DataSource = dtret;
        }
    }
}
