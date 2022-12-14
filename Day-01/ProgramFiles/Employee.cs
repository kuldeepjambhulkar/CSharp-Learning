 namespace MyProject
{
    internal class Employee
    {
        int empId;
        string employeeName;
        public Employee(int id, string employeeName)
        {
            this.empId = id;
            this.employeeName = employeeName;
        }

        public int getEmployeeId()
        {
            return this.empId;
        }
        public string getEmployeeName()
        {
            return this.employeeName;
        }
    }
}