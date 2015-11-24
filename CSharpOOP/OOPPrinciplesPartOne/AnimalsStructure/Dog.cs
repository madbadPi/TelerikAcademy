namespace AnimalsStructure
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(string dogName, int dogAge, Sex dogSex)
            : base(dogName, dogAge, dogSex)
        {
        }

        public override void ProduceSound(Animal newCat)
        {
            Console.WriteLine("Bau");
        }
    }
}
