namespace EmployeeTest
{
    public class Employee
    {

        public int Id { get; set; }
        public string? Name { get; set; }

        public void printSomething(int a) { 
            Console.WriteLine(a);
        }

        public void printSomething(int a, char b)
        {
            Console.WriteLine(a + b);
        }
        public void printSomething(string a, int b)
        {
            Console.WriteLine(a + b);
        }

        public virtual void OverrideThisMethod() {
            Console.WriteLine("This is overriden method");
        }
    }
}