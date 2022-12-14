using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.print("Michael", "Scott");
            // Output: Michael Scott

            customer.print("Michael");
            // Output: Michael
        }
    }
}