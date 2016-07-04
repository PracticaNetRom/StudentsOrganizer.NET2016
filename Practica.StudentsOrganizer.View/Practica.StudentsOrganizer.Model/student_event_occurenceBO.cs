using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica.StudentsOrganizer.Model
{
   public class student_event_occurenceBO
    {
        public int Id { get; set; }
        public int IdEvent { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataEnd { get; set; }
    }
}