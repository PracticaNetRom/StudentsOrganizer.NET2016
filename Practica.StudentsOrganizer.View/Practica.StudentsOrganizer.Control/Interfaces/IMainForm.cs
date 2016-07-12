using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Practica.StudentsOrganizer.Control.Interfaces;
using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Control
{
    public interface IMainForm
    {
        SimpleButton _show_Students_Button { get; }
        SimpleButton _add_Stud_Button { get; }
        SimpleButton _edit_Stud_Button { get; }
        SimpleButton _del_Stud_Button { get; }
        SimpleButton _eventsButton { get; }
        SimpleButton _eOButton { get; }
        SimpleButton _sEOButton { get;}
        GridControl _gridControl1 { get; }
        GridView _gridView1 { get; }
        IAddEditStudentsForm CreateAdd(Students_BO STD);
        IEventForm OpenEvents();
    }
}
