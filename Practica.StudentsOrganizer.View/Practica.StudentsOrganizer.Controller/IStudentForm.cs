using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Controller
{
    public interface IStudentForm
    {
        StudentBO Student { get; set; }
        TextEdit TxtFirstName { get; }
        TextEdit TxtLastName { get; }
        ComboBoxEdit gender { get; }
        DateEdit birthDate { get; }
        TextEdit TxtEmail { get; }
        TextEdit TxtPhoneNumber { get; }
        TextEdit TxtFaculty { get; }
        TextEdit TxtFacultyStartYear { get; }
        TextEdit TxtRemarks { get; }
        LookUpEdit LookUpEdit1 { get; }
        LookUpEdit LookUpEdit2 { get; }
        GridControl GridControlEvent { get; }
        GridView GridViewEvent { get; }
        
    }
}
