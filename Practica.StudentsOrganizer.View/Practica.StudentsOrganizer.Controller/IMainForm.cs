using DevExpress.XtraEditors;
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
        SimpleButton btnAdd { get; set; }
        SimpleButton btnOpen { get; set; }
        SimpleButton btnDelete { get; set; }
        GridControl gridControl1 { get; set; }
    }
}
