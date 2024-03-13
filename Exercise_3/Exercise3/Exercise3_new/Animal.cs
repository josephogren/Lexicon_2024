using System;

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

        public virtual string Stats()
        {
            string stats = $"NAME: {_name},  DESCR: {_description},  AGE: {_age}, ";
            return stats;
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
        string unique_property = "isHorse";

        public Horse(string name, int age, string description) : base(name, age, description)
        {
        }

        public override string Stats() { return base.Stats() + $" U-PROP: {unique_property}"; }

        public override void DoSound()
        {
            Console.WriteLine("Horse sound..");
        }
    }

    internal class Dog : Animal
    {
        string unique_property = "isDog";

        public Dog(string name, int age, string description) : base(name, age, description)
        { }

        /* overrides */
        public override string Stats() { return base.Stats() + $" U-PROP: {unique_property}"; }
        public override void DoSound()
        {
            Console.WriteLine("Dog sound..");
        }
    }

    internal class Hedgehog : Animal
    {
        string unique_property = "isHedgehog";

        public Hedgehog(string name, int age, string description) : base(name, age, description)
        {
        }

        /* overrides */
        public override string Stats() { return base.Stats() + $" U-PROP: {unique_property}"; }
        public override void DoSound()
        {
            Console.WriteLine("Hedgehog sound..");
        }
    }

    internal class Wolf : Animal
    {
        string unique_property = "isWolf";

        public Wolf(string name, int age, string description) : base(name, age, description)
        {
        }

        /* overrides */
        public override string Stats() { return base.Stats() + $" U-PROP: {unique_property}"; }
        public override void DoSound()
        {
            Console.WriteLine("Wolf sound..");
        }
    }

    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, string description) : base(name, age, description)
        {
        }

        public void Talk()
        {
            Console.WriteLine("WolfMan talks!"); ;
        }
    }

    internal class Bird : Animal
    {
        string unique_property = "isBird";

        public Bird(string name, int age, string description) : base(name, age, description)
        {
        }

        /* overrides */
        public override string Stats() { return base.Stats() + $" U-PROP: {unique_property}"; }
        public override void DoSound()
        {
            Console.WriteLine("Bird sound..");
        }
    }

    internal class Worm : Animal
    {
        string unique_property = "isWorm";

        public Worm(string name, int age, string description) : base(name, age, description)
        {
        }

        /* overrides */
        public override string Stats() { return base.Stats() + $" U-PROP: {unique_property}"; }
        public override void DoSound()
        {
            Console.WriteLine("Word sound..");
        }
    }

    internal class Pelican : Bird
    {

        string unique_property = "isPelican";

        public Pelican(string name, int age, string description) : base(name, age, description)
        {
        }

        public string Property { get { return unique_property; } }

    }

    internal class Flamingo : Bird
    {

        string unique_property = "isFlamingo";

        public Flamingo(string name, int age, string description) : base(name, age, description)
        {
        }

        public string Property { get { return unique_property; } }
    }

    internal class Parroquet : Bird
    {

        private string unique_property = "isParroquet";

        public Parroquet(string name, int age, string description) : base(name, age, description)
        {
        }

        public string Property { get { return unique_property; } }

    }

}
