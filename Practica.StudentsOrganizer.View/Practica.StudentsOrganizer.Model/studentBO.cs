﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica.StudentsOrganizer.Model
{
    public class studentBO
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumbers { get; set; }
        public string PhoneHomeNumbers { get; set; }
        public int FacultyStarYear { get; set; }
        public string Faculty { get; set; }
        public string Remarks{ get; set; }
    }
}