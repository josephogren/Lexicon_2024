using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_new
{
    internal class Person
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

        public override string ToString()
        {
            string person_str = $"Name: {Name};  Age: {Age}";
            return person_str;
        }
    }
}
