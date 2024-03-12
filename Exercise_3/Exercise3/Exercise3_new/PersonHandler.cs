using System.Collections.Generic;

namespace Exercise3_new
{
    internal class PersonHandler
    {
        public void SetAge(Person person, int age)
        {
            person.age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person(age, fname, lname, height, weight);
            return person;
        }

        public void SeedPersons(List<Person> list)
        {
            //** SEEDING PERSONS **//
            var p1 = CreatePerson(11, "Alice", "AAA", 2.2, 3.3);
            var p2 = CreatePerson(32, "Bob", "BB", 2.2, 3.3);
            var p3 = CreatePerson(45, "Charlie", "CCCC", 2.2, 3.3);

            list.Add(p1); list.Add(p2); list.Add(p3);

        }

    }
}
