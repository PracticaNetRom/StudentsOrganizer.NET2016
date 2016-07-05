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


            NewEvent.Event_Name = txtEventName.Text;
            NewEvent.Technology = txtTech.Text;
            NewEvent.Task = txtTask.Text;


            NewEvent_DAO.AddEvent(NewEvent);
        }
    }
}
