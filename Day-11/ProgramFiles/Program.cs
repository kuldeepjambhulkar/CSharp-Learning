using System;

namespace ExplicitInterface
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            // testClass.InterfaceMethod(); Compile time error

            TestInterface1 testInterface1 = new TestClass();
            testInterface1.InterfaceMethod();

            TestInterface2 testInterface2 = new TestClass();
            testInterface2.InterfaceMethod();

        }
    }
}