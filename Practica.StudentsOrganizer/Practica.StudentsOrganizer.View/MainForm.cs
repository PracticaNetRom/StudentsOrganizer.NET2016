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
        }

        public IAddStudentForm CreateAddForm()
        {
            return new AddStudentForm();
        }

        private void buttonUpdateStd_Click(object sender, EventArgs e)
        {
            controllerMain.Update();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshData();

        }


        private void buttInsertStd_Click(object sender, EventArgs e)
        {
            controllerMain.Add();          
        }


        private void buttDeleteStd_Click(object sender, EventArgs e)
        {
            controllerMain.Delete();           
        }


      /*  
        private void RefreshData()
        {
            StudentDAO studDAO = new StudentDAO();

            DataTable dtret = new DataTable();
            dtret = studDAO.GetAllStudents();

            grdCtrlStudents.DataSource = dtret;
        }
        */
        
    }
}
