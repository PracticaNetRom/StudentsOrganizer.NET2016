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
    public partial class AddEventForm : Form
    {
        public AddEventForm()
        {
            InitializeComponent();
        }

        private void SaveEvent_Click(object sender, EventArgs e)
        {
            Events_BO NewEvent = new Events_BO();
            Events_DAO NewEvent_DAO = new Events_DAO();


            NewEvent.Event_Name = label1.Text;
            NewEvent.Technology = label2.Text;
            NewEvent.Task = label3.Text;


            NewEvent_DAO.AddEvent(NewEvent);
        }

        private void Show_Ev_Button_Click(object sender, EventArgs e)
        {
            Events_DAO Ev_DAO = new Events_DAO();
            gridControl1.DataSource = Ev_DAO.GetAllEvents();
        }

        private void Add_Ev_Button_Click(object sender, EventArgs e)
        {
            Events_DAO Ev_DAO = new Events_DAO();

            Events_BO NewEv = new Events_BO();
            
            NewEv.Event_Name = label1.Text;
            NewEv.Technology = txtTechnology.Text;
            NewEv.Task = label3.Text;

            Ev_DAO.AddEvent(NewEv);
        }

        private void Edit_Ev_Button_Click(object sender, EventArgs e)
        {
            Events_DAO Ev_DAO = new Events_DAO();
            Events_BO Ev_Received;
            Ev_Received = (Events_BO)gridView1.GetFocusedRow();

            txtEvName.Text = Ev_Received.Event_Name.ToString();
            txtTechnology.Text = Ev_Received.Technology.ToString();
            txtTask.Text = Ev_Received.Task.ToString();
        }

        private void SaveEv_Button_Click(object sender, EventArgs e)
        {
            Events_DAO Ev_DAO = new Events_DAO();
            Events_BO Ev_Received;
            Ev_Received = (Events_BO)gridView1.GetFocusedRow();

            Ev_Received.Event_Name = txtEvName.Text;
            Ev_Received.Technology = txtTechnology.Text;
            Ev_Received.Task = txtTask.Text;

            Ev_DAO.UpdateEvent(Ev_Received);
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            Events_DAO Ev_DAO = new Events_DAO();
            gridControl1.DataSource = Ev_DAO.GetAllEvents();
        }

        private void Del_Ev_Button_Click(object sender, EventArgs e)
        {
            Events_BO Del_Ev;
            Del_Ev = ((Events_BO)gridView1.GetFocusedRow());
            Events_DAO Del_ev_DAO = new Events_DAO();
            Del_ev_DAO.DeleteEV_ById(Del_Ev);
        }
    }
}
