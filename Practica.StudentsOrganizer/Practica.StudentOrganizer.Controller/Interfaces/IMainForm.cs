using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentOrganizer.Controller.Interfaces
{
    public interface IMainForm
    {
        SimpleButton ButtInsertStd { get; }
        SimpleButton ButtonUpdateStd { get; }
        SimpleButton ButtDeleteStd { get; }
        SimpleButton ButtonLogOut { get; }
        IAddStudentForm CreateAddForm();
        ILoginForm createLoginForm();
        GridView GridView { get; }
        GridControl GrdCtrlStudents { get; }
    }
}
