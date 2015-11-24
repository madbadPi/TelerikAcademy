namespace Person
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person (string currentName, int? currentAge = null)            
        {
            this.Name = currentName;
            this.age = currentAge;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name can't be null.");
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("The age can't be negative.");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.age == null)
            {
                return "The name of the person is " + this.Name + " and the age has not been specified.";
            }
            return "The name of the person is" + this.Name + " and the age is " + this.age;
        }
    }
}
