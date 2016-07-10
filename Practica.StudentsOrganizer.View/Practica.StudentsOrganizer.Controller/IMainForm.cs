using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using Practica.StudentsOrganizer.Model;

namespace Practica.StudentsOrganizer.Controller
{
    public interface IMainForm
    {
        StudentBO Student { get; set; }
        
    }
}
