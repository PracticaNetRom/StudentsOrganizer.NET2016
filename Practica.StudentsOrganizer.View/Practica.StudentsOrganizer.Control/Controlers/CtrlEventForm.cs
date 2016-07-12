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
    public class CtrlEventForm
    {
        private IEventForm form;
        public CtrlEventForm (IEventForm form1)
        {
            form = form1;
        }

        public void EvLoad()
        {
            Events_DAO Ev_DAO = new Events_DAO();
            form._gridControl1.DataSource = Ev_DAO.GetAllEvents();
        }
        //public void SaveEvent()
        //{
        //    Events_BO NewEvent = new Events_BO();
        //    Events_DAO NewEvent_DAO = new Events_DAO();


        //    NewEvent.Event_Name = form._txtEvName.Text;
        //    NewEvent.Technology = form._comboTechnology.Text;
        //    NewEvent.Task = form._txtTask.Text;


        //    NewEvent_DAO.AddEvent(NewEvent);
        //}

        public void ShowEvents()
        {
            Events_DAO Ev_DAO = new Events_DAO();
            form._gridControl1.DataSource = Ev_DAO.GetAllEvents();
        }

        public void AddEv()
        {
            Events_DAO Ev_DAO = new Events_DAO();

            Events_BO NewEv = new Events_BO();

            NewEv.Event_Name = form._txtEvName.Text;
            NewEv.Technology = form._comboTechnology.Text;
            NewEv.Task = form._txtTask.Text;

            Ev_DAO.AddEvent(NewEv);
        }

        public void EditEv()
        {
            Events_DAO Ev_DAO = new Events_DAO();
            Events_BO Ev_Received;
            Ev_Received = (Events_BO)form._gridView1.GetFocusedRow();

            form._txtEvName.Text = Ev_Received.Event_Name.ToString();
            form._comboTechnology.Text = Ev_Received.Technology.ToString();
            form._txtTask.Text = Ev_Received.Task.ToString();
        }

        public void SaveChEv()
        {
            Events_DAO Ev_DAO = new Events_DAO();
            Events_BO Ev_Received;
            Ev_Received = (Events_BO)form._gridView1.GetFocusedRow();

            form._txtEvName.Text = Ev_Received.Event_Name.ToString();
            form._comboTechnology.Text = Ev_Received.Technology.ToString();
            form._txtTask.Text = Ev_Received.Task.ToString();

            Ev_DAO.UpdateEvent(Ev_Received);
        }

        public void DelEv()
        {
            Events_BO Del_Ev;
            Del_Ev = ((Events_BO)form._gridView1.GetFocusedRow());
            Events_DAO Del_ev_DAO = new Events_DAO();
            Del_ev_DAO.DeleteEV_ById(Del_Ev);
        }
    }
}
