using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Controller
{
    public interface IMainForm
    {
        BarButtonItem BtnAdd { get; }
        BarButtonItem BtnOpen { get; }
        BarButtonItem BtnDelete { get; }
        GridControl GridControl1 { get; }

        IStudentForm CreateStudentForm();
    }
}
