using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    public class TestClass : TestInterface1, TestInterface2
    {
        void TestInterface1.InterfaceMethod() {
            Console.WriteLine("In testInterface1 method");
        }

        void TestInterface2.InterfaceMethod()
        {
            Console.WriteLine("In testInterface2 method");
        }
    }
}
