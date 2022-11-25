using System;


namespace Interfaces
{
    internal class Customer : ICutsomer
    {
        public void print(string fname, string lname)
        {
            Console.WriteLine(fname + " " + lname);
        }

        public void print(string name) { 
            Console.WriteLine(name);
        }
    }
}
