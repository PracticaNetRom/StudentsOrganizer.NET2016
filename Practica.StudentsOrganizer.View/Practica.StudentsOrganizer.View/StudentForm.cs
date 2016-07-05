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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentBO std = new StudentBO();
            StudentDAO dao = new StudentDAO();
            

                if (string.IsNullOrEmpty(txtFirstName.Text))
                {
                    MessageBox.Show("Please enter student's first name!");
                }
                else
                {
                    std.FirstName = txtFirstName.Text;
                }

                if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    MessageBox.Show("Please enter student's last name!");
                }
                else
                {
                    std.LastName = txtLastName.Text;
                }

                if (string.IsNullOrEmpty(checkedListBoxGender.Text))
                {
                    MessageBox.Show("Please enter student's gender!");
                }
                else
                {
                    std.Gender = checkedListBoxGender.Text;
                }

                std.BirthDate = BirthDate.Value;

                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Please enter student's Email!");
                }
                else
                {
                    std.Email = txtEmail.Text;
                }

                if (string.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Please enter student's phone number!");
                }
                else
                {
                    std.PhoneNumber = txtPhoneNumber.Text;
                }

                if (string.IsNullOrEmpty(txtFaculty.Text))
                {
                    MessageBox.Show("Please enter student's faculty!");
                }
                else
                {
                    std.Faculty = txtFaculty.Text;
                }

                if (string.IsNullOrEmpty(maskedTxtFacultyStartYear.Text))
                {
                    MessageBox.Show("Please enter student's faculty start year!");
                }
                else
                {
                    std.FacultyStartYear = Convert.ToInt32(maskedTxtFacultyStartYear.Text);
                }

                std.Remarks = txtRemarks.Text;

            dao.AddStudent(std);

            MessageBox.Show("Student successfully added!");
        }
        
        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
