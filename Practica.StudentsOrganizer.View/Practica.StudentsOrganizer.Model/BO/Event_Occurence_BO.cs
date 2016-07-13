﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model.BO
{
    public class Event_Occurence_BO
    {
        public int ID { get; set; }
        public int EventsId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Events_BO EventDetails { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - {1}", Start.ToShortDateString(), Finish.ToShortDateString());
        }
    }
}