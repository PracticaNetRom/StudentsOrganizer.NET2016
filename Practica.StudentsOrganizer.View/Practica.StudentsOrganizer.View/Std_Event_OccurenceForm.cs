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
    public partial class Std_Event_OccurenceForm : Form
    {
        public Std_Event_OccurenceForm()
        {
            InitializeComponent();
        }

        private void Std_Event_OccurenceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStd_Event_Occurence_Click(object sender, EventArgs e)
        {
            Std_Event_OccurenceBO std_ev_occ = new Std_Event_OccurenceBO();
            Std_Event_OccurenceDAO dao = new Std_Event_OccurenceDAO();

            if (string.IsNullOrEmpty(txtId_Student.Text))
            {
                MessageBox.Show("Please enter student's id!");
            }
            else
            {
                std_ev_occ.Id_Student = Convert.ToInt32(txtId_Student.Text);

            }

            if (string.IsNullOrEmpty(txtId_Event.Text))
            {
                MessageBox.Show("Please enter event's id!");
            }
            else
            {
                std_ev_occ.Id_Student = Convert.ToInt32(txtId_Event.Text);

            }



            dao.AddStd_Event_Occurence(std_ev_occ);

            MessageBox.Show("Std_Event_Occurence successfully added!");
        }


    }
}
