using namespace Registry;


public static void Main(string[] args)
{
    bool isComplete = false;
    List<Employee> registryList = new List<Employee>();
    string input_name = "";
    double input_salary = 0.0;

    while (!isComplete)
    {
        Console.WriteLine("Name: ");
        Console.ReadLine(input_name);
        Console.WriteLine("Salary: ");
        Console.ReadLine(input_salary);

        char answer = 'n';
        Console.WriteLine("Add more? (y/n)");
        Console.ReadLine(answer);
        answer == 'y' ? isComplete = true : isComplete = false;

        Employee emp = new Employee(input_name, input_salary);
        registryList.Add(emp);

    }

    foreach (var emp in registryList)
    {
        Console.WriteLine(emp.toString());
    }

}