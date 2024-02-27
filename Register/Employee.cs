using System;

public class Employee
{
	string Name = "";
	double Salary = 0;

	public Employee()
	{
		Name = string.Empty;
	}

	public Employee(string name, double salary)
	{
		Name = name;
		Salary = salary;
	}
}
