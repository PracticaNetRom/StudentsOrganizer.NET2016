using Practica.StudentsOrganizer.Model;
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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveStudent_Click(object sender, EventArgs e)
        {
            Students_BO NewStudent = new Students_BO();
            Students_DAO NewStudent_DAO = new Students_DAO();
           

            NewStudent.First_Name = txtFirst_Name.Text;
            NewStudent.Last_Name = txtLast_Name.Text;
            NewStudent.Gender = txtGender.Text;
            NewStudent.Birth_Date = dtBirth_Date.Value;
            NewStudent.Email = txtEmail.Text;
            NewStudent.Phone_Number = txtPhone.Text;
            NewStudent.Faculty = txtFaculty.Text;
            NewStudent.Faculty_Start_Year = Convert.ToInt32(txtFacultyStartYear.Text);
            NewStudent.Remarks = txtRemarks.Text;

            NewStudent_DAO.AddStudent(NewStudent);


        }
    }
}
