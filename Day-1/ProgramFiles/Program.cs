namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        int count;
        int empId;
        string empName;

        Console.Write("Enter employee count: ");
        count = Convert.ToInt32(Console.ReadLine());
        
        Employee[] ArrayOfEmployees = new Employee[count];
        for (var i = 0; i < count; i++) {
            Console.Write("Enter employee ID: ");
            empId = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter employee Name: ");
            empName = Console.ReadLine();

            ArrayOfEmployees[i] = new Employee(empId, empName);
        }

        Console.WriteLine(ArrayOfEmployees[0].getEmployeeId());
        Console.WriteLine(ArrayOfEmployees[0].getEmployeeName());
    }
}