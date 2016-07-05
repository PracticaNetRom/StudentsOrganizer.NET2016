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
    public partial class AddStudentEventOccurence : Form
    {
        public AddStudentEventOccurence()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveStdEvenOccu_Click(object sender, EventArgs e)
        {
            StudentEventOccurenceBO stdEvenOccBO = new StudentEventOccurenceBO();
            stdEvenOccBO.idStudent = Convert.ToInt32(intIDStudent.Text);
            stdEvenOccBO.idEvenOccurence = Convert.ToInt32(intIdEvent.Text);

            StudentEventOccurenceDAO stdEventOccDAO = new StudentEventOccurenceDAO();


            if (string.IsNullOrEmpty(intIDStudent.Text))
            {
                MessageBox.Show("Please enter ID STUDENT!");
            }
            else
            {
                stdEvenOccBO.idStudent = Convert.ToInt32(intIDStudent.Text);
            }


            if (string.IsNullOrEmpty(intIdEvent.Text))
            {
                MessageBox.Show("Please enter ID EVENT!");
            }
            else
            {
                stdEvenOccBO.idEvenOccurence = Convert.ToInt32(intIdEvent.Text);
            }

            stdEventOccDAO.AddSdtEvenOcc(stdEvenOccBO);

            intIDStudent.Clear();
            intIdEvent.Clear();

        }

        private void intIdEvent_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
