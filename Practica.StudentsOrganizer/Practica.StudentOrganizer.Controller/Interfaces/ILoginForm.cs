using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentOrganizer.Controller.Interfaces
{
    public interface ILoginForm
    {
        TextEdit TextUserName { get; }
        TextEdit TextPassword { get; }
        IMainForm createMainForm();
        SimpleButton ButtonLogin { get; }
    }
}
