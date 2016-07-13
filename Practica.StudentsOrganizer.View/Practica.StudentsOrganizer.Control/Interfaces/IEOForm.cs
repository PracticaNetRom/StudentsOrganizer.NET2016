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
    public interface IEOForm
    {
        SimpleButton _Show_EO_Button { get; }
        SimpleButton _Add_EO_Button { get; }
        SimpleButton _Edit_EO_Button { get; }
        SimpleButton _SaveEO_Button { get; }
        SimpleButton _Del_EO_Button { get; }
        SimpleButton _Add_SEO_Button { get; }
        SimpleButton _Edit_SEO_Button { get; }
        SimpleButton _Del_SEO_Button { get; }
        TextEdit _txtAddEvID { get; }
        DateEdit _dateAddStart { get; }
        DateEdit _dateAddFinish { get; }
        TextEdit _txtEOid { get; }
        TextEdit _txtStdId { get; }
        GridControl _gridControl1 { get; }
        GridView _gridView1 { get; }
        GridControl _gridControl2 { get; }
        GridView _gridView2 { get; }
    }
}
