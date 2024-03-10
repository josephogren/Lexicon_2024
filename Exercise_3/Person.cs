using System;

//namespace OOP;
/// <summary>
/// Summary description for Class1
/// </summary>
public class Person
{
	//public int Id { get; set; }
	public string Name { get; set; }
	
	public int Age { get; set; }
	//public int Birth { get; set; }
	//public int Gender { get; set; }
		
	
	public Person(int age, string name)
	{
		this.Age = age;
		this.Name = name;
	}
}
