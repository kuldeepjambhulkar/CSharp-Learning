using System;
using PT = Person.Teacher;
using PS = Person.Student;

namespace NamespacesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PT.ClassTeacher.print();
            // Output: In Teacher's print()

            PS.ClassStudent.print();
            // Output: In Student's print()
        }
    }
}