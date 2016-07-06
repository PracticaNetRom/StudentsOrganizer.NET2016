using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.StudentsOrganizer
{
    public partial class ShowStudentsForm : Form
    {
        public ShowStudentsForm()
        {
            InitializeComponent();
        }

        private void ShowStudentsButton_Click(object sender, EventArgs e)
        {
            Students_DAO Std_DAO = new Students_DAO();
            gridControl1.DataSource = Std_DAO.GetAllStudents();
        }


        private void ShowStudentsForm_Load(object sender, EventArgs e)
        {
            Students_DAO Std_DAO = new Students_DAO();
            gridControl1.DataSource = Std_DAO.GetAllStudents();
        }

        private void Add_Stud_Button_Click(object sender, EventArgs e)
        {
            AddStudentForm Add_Std_Form = new AddStudentForm(null);

            Add_Std_Form.ShowDialog();
        }

        
        private void Edit_Stud_Button_Click(object sender, EventArgs e)
        {
            AddStudentForm Add_Std_Form = new AddStudentForm((Students_BO)gridView1.GetFocusedRow());
            //trimite un student din lista
            Add_Std_Form.ShowDialog();

            //Students_BO EditStudent = new Students_BO();
            //Students_DAO EditStudent_DAO = new Students_DAO();


            //EditStudent.First_Name = txtFirst_Name.Text;
            //EditStudent.Last_Name = txtLast_Name.Text;
            //EditStudent.Gender = comboGender.Text;
            //EditStudent.Birth_Date = dateBirth_Date.DateTime;
            //EditStudent.Email = txtEmail.Text;
            //EditStudent.Phone_Number = txtPhone.Text;
            //EditStudent.Faculty = txtFaculty.Text;
            //EditStudent.Faculty_Start_Year = Convert.ToInt32(maskedFaculty_Start_Year.Text);
            //EditStudent.Remarks = txtRemarks.Text;

            //EditStudent_DAO.UpdateStud(EditStudent);
        }
    }
}
