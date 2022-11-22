using System;

namespace CloningAndCopyingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Employee e1 = new Employee();
            e1.setEmployeeId(101);
            e1.setEmployeeName("John");
            Console.WriteLine("Original Employee e1: " + e1.getEmployeeId() + " " + e1.getEmployeeName());
            // Output: Original Employee e1: 101 John
            



            // Copying e1 into new object e2
            Employee e2 = e1;

            e2.setEmployeeId(102);
            e2.setEmployeeName("Alexa");
            Console.WriteLine("\nCopied Employee e2: " + e2.getEmployeeId() + " " + e1.getEmployeeName());
            // Output: Copied Employee e2: 102 Alexa

            Console.WriteLine("Original Employee e1: " + e1.getEmployeeId() + " " + e1.getEmployeeName());
            // Output: Original Employee e1: 102 Alexa







            // Cloning e3 from e1
            Employee e3 = e1.clone();
            e3.setEmployeeId(103);
            e3.setEmployeeName("Smith");
            Console.WriteLine("\nCloned Employee e3: " + e3.getEmployeeId() + " " + e3.getEmployeeName());
            // Output: Cloned Employee e3: 103 Smith

            Console.WriteLine("Original Employee e1: " + e1.getEmployeeId() + " " + e1.getEmployeeName());
            // Output: Original Employee e1: 102 Alexa



            // Equality comparison
            bool equality1 = e2 == e1 ? true : false;
            Console.WriteLine("e2 == e1 => " + equality1);
            // Output: e2 == e1 => True

            bool equality2 = e3 == e1 ? true : false;
            Console.WriteLine("e2 == e1 => " + equality2);
            // Output: e2 == e1 => False




            // Static methods: declared on Type level & not object level
            // Called with className
            // More about static methods (https://www.c-sharpcorner.com/UploadFile/abhikumarvatsa/static-methods-in-C-Sharp/)
            Program.ExampleStaticMethod();
            // Output: Hey, you are in ExampleStaticMethod()!
        

            // Instance methods
            // Methods that can be called by objects, like the setEmployeeID(), getEmployeeName()
        }

        static void ExampleStaticMethod() {
            Console.WriteLine("\nHey, you are in ExampleStaticMethod()!");
        }
    }
}