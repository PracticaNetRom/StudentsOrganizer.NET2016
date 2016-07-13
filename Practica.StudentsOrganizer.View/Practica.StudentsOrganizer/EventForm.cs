using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Practica.StudentsOrganizer.Control.Controlers;
using Practica.StudentsOrganizer.Control.Interfaces;
using Practica.StudentsOrganizer.Model.BO;
using Practica.StudentsOrganizer.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentsOrganizer
{
    public partial class EventForm : Form, IEventForm
    {
        private CtrlEventForm Controller;
        public SimpleButton _Show_Ev_Button
        {
            get
            {
                return Show_Ev_Button;
            }
        }

        public SimpleButton _Add_Ev_Button
        {
            get
            {
                return Add_Ev_Button;
            }
        }

        public SimpleButton _Edit_Ev_Button
        {
            get
            {
                return Edit_Ev_Button;
            }
        }
        public SimpleButton _SaveEv_Button
        {
            get
            {
                return SaveEv_Button;
            }
        }
        public SimpleButton _Del_Ev_Button
        {
            get
            {
                return Del_Ev_Button;
            }
        }
        public TextEdit _txtEvName
        {
            get
            {
                return txtEvName;
            }
        }
        public TextEdit _txtTask
        {
            get
            {
                return txtTask;
            }
        }
        public ComboBoxEdit _comboTechnology
        {
            get
            {
                return comboTechnology;
            }
        }
        public GridControl _gridControl1
        {
            get
            {
                return gridControl1;
            }
        }

       public GridView _gridView1
        {
            get
            {
                return gridView1;
            }
        }


        public EventForm()
        {
            InitializeComponent();
            Controller = new CtrlEventForm(this);
        }

        //private void SaveEvent_Click(object sender, EventArgs e)
        //{

        //    Controller.SaveEvent();
        //    //Events_BO NewEvent = new Events_BO();
        //    //Events_DAO NewEvent_DAO = new Events_DAO();


        //    //NewEvent.Event_Name = label1.Text;
        //    //NewEvent.Technology = label2.Text;
        //    //NewEvent.Task = label3.Text;


        //    //NewEvent_DAO.AddEvent(NewEvent);
        //}

        private void Show_Ev_Button_Click(object sender, EventArgs e)
        {
            Controller.ShowEvents();

            //Events_DAO Ev_DAO = new Events_DAO();
            //gridControl1.DataSource = Ev_DAO.GetAllEvents();
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            Controller.EvLoad();
            //Events_DAO Ev_DAO = new Events_DAO();
            //gridControl1.DataSource = Ev_DAO.GetAllEvents();
        }

        private void Add_Ev_Button_Click(object sender, EventArgs e)
        {
            Controller.AddEv();

            //Events_DAO Ev_DAO = new Events_DAO();

            //Events_BO NewEv = new Events_BO();
            
            //NewEv.Event_Name = txtEvName.Text;
            //NewEv.Technology = comboTechnology.Text;
            //NewEv.Task = txtTask.Text;

            //Ev_DAO.AddEvent(NewEv);
        }

        private void Edit_Ev_Button_Click(object sender, EventArgs e)
        {
            Controller.EditEv();
            //Events_DAO Ev_DAO = new Events_DAO();
            //Events_BO Ev_Received;
            //Ev_Received = (Events_BO)gridView1.GetFocusedRow();

            //txtEvName.Text = Ev_Received.Event_Name.ToString();
            //comboTechnology.Text = Ev_Received.Technology.ToString();
            //txtTask.Text = Ev_Received.Task.ToString();
        }

        private void SaveEv_Button_Click(object sender, EventArgs e)
        {
            Controller.SaveChEv();
            //Events_DAO Ev_DAO = new Events_DAO();
            //Events_BO Ev_Received;
            //Ev_Received = (Events_BO)gridView1.GetFocusedRow();

            //Ev_Received.Event_Name = txtEvName.Text;
            //Ev_Received.Technology = comboTechnology.Text;
            //Ev_Received.Task = txtTask.Text;

            //Ev_DAO.UpdateEvent(Ev_Received);
        }

        

        private void Del_Ev_Button_Click(object sender, EventArgs e)
        {
            Controller.DelEv();
            //Events_BO Del_Ev;
            //Del_Ev = ((Events_BO)gridView1.GetFocusedRow());
            //Events_DAO Del_ev_DAO = new Events_DAO();
            //Del_ev_DAO.DeleteEV_ById(Del_Ev);
        }
    }
}
