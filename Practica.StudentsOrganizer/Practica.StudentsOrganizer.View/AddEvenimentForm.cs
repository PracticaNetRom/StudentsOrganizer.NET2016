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
    public partial class AddEvenimentForm : Form
    {
        public AddEvenimentForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EvenimentBO eventBO = new EvenimentBO();
            eventBO.eventName = txtEventName.Text;
            eventBO.task = txtTask.Text;
            eventBO.departamentOrTehnology = comboBoxDepart.Text;

            EvenimentDAO eventDAO = new EvenimentDAO();


            if (string.IsNullOrEmpty(txtEventName.Text))
            {
                MessageBox.Show("Please enter EVENT NAME!");
            }
            else
            {
                eventBO.eventName = txtEventName.Text;
            }


             if(string.IsNullOrEmpty(txtTask.Text))
            {
                MessageBox.Show("Please enter EVENT TASK!");
            }
            else
            {
                eventBO.task = txtTask.Text;
            }


            if(string.IsNullOrEmpty(comboBoxDepart.Text))
            {
                MessageBox.Show("Please enter DEPARTMENT or TECHNOLOGY!");
            }
            else
            {
                eventBO.departamentOrTehnology = comboBoxDepart.Text;
            }


            eventDAO.AddEveniment(eventBO);

            MessageBox.Show("Event successfully added!");

            txtEventName.Text = string.Empty;
            txtTask.Text = string.Empty;
            comboBoxDepart.Text = string.Empty;

        }
    }
}
