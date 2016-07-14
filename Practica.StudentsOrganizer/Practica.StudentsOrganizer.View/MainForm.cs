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
using Practica.StudentOrganizer.Controller.Controllers;
using DevExpress.XtraEditors;
using Practica.StudentOrganizer.Controller.Interfaces;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace Practica.StudentsOrganizer.View
{
    public partial class MainForm : Form, IMainForm
    { 
        private MainFormController controllerMain;

        public SimpleButton ButtInsertStd
        {
            get
            {
                return buttInsertStd;
            }
        }

        public SimpleButton ButtonUpdateStd
        {
            get
            {
              return buttonUpdateStd;
            }
        }

        public SimpleButton ButtDeleteStd
        {
            get
            {
                return buttDeleteStd;
            }
        }

        public SimpleButton ButtonLogOut
        {
            get
            {
                return ButtonLogOut;
            }
        }

        public GridView GridView
        {
            get
            {
                return gridView1;
            }
        }
        
        public GridControl GrdCtrlStudents
        {
            get
            {
                return grdCtrlStudents;
            }
        }


        public MainForm()
        { 
            InitializeComponent();

            controllerMain = new MainFormController(this);
        }


        public IAddStudentForm CreateAddForm()
        {
            return new AddStudentForm(true);
        }


        public ILoginForm createLoginForm()
        {
            return new LoginForm();
        }


        private void buttonUpdateStd_Click(object sender, EventArgs e)
        {
            controllerMain.Update();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            controllerMain.RefreshData();
        }


        private void buttInsertStd_Click(object sender, EventArgs e)
        {
            controllerMain.Add();          
        }


        private void buttDeleteStd_Click(object sender, EventArgs e)
        {
            controllerMain.Delete();           
        }


        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            controllerMain.LogOut();
        }
    }
}
