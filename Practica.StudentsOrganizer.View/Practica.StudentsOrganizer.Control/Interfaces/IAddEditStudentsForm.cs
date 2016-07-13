using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Control.Interfaces
{
    public interface IAddEditStudentsForm
    {
        TextEdit _txtFirst_Name { get; }
        TextEdit _txtLast_Name { get; }
        ComboBoxEdit _comboGender { get; }
        DateEdit _dateBirth_Date { get; }
        TextEdit _txtEmail { get; }
        TextEdit _txtPhone { get; }
        TextEdit _txtFaculty { get; }
        TextEdit _maskedFaculty_Start_Year { get; }
        TextEdit _txtRemarks { get; }
        LookUpEdit _lookUpEdit1 { get; }
        LookUpEdit _lookUpEdit2 { get; }
        GridControl _gridControl1 { get; }
        SimpleButton _AddEOButton { get; }


    }
}
