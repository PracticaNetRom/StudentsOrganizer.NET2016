using Practica.StudentsOrganizer.Control.Interfaces;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentsOrganizer.Control
{
    public class CtrlMainForm
    {

        private IMainForm MF;
       
        public CtrlMainForm(IMainForm Form)
        {
            MF = Form;
        }
        public void ShowAtLoadTime()
        {
            Students_DAO Std_DAO = new Students_DAO();
            //MF._gridControl1.DataSource = Std_DAO.GetAllStudents();
            MF._gridControl1.DataSource = Std_DAO.Join();
        }
        public void ShowStd()
        {
            Students_DAO Std_DAO = new Students_DAO();
            MF._gridControl1.DataSource = Std_DAO.GetAllStudents();
        }
        public void Add_Std()
        {
            IAddEditStudentsForm Add_Std_Form = MF.CreateAdd(null);
            ((Form)Add_Std_Form).ShowDialog();
        }
        public void Edit_Std()
        {
            IAddEditStudentsForm Add_Std_Form = MF.CreateAdd(((Students_BO)MF._gridView1.GetFocusedRow()));
            ((Form)Add_Std_Form).ShowDialog();
        }

        public void Del_Stud()
        {
            Students_BO Del_Stud;
            Del_Stud = ((Students_BO)MF._gridView1.GetFocusedRow());
            Students_DAO Del_Stud_DAO = new Students_DAO();
            Del_Stud_DAO.DeleteStd_ByFirstName(Del_Stud);
        }

        public void Events()
        {
            IEventForm Ev_Form = MF.OpenEvents();
            ((Form)Ev_Form).ShowDialog();
        }
    }
}
