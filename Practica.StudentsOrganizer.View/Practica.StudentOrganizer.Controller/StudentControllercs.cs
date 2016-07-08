using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentOrganizer.Controller
{
     public class StudentController
    {
        public IStudentForm _form;

        public StudentController(IStudentForm form)
        {
            form = _form;
        }
    }
}
