using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Control.Interfaces
{
    public interface IEventForm
    {
        SimpleButton _Show_Ev_Button { get; }
        SimpleButton _Add_Ev_Button { get; }
        SimpleButton _Edit_Ev_Button { get; }
        SimpleButton _SaveEv_Button { get; }
        SimpleButton _Del_Ev_Button { get; }
        TextEdit _txtEvName { get; }
        TextEdit _txtTask { get; }
        ComboBoxEdit _comboTechnology { get; }
        GridControl _gridControl1 { get; }
        GridView _gridView1 { get; }
    }
}
