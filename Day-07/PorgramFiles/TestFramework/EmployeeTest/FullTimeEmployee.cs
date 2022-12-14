using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest
{
    public class FullTimeEmployee : Employee
    {
        public override void OverrideThisMethod() {
            Console.WriteLine("This is from FTE's Overriden method");
        }
    }
}
