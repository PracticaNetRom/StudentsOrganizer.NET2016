using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model
{
    class StudentBO
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public DateTime birthDate { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string faculty { get; set; }
        public int facultyStartYear { get; set; }
        public string remarks { get; set; }

    }
}
