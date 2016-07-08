using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model
{
    public class Event_OccurenceBO
    {
        public int Id { get; set; }

        public int Id_event { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        // public EventBO Event { get; set; }
    }
}
