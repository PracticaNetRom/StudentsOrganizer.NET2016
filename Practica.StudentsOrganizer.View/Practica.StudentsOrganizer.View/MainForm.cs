using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Practica.StudentsOrganizer.Model;
using Practica.StudentsOrganizer.Controller;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Practica.StudentsOrganizer.View
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm,IMainForm
    {
        public IStudentForm CreateAddStudentForm()
        {
            return new StudentForm();
        }

        private MainController controller;

       public GridControl GridControl1
       {
            get
            {
                return gridControl1;
            }
        }
        public GridView GridView1
        {
            get
            {
                return gridView1;
            }
        }
        public BarButtonItem BtnAdd
        {
            get
            {
                return btnAdd;
            }
           
        }
        


        public BarButtonItem BtnOpen
        {
            get
            {
                return btnAdd;
            }
           
        }

        public BarButtonItem BtnDelete
        {
            get
            {
                return btnAdd;
            }
           
        }

        public MainForm()
        {
            InitializeComponent();

            controller = new MainController(this);
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            controller.LoadMainForm();
           
        }

        public void RefreshForm()
        {
            controller.Refresh();
           
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            controller.Add();
         
            
            RefreshForm();
        }

        private void btnOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            controller.Open();
            RefreshForm();

        }



        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            controller.Delete();
            RefreshForm();
        }
    }
}