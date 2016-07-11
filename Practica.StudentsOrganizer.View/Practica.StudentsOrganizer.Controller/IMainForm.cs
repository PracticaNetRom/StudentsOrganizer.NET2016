using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using Practica.StudentsOrganizer.Model;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;

namespace Practica.StudentsOrganizer.Controller
{
    public interface IMainForm
    {
        IStudentForm CreateAddStudentForm();

        GridControl GridControl1 { get;  }
        BarButtonItem BtnAdd { get;  }
        BarButtonItem BtnOpen { get; }
        BarButtonItem BtnDelete { get;  }
        GridView GridView1 { get; }

    }
}
