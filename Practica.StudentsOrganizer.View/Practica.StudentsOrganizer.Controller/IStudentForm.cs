using DevExpress.XtraEditors;
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
        TextEdit txtFirstName { get; set; }
    }
}
