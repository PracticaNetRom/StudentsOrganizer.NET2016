using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentOrganizer.Controller.Interfaces
{
    public interface IAddStudentForm
    {
        TextEdit txtFirstName { get; }
        TextEdit txtLastName { get; }
            
           
            /*
            comboBoxGender
            dateTimeBirthDate
            txtEmail
            txtPhoneNumber
            txtFaculty
            txtFacultyStartYear
            txtRemarks
            */
    }
}
