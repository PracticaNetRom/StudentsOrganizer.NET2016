using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model
{
    public class Students_BO
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public DateTime Birth_Date { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public string Faculty { get; set; }
        public int Faculty_Start_Year { get; set; }
        public string Remarks { get; set; }


    }
}
