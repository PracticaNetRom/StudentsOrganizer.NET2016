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
    public partial class StudentEventOccurenceForm : Form
    {
        public StudentEventOccurenceForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            student_event_occurenceBO NewStudentEventOccurenceBO = new student_event_occurenceBO();
            student_event_occurenceDAO NewStudentEventOccurenceDAO = new student_event_occurenceDAO();


            NewStudentEventOccurenceBO.DataStart = Convert.ToDateTime(textDataStart.Text);
            NewStudentEventOccurenceBO.DataEnd = Convert.ToDateTime(textDataEnd.Text);

            NewStudentEventOccurenceDAO.AddStudent_event_occurence(NewStudentEventOccurenceBO);

        }
    }
}
