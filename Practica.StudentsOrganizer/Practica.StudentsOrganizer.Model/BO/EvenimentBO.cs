using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.BO
{
    public  class EvenimentBO
    {
        public int id { get; set; }
        public string eventName { get; set; }
        public string task { get; set; }
        public string departamentOrTehnology { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", eventName, departamentOrTehnology, task);
        }

    }
}
