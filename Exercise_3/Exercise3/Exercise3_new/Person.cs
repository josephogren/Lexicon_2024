namespace Exercise3_new
{
    internal class Person
    {

        private int _age;
        private string _fName;
        private string _lName;
        private double height;
        private double weight;

        public int age
        {
            get => _age;
            set => _age = ((value > 0) ? value : 0);
        }

        public string fName
        {
            get => _fName;
            set => _fName = value;
            //set { if (fName.Length >= 2 && fName.Length <= 10) _fName = value;  }
        }

        public string lName
        {
            get => _lName;
            set => _fName = value;
            //set { if (lName.Length >= 2 && lName.Length <= 10) _lName = value; }
        }

        public Person(int age, string fName = "N/A", string lName = "N/A", double height = 0.0, double weight = 0.0)
        {
            this.age = age;
            this.fName = fName;
            this.lName = lName;
            this.height = height;
            this.weight = weight;
        }

        public override string ToString()
        {
            string person_str = $"Name: {fName}, {lName};  Age: {age}; Height: {height}; Weight: {weight}";
            return person_str;
        }
    }
}
