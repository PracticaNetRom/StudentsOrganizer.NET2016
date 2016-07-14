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
        private IMainForm mainForm;


        public MainFormController(IMainForm form)
        {
            mainForm = form;
        }
       

        public void Add()
        {
            IAddStudentForm addForm = mainForm.CreateAddForm();
            ((Form)addForm).ShowDialog();
            RefreshData();
        }


        public void Delete()
        {
            int selectedRow = mainForm.GridView.FocusedRowHandle;
            int id = Convert.ToInt32(mainForm.GridView.GetRowCellValue(selectedRow, "id"));
            
            if (selectedRow == 0)
            {
                MessageBox.Show("Please select a student to delete!");
            }
            else
            {
                StudentDAO stdDelete = new StudentDAO();
                stdDelete.DeleteStudent(id);

                MessageBox.Show("Student successfully deleted!");
                RefreshData();
            }
        }


        public void Update()
        {
            IAddStudentForm updateForm = mainForm.CreateAddForm();

            StudentDAO stdselectDAO = new StudentDAO();

            int selectedRow = mainForm.GridView.FocusedRowHandle;
            int idSelect;
            idSelect = Convert.ToInt32(mainForm.GridView.GetRowCellValue(selectedRow, "id"));

            if (selectedRow == 0)
            {
                MessageBox.Show("Please select a student to update!");
            }
            else
            {
                StudentBO stdSelectBO = stdselectDAO.GetStudent(idSelect);

                updateForm.PopulateStudent(stdSelectBO);

                ((Form)updateForm).ShowDialog();
                RefreshData();
            }
        }


        public void RefreshData()
        {
            StudentDAO studDAO = new StudentDAO();

            DataTable dtret = new DataTable();
            dtret = studDAO.GetAllStudents();

            mainForm.GrdCtrlStudents.DataSource = dtret;
        }


        public void LogOut()
        {
            ILoginForm frm = mainForm.createLoginForm();
            ((Form)frm).ShowDialog();
        }

    }
}
