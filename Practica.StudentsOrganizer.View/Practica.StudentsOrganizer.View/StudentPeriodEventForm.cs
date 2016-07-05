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
    public partial class StudentPeriodEventForm : Form
    {
        public StudentPeriodEventForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            student_period_eventBO NewStudentEventOccurenceBO = new student_period_eventBO();
            student_period_eventDAO NewStudentEventOccurenceDAO = new student_period_eventDAO();


            NewStudentEventOccurenceBO.IdStudent = Convert.ToInt32(textIdStud.Text);
            NewStudentEventOccurenceBO.IdStudentOccurence = Convert.ToInt32(textIdOcc.Text);

            NewStudentEventOccurenceDAO.AddStudent_period_eventDAO(NewStudentEventOccurenceBO);

        }
    }
}
