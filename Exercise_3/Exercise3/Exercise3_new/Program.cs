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
            Animal worm = new Worm();

            Bird flamingo = new Bird();
            Bird pelican = new Bird();
            Bird parroquet = new Bird();

            Wolfman wolfman= new Wolfman();

            listAnimals.Add(horse); listAnimals.Add(dog); listAnimals.Add(hedgehog); listAnimals.Add(wolf);
            listAnimals.Add(bird); listAnimals.Add(worm); listAnimals.Add(wolfman); listAnimals.Add(flamingo); listAnimals.Add(pelican); listAnimals.Add(parroquet);


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
