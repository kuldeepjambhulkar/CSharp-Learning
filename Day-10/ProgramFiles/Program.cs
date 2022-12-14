using System;
using System.Collections.Generic;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Keys must be unique

            Customer customer1 = new Customer(101, "Dwight");
            Customer customer2 = new Customer(102, "Meredith");
            Customer customer3 = new Customer(103, "Angela");
            Customer customer4 = new Customer(104, "Oscar");
            Customer customer5 = new Customer(105, "Kevin");


            Dictionary<int, Customer> CustomersDictionary = new Dictionary<int, Customer>();


            CustomersDictionary.Add(customer1.id, customer1);
            CustomersDictionary.Add(customer2.id, customer2);
            CustomersDictionary.Add(customer3.id, customer3);
            CustomersDictionary.Add(customer4.id, customer4);
            CustomersDictionary.Add(customer5.id, customer5);

            // finding a value in dictionary
            Console.WriteLine("\nPrinting an entry with key");
            Console.WriteLine(CustomersDictionary[101].id +" "+ CustomersDictionary[101].name);

            // traversing through each element of dictionary
            Console.WriteLine("\nTraversing through dictionary using KeyValuePair");
            foreach (KeyValuePair<int, Customer> customerKeyValuePair in CustomersDictionary) 
            {
                Console.WriteLine(customerKeyValuePair.Key  + " " + customerKeyValuePair.Value.name);
            }

            Console.WriteLine("\nTraversing through dictionary's keys");
            foreach (int key in CustomersDictionary.Keys) 
            {
                Console.WriteLine("Key: " + key);
            }

            Console.WriteLine("\nTraversing through dictionary's values");
            foreach (Customer value in CustomersDictionary.Values)
            {
                Console.WriteLine("Value.name: " + value.name);
            }

            Console.WriteLine("\nCount of Dictionary: ");
            Console.WriteLine(CustomersDictionary.Count);

            Console.WriteLine("\nRemoving an entry from dictionary");
            CustomersDictionary.Remove(101);

            Console.WriteLine("Printing after removal of 101 keyed entry");
            foreach (KeyValuePair<int, Customer> customerKeyValuePair in CustomersDictionary)
            {
                Console.WriteLine(customerKeyValuePair.Key + " " + customerKeyValuePair.Value.name);
            }
        }
    }
}