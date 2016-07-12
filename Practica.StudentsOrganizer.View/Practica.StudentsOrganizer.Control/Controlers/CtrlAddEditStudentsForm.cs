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
         private Students_BO Stud_Received;
         private IAddEditStudentsForm form;
         public CtrlAddEditStudentsForm (IAddEditStudentsForm form1)
        {
            form = form1;
        }
        public void Load(Students_BO Stud)
        {
            Stud_Received = Stud;
            Events_DAO Ev_DAO = new Events_DAO();
            List<Events_BO> events = Ev_DAO.GetAllEvents();
            Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            List<Event_Occurence_BO> EO_BO = EO_DAO.GetAllEO();

            //foreach(Events_BO ev in events)
            //{
            //    comboBoxEdit1.Properties.Items.Add(ev);
            //}

            form._lookUpEdit1.Properties.DataSource = events;
            form._lookUpEdit2.Properties.DataSource = EO_BO;



            if (Stud_Received != null)
            {
                form._txtFirst_Name.Text = Stud_Received.First_Name;
                form._txtLast_Name.Text = Stud_Received.Last_Name;
                form._comboGender.Text = Stud_Received.Gender;
                form._dateBirth_Date.DateTime = Stud_Received.Birth_Date;
                form._txtEmail.Text = Stud_Received.Email;
                form._txtPhone.Text = Stud_Received.Phone_Number.ToString(); ;
                form._txtFaculty.Text = Stud_Received.Faculty.ToString(); ;
                form._maskedFaculty_Start_Year.Text = Stud_Received.Faculty_Start_Year.ToString();
                form._txtRemarks.Text = Stud_Received.Remarks;

            }
        }

        public void SaveStud(Students_BO Stud)
        {
            Stud_Received = Stud;
            Students_DAO Student_DAO = new Students_DAO();
            if (Stud_Received == null)//Add
            {
                Students_BO NewStudent = new Students_BO();

                NewStudent.First_Name = form._txtFirst_Name.Text;
                NewStudent.Last_Name = form._txtLast_Name.Text;
                NewStudent.Gender = form._comboGender.Text;
                NewStudent.Birth_Date = form._dateBirth_Date.DateTime;
                NewStudent.Email = form._txtEmail.Text;
                NewStudent.Phone_Number = form._txtPhone.Text;
                NewStudent.Faculty = form._txtFaculty.Text;
                NewStudent.Faculty_Start_Year = Convert.ToInt32(form._maskedFaculty_Start_Year.Text);
                NewStudent.Remarks = form._txtRemarks.Text;

                Student_DAO.AddStudent(NewStudent);
            }
            else //Edit
            {

                Stud_Received.First_Name = form._txtFirst_Name.Text;
                Stud_Received.Last_Name = form._txtLast_Name.Text;
                Stud_Received.Gender = form._comboGender.Text;
                Stud_Received.Birth_Date = form._dateBirth_Date.DateTime;
                Stud_Received.Email = form._txtEmail.Text;
                Stud_Received.Phone_Number = form._txtPhone.Text;
                Stud_Received.Faculty = form._txtFaculty.Text;
                Stud_Received.Faculty_Start_Year = Convert.ToInt32(form._maskedFaculty_Start_Year.Text);
                Stud_Received.Remarks = form._txtRemarks.Text;

                Student_DAO.UpdateStud(Stud_Received);
            }
            //this.Close();
        }

    }
}
