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
            List<Events_BO> events;
            Students_DAO Std_DAO = new Students_DAO();

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

                events = Ev_DAO.GetEvent_ById(Stud_Received.ID);
                form._lookUpEdit1.Properties.DataSource = events;

                form._gridControl1.DataSource = Std_DAO.LinkEv_ById(Stud_Received.ID);
            }
            else
            {
                events = Ev_DAO.GetAllEvents();
                form._lookUpEdit1.Properties.DataSource = events;
                _addLink = new List<LinkStudEv_BO>();

                form._gridControl1.DataSource = _addLink;
            }
            
        }

        public void SaveStud(Students_BO Stud)
        {
            Stud_Received = Stud;
            Students_BO NewStudent = new Students_BO();
            Students_DAO Student_DAO = new Students_DAO();
            if (Stud_Received == null)//Add
            {
                
                

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

            LinkStudEv_BO link = new LinkStudEv_BO();
            if (link.Stud_Event_OccurenceId == 0)
            {
                Stud_Event_Occurence_BO NewSEO = new Stud_Event_Occurence_BO();
                Stud_Event_Occurence_DAO SEO_DAO = new Stud_Event_Occurence_DAO();

                Events_BO Ev = (Events_BO)form._lookUpEdit1.GetSelectedDataRow();

                Event_Occurence_BO eo = (Event_Occurence_BO)form._lookUpEdit2.GetSelectedDataRow();

                LinkStudEv_BO bo = new LinkStudEv_BO();

                bo.Event_Name = Ev.Event_Name;
                bo.Start = eo.Start;
                bo.Finish = eo.Finish;

                
                NewSEO.Event_OccurenceId = bo.Event_OccurenceId;
                SEO_DAO.AddSEO(NewSEO);
                
            }
           
            
        }

        public void Load_EO()
        {
            Events_BO Ev;
            Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            Ev = (Events_BO)form._lookUpEdit1.GetSelectedDataRow();
            List<Event_Occurence_BO> EO_BO = EO_DAO.GetEvOcc_ById(Ev.ID);

            form._lookUpEdit2.Properties.DataSource = EO_BO;
            if (EO_BO.Count > 0)
            {
                form._lookUpEdit2.EditValue = EO_BO.FirstOrDefault();
            }
        }

        
        private List<LinkStudEv_BO> _addLink;

        public void AddEvent()
        {
            Events_BO Ev = (Events_BO)form._lookUpEdit1.GetSelectedDataRow();

            Event_Occurence_BO eo = (Event_Occurence_BO)form._lookUpEdit2.GetSelectedDataRow();

            LinkStudEv_BO bo = new LinkStudEv_BO();

            bo.Event_Name = Ev.Event_Name;
            bo.Start = eo.Start;
            bo.Finish = eo.Finish;

            _addLink.Add(bo);
            form._gridControl1.RefreshDataSource();

        }
    }
}
