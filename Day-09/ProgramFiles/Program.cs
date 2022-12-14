using System;

namespace PartialClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FName = "John";
            customer.LName = "Wick";

            Console.WriteLine(customer.getFullName());
        }
    }
}