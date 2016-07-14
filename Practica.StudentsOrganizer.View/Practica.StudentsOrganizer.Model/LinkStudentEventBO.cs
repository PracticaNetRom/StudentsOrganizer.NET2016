using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model
{
    class LinkStudentEventBO
    {
        public int Stud_Event_OccurenceId { get; set; }
        public int Event_OccurenceId { get; set; }
        public string Event_Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }
}
