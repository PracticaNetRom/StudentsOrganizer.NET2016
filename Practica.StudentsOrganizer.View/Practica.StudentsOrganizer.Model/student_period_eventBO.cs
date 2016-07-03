using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica.StudentsOrganizer.Model
{
    class student_period_eventBO
    {
        public int IdStudent { get; set; }
        public int IdStudentOccurence { get; set; }
    }
}
