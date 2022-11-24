
/*
    Que: What is Polymorphism?
        - Polymorphism enables us to invoke derived class's method, using a base class reference variable ar runtime
 */

using System;

namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] arrayOfEmployees = new Employee[3];

            arrayOfEmployees[0] = new Employee();
            arrayOfEmployees[1] = new FullTimeEmployee();
            arrayOfEmployees[2] = new PartTimeEmployee();

            foreach (Employee e in arrayOfEmployees) {
                e.PrintMessage();
            }
            /*
                This is Employee's Message()
                This is FullTimeEmployee's Message()
                This is PartTimeEmployee's Message()
             */
        }
    }
}