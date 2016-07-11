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

        TextEdit TxtFirstName { get; }
        TextEdit TxtLastName { get; }
        ComboBoxEdit ComboBoxGender { get; }
        DateEdit DateTimeBirthDate { get; }
        TextEdit TxtEmail { get; }
        TextEdit TxtPhoneNumber { get; }
        TextEdit TxtFaculty { get; }
        TextEdit TxtFacultyStartYear { get; }
        TextEdit TxtRemarks { get; }
        void PopulateStudent(StudentBO s);


    }
}
