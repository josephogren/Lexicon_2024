using System;

namespace Exercise3_new
{

    internal abstract class Animal
    {
        private readonly string _name;
        private readonly string _description;


        public abstract void DoSound();

        public Animal() { }
        public Animal(string name, string description)
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
            _description = description;
        }

    }

    //*** EXTENDED CLASSES

    internal class Horse : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Horse sound..");
        }
    }

    internal class Dog : Animal

    { public override void DoSound() 
        {
            Console.WriteLine("Dog soiund..");
        }
    }

    internal class Hedgehog : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Hedgehog soiund..");
        }
    }

    internal class Wolf : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Wolf sound..");
        }
    }

    internal class Bird : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Bird soiund..");
        }
    }



}
