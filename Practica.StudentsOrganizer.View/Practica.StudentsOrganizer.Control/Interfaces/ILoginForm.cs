using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Control.Interfaces
{
    public interface ILoginForm
    {
        TextEdit _txtUsername { get; }
        TextEdit _txtPassword { get; }
        SimpleButton _Login_Button { get; }
        IMainForm OpenMain();
    }
}
