using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.StudentsOrganizer.Model
{
    public class Class1
    {

        public void Test()
        {
            StudentBO s = new StudentBO();
            s.FirstName = "Iulia";
            s.Gender = "F";

            StudentDAO dao = new StudentDAO();
            dao.AddStudent(s);
        }
    }
}
