
﻿using Practica.StudentsOrganizer.Model;
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
        Students_BO StudReceived;
        public AddStudentForm(Students_BO Stud)
        {
            StudReceived = Stud;
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            if(StudReceived != null)
            {
                txtFirst_Name.Text = StudReceived.First_Name;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            Students_DAO Student_DAO = new Students_DAO();
            if (StudReceived == null)
            {
                Students_BO NewStudent = new Students_BO();
                
                NewStudent.First_Name = txtFirst_Name.Text;
                NewStudent.Last_Name = txtLast_Name.Text;
                NewStudent.Gender = comboGender.Text;
                NewStudent.Birth_Date = dateBirth_Date.DateTime;
                NewStudent.Email = txtEmail.Text;
                NewStudent.Phone_Number = txtPhone.Text;
                NewStudent.Faculty = txtFaculty.Text;
                NewStudent.Faculty_Start_Year = Convert.ToInt32(maskedFaculty_Start_Year.Text);
                NewStudent.Remarks = txtRemarks.Text;

                Student_DAO.AddStudent(NewStudent);
            }
            else
            {
                StudReceived.First_Name = txtFirst_Name.Text;
                StudReceived.Last_Name = txtLast_Name.Text;
                StudReceived.Gender = comboGender.Text;
                StudReceived.Birth_Date = dateBirth_Date.DateTime;
                StudReceived.Email = txtEmail.Text;
                StudReceived.Phone_Number = txtPhone.Text;
                StudReceived.Faculty = txtFaculty.Text;
                StudReceived.Faculty_Start_Year = Convert.ToInt32(maskedFaculty_Start_Year.Text);
                StudReceived.Remarks = txtRemarks.Text;

                Student_DAO.UpdateStud(StudReceived);
            }
            this.Close();
        }

        private void maskedFaculty_Start_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ShowstudentsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}