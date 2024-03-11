using System;
using System.Collections.Generic;

namespace Exercise3_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** EXERCISE 3 ***");

            List<Person> list = new List<Person>();

            PersonHandler hPerson = new PersonHandler();


            var p1 = hPerson.CreatePerson(1433, "tt", "bbb", 2.2, 3.3);

            Console.WriteLine(p1);


            //for (int i = 0; i < 10; i++)
            //{
            //    list.Add(new Person());
            ////}

            //foreach (var p in list)
            //{
            //    Console.WriteLine(p);
            //}

            // *pause program*
            Console.Read();
            Console.Beep();
        }
    }
}
