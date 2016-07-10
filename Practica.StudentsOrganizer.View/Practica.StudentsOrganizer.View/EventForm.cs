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
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        public void EventForm_Load(object sender, EventArgs e)
        {

        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            EventBO ev = new EventBO();
            EventDAO dao = new EventDAO();

            if(string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter event's name!");
            }
            else
            {
                ev.Name = txtName.Text;
            }

            if (string.IsNullOrEmpty(txtTask.Text))
            {
                MessageBox.Show("Please enter event's task!");
            }
            else
            {
                ev.Task = txtTask.Text;
            }

            if (string.IsNullOrEmpty(txtDep_Tech.Text))
            {
                MessageBox.Show("Please enter event's department/technology!");
            }
            else
            {
                ev.Department_Technology = txtDep_Tech.Text;
            }


            dao.AddEvent(ev);

            MessageBox.Show("Event successfully added!");
        }

    }
}
