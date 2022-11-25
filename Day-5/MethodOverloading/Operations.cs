using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Operations
    {
        public void Add(int a, int b) { 
            Console.WriteLine(a + b);
        }

        // Number overloading
        public void Add(int a, float b, int c) {
            Console.WriteLine(a + b + c);
        }

        // Type overloading
        public void Add(float a, string b)
        {
            Console.WriteLine(a + b);
        }

        // Kind overloading
        public void Add(int a, float b, in string c)
        {
            Console.WriteLine(a + b + c);
        }


    }
}
