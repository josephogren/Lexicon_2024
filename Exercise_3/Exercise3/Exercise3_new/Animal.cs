using System;
using System.Xml.Linq;

namespace Exercise3_new
{

    internal abstract class Animal
    {
        private string _name;
        private int _age;
        private string _description;


        public abstract void DoSound();

        public Animal() { }
        public Animal(string name, int age, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException($"'{nameof(description)}' cannot be null or whitespace.", nameof(description));
            }

            _name = name;
            _age = age;
            _description = description;
        }

        public override string ToString()
        {
            string animal_str = $"{_name}, {_age}; {_description}";
            return animal_str;
        }


    }

    //*** EXTENDED CLASSES

    internal class Horse : Animal
    {
        string def_property = "isHorse";
        public override void DoSound()
        {
            Console.WriteLine("Horse sound..");
        }
    }

    internal class Dog : Animal
    {
        string def_property = "isDog";
        public override void DoSound()
        {
            Console.WriteLine("Dog soiund..");
        }
    }

    internal class Hedgehog : Animal
    {
        string def_property = "isHedgehog";
        public override void DoSound()
        {
            Console.WriteLine("Hedgehog soiund..");
        }
    }

    internal class Wolf : Animal
    {
        string def_property = "isWolf";
        public override void DoSound()
        {
            Console.WriteLine("Wolf sound..");
        }
    }

    internal class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("Wolfman talks!"); ;
        }
    }

    internal class Bird : Animal
    {
        string def_property = "isBird";
        public override void DoSound()
        {
            Console.WriteLine("Bird sound..");
        }
    }

    internal class Worm : Animal
    {
        string def_property = "isWorm";
        public override void DoSound()
        {
            Console.WriteLine("Word sound..");
        }
    }

    internal class Pelican : Bird
    {
        string def_property = "isPelican";
        public string Property { get { return def_property; } }

    }

    internal class Flamingo : Bird
    {
        string def_property = "isFlamingo";
        public string Property { get { return def_property; } }
    }

    internal class Parroquet : Bird
    {
        private string def_property = "isParroquet";
        public string Property { get { return def_property; } }

    }

}
