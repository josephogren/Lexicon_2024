using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** EXERCISE 3 ***");

            Person p = new Person(18, "Alice");

            Console.WriteLine(p);

            // *pause program*
            Console.Read();
            Console.Beep();
        }
    }
}
