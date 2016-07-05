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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            evenimentBO NewEventBO = new evenimentBO();
            evenimentDAO NewEventDAO = new evenimentDAO();

            NewEventBO.EventName = textNameEvent.Text;
            NewEventBO.Departament = textDepartament.Text;
            NewEventBO.Task = textTask.Text;
         

            NewEventDAO.AddEvent(NewEventBO);
        }
    }
}
