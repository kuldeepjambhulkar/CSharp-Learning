using System;


namespace MethodOverriding
{
    internal class FullTimeEmployee : Employee
    {
        public override void PrintMessage()
        {
            Console.WriteLine("\nThis is FullTimeEmployee's Message()");
        }

    }
}
