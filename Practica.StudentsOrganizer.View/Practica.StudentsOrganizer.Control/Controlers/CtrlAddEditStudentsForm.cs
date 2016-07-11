using DevExpress.XtraEditors;
using Practica.StudentsOrganizer.Control.Interfaces;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.BO;
using Practica.StudentsOrganizer.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Control.Controlers
{
   
    public class CtrlAddEditStudentsForm 
    {
         private IAddEditStudentsForm form;
         public CtrlAddEditStudentsForm (IAddEditStudentsForm form1)
        {
            form = form1;
        }
        public void Add(Students_BO Stud_Received)
        {
            Events_DAO Ev_DAO = new Events_DAO();
            List<Events_BO> events = Ev_DAO.GetAllEvents();
            Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            List<Event_Occurence_BO> EO_BO = EO_DAO.GetAllEO();

            //foreach(Events_BO ev in events)
            //{
            //    comboBoxEdit1.Properties.Items.Add(ev);
            //}

            LookUpEdit.Properties.DataSource = events;
            LookUpEdit.Properties.DataSource = EO_BO;



            if (StudReceived != null)
            {
                MF.txtFirst_Name.Text = StudReceived.First_Name;
                txtLast_Name.Text = StudReceived.Last_Name;
                comboGender.Text = StudReceived.Gender;
                dateBirth_Date.DateTime = StudReceived.Birth_Date;
                txtEmail.Text = StudReceived.Email;
                txtPhone.Text = StudReceived.Phone_Number.ToString(); ;
                txtFaculty.Text = StudReceived.Faculty.ToString(); ;
                maskedFaculty_Start_Year.Text = StudReceived.Faculty_Start_Year.ToString();
                txtRemarks.Text = StudReceived.Remarks;

            }
        }

    }
}
