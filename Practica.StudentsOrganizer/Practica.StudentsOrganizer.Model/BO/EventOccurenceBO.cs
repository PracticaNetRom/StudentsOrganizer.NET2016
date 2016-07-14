using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.BO
{
    public class EventOccurenceBO
    {
        public int id { get; set; }
        public int idEvent { get; set; }
        public DateTime startData { get; set; }
        public DateTime endData { get; set; }
        
        public string DisplayValue
        {
            get { return string.Format("({0}) - ({1})", startData.ToShortDateString(), endData.ToShortDateString()); }
        }
    }
}
