using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentOrganizer.Controller.Interfaces
{
    public interface IMainForm
    {
        SimpleButton buttInsertStd { get; }
        SimpleButton buttonUpdateStd { get; }
        SimpleButton buttDeleteStd { get; }
    }
}
