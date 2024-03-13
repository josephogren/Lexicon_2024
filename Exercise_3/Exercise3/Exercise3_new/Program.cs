using System;
using System.Collections.Generic;

namespace Exercise3_new
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*** EXERCISE 3 ***");

            /* Create and populate list of UserErrors */
            List<UserError> errors = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError(),
                new CustomError1(),
                new CustomError2(),
                new CustomError3()
            };

            /* Create a handler for Persons */
            PersonHandler hPerson = new PersonHandler();      

            /* Create list of Persons */
            List<Person> listPersons = new List<Person>
            {
                hPerson.CreatePerson(11, "Alice", "AAA", 2.2, 3.3),
                hPerson.CreatePerson(32, "Bob", "BB", 2.2, 3.3),
                hPerson.CreatePerson(45, "Charlie", "CCCC", 2.2, 3.3),
        };

        /* Create list of Animals */
        List<Animal> listAnimals = new List<Animal>
            {
                new Horse("Jasper", 15, "horsie"),
                new Dog("Fido", 4, "doggie"),
                new Hedgehog("Pellur", 2, "hedgy"),
                new Wolf("Killer", 7, "wolfy"),
                new Bird("Pippi", 3, "birdy"),
                new Worm("Slinky", 1, "wormlike"),

                new Bird("PippiFlamingo", 3, "birdy"),
                new Bird("PippiPelican", 3, "birdy"),
                new Bird("Papegoja", 3, "birdy"),
                
        };
            Animal WolfMan = new Wolfman("Ajax", 44, "Half man, half wolf");
            listAnimals.Add(WolfMan);
            

            /* print list of persons */
            foreach (Person person in listPersons)
            {
                Console.WriteLine(person);
            }
            /* print list of animals */
            foreach (Animal animal in listAnimals)
            {
                Console.WriteLine(animal.Stats());
                
                if(animal is IPerson wlf) 
                {
                    wlf.Talk();                
                }
            }
            

            /* print list of errors */
            foreach (var error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            /// END PROGRAM ///

            /* pause program */
            Console.Read();
            Console.Beep();
        }
    }
}
