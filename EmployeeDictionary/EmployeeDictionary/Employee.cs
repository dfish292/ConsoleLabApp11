using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public int ID;
        public string Print()
        {
            return ID + ":  " + FirstName + " " + LastName;
        }
    }
}
