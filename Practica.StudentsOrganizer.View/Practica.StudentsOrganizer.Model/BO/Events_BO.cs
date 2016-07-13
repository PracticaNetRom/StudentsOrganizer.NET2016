using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.BO
{
   public class Events_BO
    {
       
        public int ID { get; set; }
        public string Event_Name { get; set; }
        public string Technology { get; set; }
        public string Task { get; set; }
        

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Event_Name, Technology, Task);
        }
    }
}
