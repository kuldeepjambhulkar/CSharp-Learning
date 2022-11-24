using System;


namespace MethodOverriding
{
    internal class PartTimeEmployee : Employee
    {
        public override void PrintMessage()
        {
            Console.WriteLine("\nThis is PartTimeEmployee's Message()");
        }

    }
}
