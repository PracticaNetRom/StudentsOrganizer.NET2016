using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.BO
{
    public class Stud_Event_Occurence_BO
    {
        public int ID { get; set; }
        public int Event_OccurenceId { get; set; }
        public int StudentsId { get; set; }
    }
}
