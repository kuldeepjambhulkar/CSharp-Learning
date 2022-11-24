using System;


namespace MethodOverriding
{
    internal class Employee
    {
        public virtual void PrintMessage() {
            Console.WriteLine("\nThis is Employee's Message()");
        }
    }
}
