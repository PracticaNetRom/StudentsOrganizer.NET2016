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
    public interface IStudentForm
    {
        StudentBO Student { get; set; }
        TextEdit TxtFirstName { get;  }
        TextEdit TxtLastName { get;  }
        TextEdit TxtEmail { get;  }
        TextEdit TxtFaculty { get;  }
        TextEdit TxtPhoneNumber { get;  }
        TextEdit TxtFacultyStartYear { get; }
        TextEdit TxtRemarks { get;  }
        ComboBoxEdit gender { get;  }
        DateEdit birthDate { get;  }

    }
}
