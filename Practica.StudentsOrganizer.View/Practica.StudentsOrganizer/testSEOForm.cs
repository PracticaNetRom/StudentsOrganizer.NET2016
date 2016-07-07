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
    public partial class testSEOForm : Form
    {
        public testSEOForm()
        {
            InitializeComponent();
        }

        private void Show_SEO_Button_Click(object sender, EventArgs e)
        {
            
            
            Stud_Event_Occurence_DAO SEO_DAO = new Stud_Event_Occurence_DAO();
            //gridControl1.DataSource = SEO_DAO.GetAllSEO();
        }

        //private void Add_SEO_Button_Click(object sender, EventArgs e)
        //{
        //    Stud_Event_Occurence_DAO EO_DAO = new Stud_Event_Occurence_DAO();

        //    Stud_Event_Occurence_BO NewEO = new Stud_Event_Occurence_BO();

        //    NewEO.EventsId = Convert.ToInt32(txtAddEvID.Text);
        //    NewEO.Start = dateAddStart.DateTime;
        //    NewEO.Finish = dateAddFinish.DateTime;

        //    EO_DAO.AddEO(NewEO);
        //}
    }
}
