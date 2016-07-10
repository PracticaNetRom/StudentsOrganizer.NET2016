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
        TextEdit txtLastName { get; set; }
        ComboBoxEdit Gender { get; set; }
        DateEdit BirthDate { get; set; }
        TextEdit txtEmail { get; set; }
        TextEdit txtPhoneNumber { get; set; }
        TextEdit txtFaculty { get; set; }
        TextEdit txtFacultyStartYear { get; set; }
        TextEdit txtRemarks { get; set; }

    }
}
