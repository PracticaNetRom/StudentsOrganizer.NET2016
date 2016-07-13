using Practica.StudentsOrganizer.Control.Interfaces;
using Practica.StudentsOrganizer.Model.BO;
using Practica.StudentsOrganizer.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Control.Controlers
{
    public class CtrlEOForm
    {
        IEOForm form;
        public CtrlEOForm(IEOForm form1)
        {
            form = form1;
        }

        public void Show()
        {
            Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            form._gridControl1.DataSource = EO_DAO.GetAllEO();

            Stud_Event_Occurence_DAO SEO_DAO = new Stud_Event_Occurence_DAO();
            form._gridControl2.DataSource = SEO_DAO.GetAllSEO();
        }

        public void AddEO()
        {
            Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();

            Event_Occurence_BO NewEO = new Event_Occurence_BO();

            NewEO.EventsId = Convert.ToInt32(form._txtAddEvID.Text);
            NewEO.Start = form._dateAddStart.DateTime;
            NewEO.Finish = form._dateAddFinish.DateTime;

            EO_DAO.AddEO(NewEO);
        }

        public void EditEO()
        {
            Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            Event_Occurence_BO EO_Received;
            EO_Received = (Event_Occurence_BO)form._gridView1.GetFocusedRow();

            form._txtAddEvID.Text = EO_Received.EventsId.ToString();
            form._dateAddStart.DateTime = EO_Received.Start;
            form._dateAddFinish.DateTime = EO_Received.Finish;
        }

        public void SaveChEO()
        {
            Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            Event_Occurence_BO EO_Received;
            EO_Received = (Event_Occurence_BO)form._gridView1.GetFocusedRow();
            EO_Received.EventsId = Convert.ToInt32(form._txtAddEvID.Text);
            EO_Received.Start = form._dateAddStart.DateTime;
            EO_Received.Finish = form._dateAddFinish.DateTime;

            EO_DAO.UpdateEO(EO_Received);
        }

        public void DelEO()
        {
            Event_Occurence_BO Del_EO;
            Del_EO = ((Event_Occurence_BO)form._gridView1.GetFocusedRow());
            Event_Occurence_DAO Del_EO_DAO = new Event_Occurence_DAO();
            Del_EO_DAO.DeleteEO_ById(Del_EO);
        }

        public void AddSEO()
        {
            Stud_Event_Occurence_DAO SEO_DAO = new Stud_Event_Occurence_DAO();
            Stud_Event_Occurence_BO NewBO = new Stud_Event_Occurence_BO();
            NewBO.StudentsId = Convert.ToInt32(form._txtStdId.Text);
            NewBO.Event_OccurenceId = Convert.ToInt32(form._txtEOid.Text);

            SEO_DAO.AddSEO(NewBO);
        }

        public void EditSEO()
        {
            Stud_Event_Occurence_DAO SEO_DAO = new Stud_Event_Occurence_DAO();
            Stud_Event_Occurence_BO SEO_Received;
            SEO_Received = (Stud_Event_Occurence_BO)form._gridView2.GetFocusedRow();
            form._txtStdId.Text = SEO_Received.StudentsId.ToString();
            form._txtEOid.Text = SEO_Received.Event_OccurenceId.ToString();
        }

        public void SaveChSEO()
        {
            Stud_Event_Occurence_DAO SEO_DAO = new Stud_Event_Occurence_DAO();
            Stud_Event_Occurence_BO SEO_Received;
            SEO_Received = (Stud_Event_Occurence_BO)form._gridView2.GetFocusedRow();
            form._txtStdId.Text = SEO_Received.StudentsId.ToString();
            form._txtEOid.Text = SEO_Received.Event_OccurenceId.ToString();
            SEO_DAO.UpdateSEO(SEO_Received);
        }

        public void DelSEO()
        {
            Stud_Event_Occurence_BO Del_SEO;
            Del_SEO = ((Stud_Event_Occurence_BO)form._gridView2.GetFocusedRow());
            Stud_Event_Occurence_DAO Del_SEO_DAO = new Stud_Event_Occurence_DAO();
            Del_SEO_DAO.DeleteSEO_ById(Del_SEO);
        }
    }
}
