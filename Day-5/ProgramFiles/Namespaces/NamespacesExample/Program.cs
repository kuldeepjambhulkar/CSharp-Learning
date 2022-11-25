using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;


namespace NamespacesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PATA.ClassA.print();
            // Output: In TeamA's print()

            PATB.ClassA.print();
            // Output: In TeamB's print()
        }
    }
}