using System;

namespace Inheritance
{
    internal class Employee
    {
        private int empId;
        private string employeeName;

        public Employee(int id, string employeeName)
        {
            this.empId = id;
            this.employeeName = employeeName;
        }

        public void setEmployeeId(int id)
        {
            this.empId = id;
        }

        public int getEmployeeId()
        {
            return this.empId;
        }

        public void setEmployeeName(string name)
        {
            this.employeeName = name;
        }
        public string getEmployeeName()
        {
            return this.employeeName;
        }
    }
}