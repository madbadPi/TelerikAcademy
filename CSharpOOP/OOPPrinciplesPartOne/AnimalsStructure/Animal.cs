namespace AnimalsStructure
{
    using System;
    using System.Collections.Generic;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Sex Sex;
        
        public Animal(string currentName, int currentAge, Sex currentSex)
        {
            this.Name = currentName;
            this.Age = currentAge;
            this.Sex = currentSex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the animal can't be null or empty.");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The age of the animal can't be less than zero.");
                }
                this.age = value;
            }
        }
        
        public abstract void ProduceSound(Animal typeAnimal);

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
