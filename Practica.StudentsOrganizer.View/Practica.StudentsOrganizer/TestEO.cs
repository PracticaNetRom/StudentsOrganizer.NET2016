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
    public partial class TestEO : Form
    {
        public TestEO()
        {
            InitializeComponent();
        }

        private void Show_EO_Button_Click(object sender, EventArgs e)
        {
            Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            gridControl1.DataSource = EO_DAO.GetAllEO();
        }

        private void Add_SEO_Button_Click(object sender, EventArgs e)
        {

                Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            
                Event_Occurence_BO NewEO = new Event_Occurence_BO();

                NewEO.EventsId = Convert.ToInt32(txtAddEvID.Text);
                NewEO.Start = dateAddStart.DateTime;
                NewEO.Finish = dateAddFinish.DateTime;

                EO_DAO.AddEO(NewEO);
                
            }

        private void Edit_EO_Button_Click(object sender, EventArgs e)
        {
            Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            Event_Occurence_BO EO_Received ;
            EO_Received = (Event_Occurence_BO)gridView1.GetFocusedRow();

            txtAddEvID.Text = EO_Received.EventsId.ToString();
            dateAddStart.DateTime = EO_Received.Start;
            dateAddFinish.DateTime =EO_Received.Finish;

          

        }

        private void SaveEO_Button_Click(object sender, EventArgs e)
        {
            Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            Event_Occurence_BO EO_Received;
            EO_Received = (Event_Occurence_BO)gridView1.GetFocusedRow();
            EO_Received.EventsId = Convert.ToInt32(txtAddEvID.Text);
            EO_Received.Start = dateAddStart.DateTime;
            EO_Received.Finish = dateAddFinish.DateTime;

            EO_DAO.UpdateEO(EO_Received);
        }

        private void TestEO_Load(object sender, EventArgs e)
        {
            Event_Occurence_DAO EO_DAO = new Event_Occurence_DAO();
            gridControl1.DataSource = EO_DAO.GetAllEO();

        }
    }
}
