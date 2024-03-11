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

            for (int i = 0; i < 10; i++)
            {
                list.Add(new Person(1+i, "Charlie-"+i)); 
            }

            foreach (var p in list)
            {
                Console.WriteLine(p); 
            }

            // *pause program*
            Console.Read();
            Console.Beep();
        }
    }
}
