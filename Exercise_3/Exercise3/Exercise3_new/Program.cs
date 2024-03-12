using System;
using System.Collections.Generic;

namespace Exercise3_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** EXERCISE 3 ***");

            /* Create list for Persons and Animals */
            List<Person> listPersons = new List<Person>();
            List<Animal> listAnimals = new List<Animal>();
            
            /* Create a handler for Persons */
            PersonHandler hPerson = new PersonHandler();

            
            //** SEEDING ANIMALS **//
            Animal horse = new Horse();
            Animal dog = new Dog();
            Animal hedgehog = new Hedgehog();
            Animal wolf = new Wolf();
            Animal bird = new Bird();


            hPerson.SeedPersons(listPersons);
            

            //** PRINT PERSONS **//
            foreach (Person person in listPersons) 
            {
                Console.WriteLine(person);    
            }
            //** PRINT ANIMALS **//
            foreach (Animal animal in listAnimals)
            {
                Console.WriteLine(animal);
            }

            /// END PROGRAM ///

            /* pause program */
            Console.Read();
            Console.Beep();
        }
    }
}
