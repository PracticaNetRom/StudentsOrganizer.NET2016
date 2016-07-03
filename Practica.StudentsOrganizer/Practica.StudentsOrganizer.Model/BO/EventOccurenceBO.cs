using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.BO
{
    class EventOccurenceBO
    {
        public int id { get; set; }
        public int idEvent { get; set; }
        public DateTime startData { get; set; }
        public DateTime endData { get; set; }
    }
}
