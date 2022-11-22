using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloningAndCopyingObjects
{
    internal class Employee
    {
        private int empId;
        private string employeeName;

        public Employee ()
        {

        }
        public Employee(int id, string employeeName)
        {
            this.empId = id;
            this.employeeName = employeeName;
        }

        // copy constructor
        public Employee( Employee e) {
            this.empId = e.empId;
            this.employeeName = e.employeeName;
        }

        // returns clone of current object
        public Employee clone() {
            return new Employee(this.empId, this.employeeName);
        }

        public void setEmployeeId(int id) { 
            this.empId = id;
        }

        public int getEmployeeId()
        {
            return this.empId;
        }

        public void setEmployeeName(string name) { 
            this.employeeName = name;
        }
        public string getEmployeeName()
        {
            return this.employeeName;
        }
    }
}
