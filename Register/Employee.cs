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

	public void printEmployee() 
	{
		Console.Write("Employee: " + Name + ",  Salary: " + Salary + " SEK");
	}
}


// Second ClassTemplate

public class Employee2
{
	string Name = string.Empty;
	int Clearance = 99;

	void printEmployee() { System.Console.WriteLine($"Name: {}  (Code {Clearance})"); }

}