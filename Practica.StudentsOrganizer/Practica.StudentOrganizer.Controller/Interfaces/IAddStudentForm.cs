using DevExpress.XtraEditors;
using Practica.StudentsOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentOrganizer.Controller.Interfaces
{
    public interface IAddStudentForm
    {
       // StudentBO Student { get; set; }

        TextEdit txtFirstName { get; }
        TextEdit txtLastName { get; }
        ComboBoxEdit comboBoxGender { get; }
        DateEdit dateTimeBirthDate { get; }
        TextEdit txtEmail { get; }
        TextEdit txtPhoneNumber { get; }
        TextEdit txtFaculty { get; }
        TextEdit txtFacultyStartYear { get; }
        TextEdit txtRemarks { get; }
        
    }
}
