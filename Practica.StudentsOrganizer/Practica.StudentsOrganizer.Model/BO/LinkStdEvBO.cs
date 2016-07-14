using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.BO
{
    public class LinkStdEvBO
    {
        public int stdEvOccID { get; set; }
        public int evOccID { get; set; }
        public string evName { get; set; }
        public DateTime strtDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
