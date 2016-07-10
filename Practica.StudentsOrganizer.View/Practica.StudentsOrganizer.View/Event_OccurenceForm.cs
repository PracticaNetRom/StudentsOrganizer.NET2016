using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentsOrganizer.View
{
    public partial class Event_OccurenceForm : Form
    {
        public Event_OccurenceForm()
        {
            InitializeComponent();
        }

        private void Event_OccurenceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEvent_Occurence_Click(object sender, EventArgs e)
        {
            Event_OccurenceBO ev_occ = new Event_OccurenceBO();
            Event_OccurenceDAO dao = new Event_OccurenceDAO();

            if (string.IsNullOrEmpty(txtId_Event.Text))
            {
                MessageBox.Show("Please enter event's id!");
            }
            else
            {
                ev_occ.Id_event = Convert.ToInt32(txtId_Event.Text);

            }

            ev_occ.StartDate = StartDate.Value;

            ev_occ.EndDate = EndDate.Value;

            dao.AddEvent_Occurence(ev_occ);

            MessageBox.Show("Event_Occurence successfully added!");
        }


    }
}
