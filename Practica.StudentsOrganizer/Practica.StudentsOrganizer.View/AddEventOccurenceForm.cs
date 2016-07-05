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

namespace Practica.StudentsOrganizer.View
{
    public partial class AddEventOccurenceForm : Form
    {
        public AddEventOccurenceForm()
        {
            InitializeComponent();
        }

        private void buttonSaveEventOcurence_Click(object sender, EventArgs e)
        {
            EventOccurenceBO eventOcurBO = new EventOccurenceBO();
            eventOcurBO.idEvent = Convert.ToInt32(intIdEvent.Text);
            eventOcurBO.startData = Convert.ToDateTime(dateTimeStartData.Text);
            eventOcurBO.endData = Convert.ToDateTime(dateTimeEndData.Text);

            EventOccurenceDAO eventOcurDAO = new EventOccurenceDAO();


            if (string.IsNullOrEmpty(intIdEvent .Text))
            {
                MessageBox.Show("Please enter ID EVENT!");
            }
            else
            {
                eventOcurBO.idEvent = Convert.ToInt32(intIdEvent.Text);
            }


            if (string.IsNullOrEmpty(dateTimeStartData.Text))
            {
                MessageBox.Show("Please enter event's START DATA!");
            }
            else
            {
                eventOcurBO.startData = Convert.ToDateTime(dateTimeStartData.Text);
            }


            if (string.IsNullOrEmpty(dateTimeEndData.Text))
            {
                MessageBox.Show("Please enter event's END DATA!");
            }
            else
            {
                eventOcurBO.endData = Convert.ToDateTime(dateTimeEndData.Text);
            }


            eventOcurDAO.AddEventOccurence(eventOcurBO);

            intIdEvent.Clear();
            dateTimeEndData.Enabled = false;
            dateTimeStartData.Enabled = false;

        }

        private void dateTimeStartData_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
