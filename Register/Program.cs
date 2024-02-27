using namespace Registry;



public static void Main(string[] args)
{
    Console.WriteLine("Name: ");
    // Read input
    Console.WriteLine("Salary: ");
    // Read input

    Employee emp = new Employee(nameEmployee, salaryEmployee);

    List<Employee> registryList = new List<Employee>();

    registryList.Add(emp);


}