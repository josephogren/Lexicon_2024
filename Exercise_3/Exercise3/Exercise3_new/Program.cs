using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

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
            Animal horse = new Horse("Jasper", 15, "horsie");
            Animal dog = new Dog("Fido", 4, "doggie");
            Animal hedgehog = new Hedgehog("Pellur", 2, "hedgy");
            Animal wolf = new Wolf("Killer", 7, "wolfy");
            Animal bird = new Bird("Pippi", 3, "birdy");
            Animal worm = new Worm("Slinky", 1, "wormlike");

            Bird flamingo = new Bird("PippiFlamingo", 3, "birdy");
            Bird pelican = new Bird("PippiPelican", 3, "birdy");
            Bird parroquet = new Bird("Papegoja", 3, "birdy");

            Wolfman wolfman= new Wolfman("Ajax", 44, "Half man, half wolf");

            listAnimals.Add(horse); listAnimals.Add(dog); listAnimals.Add(hedgehog); listAnimals.Add(wolf);
            listAnimals.Add(bird); listAnimals.Add(worm); listAnimals.Add(wolfman); listAnimals.Add(flamingo); listAnimals.Add(pelican); listAnimals.Add(parroquet);


            hPerson.SeedPersons(listPersons);
            

            //** PRINT PERSONS **//
            //foreach (Person person in listPersons) 
            //{
            //    Console.WriteLine(person);    
            //}
            
            //** PRINT ANIMALS **//
            foreach (Animal animal in listAnimals)
            {
                Console.WriteLine(animal.Stats());
            }

            /// END PROGRAM ///

            /* pause program */
            Console.Read();
            Console.Beep();
        }
    }
}
