using DevExpress.XtraEditors;
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
        SimpleButton _add_Stud_Button { get;}
        SimpleButton _edit_Stud_Button { get;}
        SimpleButton _del_Stud_Button { get;}
        SimpleButton _eventsButton { get;}

    }
}
