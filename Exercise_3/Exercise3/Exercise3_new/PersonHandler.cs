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

    }
}
