using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            
            op.Add(10, 20);
            // Output: 30

            // Type overloading
            op.Add(4.5f, " this is string");
            // Ouptut: 4.5 this is string

            // Number overloading
            op.Add(10, 4.5f, 20);
            // Output: 34.5

            // Kind overloading
            op.Add(10, 4.5f, "this is string");
            // Ouptput: 14.5this is string
        }
    }
}