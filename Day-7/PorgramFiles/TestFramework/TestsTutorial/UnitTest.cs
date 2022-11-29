using System;
using EmployeeTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsTutorial
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestEmployeeConstructor()
        {
            Employee employee = new Employee();
            employee.Id = 101;
            //employee.Name = "Kevin";

            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Name == null ? "Name is null" : employee.Name);
        }
        
        [TestMethod]
        public void TestEmployeeMethodOverloading() {
            Employee employee = new Employee();
            employee.printSomething(1);
            employee.printSomething(1, 'a');
            employee.printSomething("aaa", 1);
        }

        [TestMethod]
        public void TestEmployeeMethodOverriding() {
            Employee employee = new FullTimeEmployee();
            employee.OverrideThisMethod(); 
        
        }
    }
}