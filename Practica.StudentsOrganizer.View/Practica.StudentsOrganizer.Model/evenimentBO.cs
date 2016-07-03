using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica.StudentsOrganizer.Model
{
    class evenimentBO
    {
        public int IdEvent { get; set; }
        public string EventName { get; set; }
        public string Departament { get; set; }
        public string Task { get; set; }
    }
}
