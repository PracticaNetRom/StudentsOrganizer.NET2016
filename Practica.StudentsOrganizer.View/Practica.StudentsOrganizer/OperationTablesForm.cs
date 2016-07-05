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
    public partial class OperationTablesForm : Form
    {
        public OperationTablesForm()
        {
            InitializeComponent();
        }

        private void Tables_Students_Button_Click(object sender, EventArgs e)
        {
            ShowStudentsForm form1 = new ShowStudentsForm();
            form1.Show();
        }

        private void Tables_Events_Button_Click(object sender, EventArgs e)
        {
            ShowEventsForm Evform = new ShowEventsForm();
            Evform.Show();
        }
    }
}
