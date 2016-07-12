using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Practica.StudentsOrganizer.Control.Controlers;
using Practica.StudentsOrganizer.Control.Interfaces;
using Practica.StudentsOrganizer.Model;
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

namespace Practica.StudentsOrganizer
{
    public partial class EOForm : Form, IEOForm
    {
        private CtrlEOForm Controller;
        public SimpleButton _Show_EO_Button
        {
            get
            {
                return Show_EO_Button;
            }
        }
        public SimpleButton _Add_EO_Button 
        {
            get
            {
                return Add_EO_Button;
            }
        }
        public SimpleButton _Edit_EO_Button
        {
            get
            {
                return Edit_EO_Button;
            }
        }
        public SimpleButton _SaveEO_Button
        {
            get
            {
                return SaveEO_Button;
            }
        }
        public SimpleButton _Del_EO_Button
        {
            get
            {
                return Del_EO_Button;
            }
        }
        public SimpleButton _Add_SEO_Button
        {
            get
            {
                return Add_SEO_Button;
            }
        }
        public SimpleButton _Edit_SEO_Button
        {
            get
            {
                return Edit_SEO_Button;
            }
        }
        public SimpleButton _Del_SEO_Button
        {
            get
            {
                return Del_SEO_Button;
            }
        }
        public TextEdit _txtAddEvID
        {
            get
            {
                return txtAddEvID;
            }
        }
        public DateEdit _dateAddStart
        {
            get
            {
                return dateAddStart;
            }
        }
        public DateEdit _dateAddFinish
        {
            get
            {
                return dateAddFinish;
            }
        }
        public TextEdit _txtEOid
        {
            get
            {
                return txtEOid;
            }
        }
        public TextEdit _txtStdId
        {
            get
            {
                return txtStdId;
            }
        }
        public GridControl _gridControl1
        {
            get
            {
                return gridControl1;
            }
        }
        public GridView _gridView1
        {
            get
            {
                return gridView1;
            }
        }

        public GridControl _gridControl2
        {
            get
            {
                return gridControl2;
            }
        }
        public GridView _gridView2
        {
            get
            {
                return gridView2;
            }
        }

        public EOForm()
        {
            InitializeComponent();
            Controller = new CtrlEOForm(this);
        }

        private void EOForm_Load(object sender, EventArgs e)
        {
            Controller.Show();
        }

        private void Show_EO_Button_Click(object sender, EventArgs e)
        {
            Controller.Show();

            //Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            //gridControl1.DataSource = EO_DAO.GetAllEO();
        }

        private void Add_SEO_Button_Click(object sender, EventArgs e)
        {
            Controller.AddEO();
                //Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            
                //Event_Occurence_BO NewEO = new Event_Occurence_BO();

                //NewEO.EventsId = Convert.ToInt32(txtAddEvID.Text);
                //NewEO.Start = dateAddStart.DateTime;
                //NewEO.Finish = dateAddFinish.DateTime;

                //EO_DAO.AddEO(NewEO);
                
            }

        private void Edit_EO_Button_Click(object sender, EventArgs e)
        {
            Controller.EditEO();
            //Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            //Event_Occurence_BO EO_Received ;
            //EO_Received = (Event_Occurence_BO)gridView1.GetFocusedRow();

            //txtAddEvID.Text = EO_Received.EventsId.ToString();
            //dateAddStart.DateTime = EO_Received.Start;
            //dateAddFinish.DateTime =EO_Received.Finish;

          

        }

        private void SaveEO_Button_Click(object sender, EventArgs e)
        {
            Controller.SaveChEO();
            //Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            //Event_Occurence_BO EO_Received;
            //EO_Received = (Event_Occurence_BO)gridView1.GetFocusedRow();
            //EO_Received.EventsId = Convert.ToInt32(txtAddEvID.Text);
            //EO_Received.Start = dateAddStart.DateTime;
            //EO_Received.Finish = dateAddFinish.DateTime;

            //EO_DAO.UpdateEO(EO_Received);
        }

       

        private void Del_EO_Button_Click(object sender, EventArgs e)
        {
            Controller.DelEO();
            //Event_Occurence_BO Del_EO;
            //Del_EO = ((Event_Occurence_BO)gridView1.GetFocusedRow());
            //Event_Occurence_DAO Del_EO_DAO = new Event_Occurence_DAO();
            //Del_EO_DAO.DeleteEO_ById(Del_EO);
        }

        private void Add_SEO_Button_Click_1(object sender, EventArgs e)
        {
            Controller.AddSEO();
        }

        private void Edit_SEO_Button_Click(object sender, EventArgs e)
        {
            Controller.EditSEO();
        }


        private void SaveChSEO_Click(object sender, EventArgs e)
        {
            Controller.SaveChSEO();
        }

        private void Del_SEO_Button_Click(object sender, EventArgs e)
        {
            Controller.DelSEO();
        }

    }
}
