using DevExpress.XtraEditors;
using Practica.StudentOrganizer.Controller.Controllers;
using Practica.StudentOrganizer.Controller.Interfaces;
using Practica.StudentsOrganizer.Model;
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

namespace Practica.StudentsOrganizer.View
{
    public partial class LoginForm : Form , ILoginForm
    {
        private LoginController controllerLogin;

        public TextEdit TextUserName
        {
            get
            {
                return textUserName;
            }
        }

        public TextEdit TextPassword
        {
            get
            {
                return TextPassword;
            }
        }

        public SimpleButton ButtonLogin
        {
            get
            {
                return ButtonLogin;
            }
        }


        public LoginForm()
        {
            InitializeComponent();

            controllerLogin = new LoginController(this);
        }

        public IMainForm createMainForm()
        {
            return new MainForm();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            controllerLogin.Login();
        }
    }
}
        
    

