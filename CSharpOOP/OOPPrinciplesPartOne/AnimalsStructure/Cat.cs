namespace AnimalsStructure
{
    using System;

    public class Cat : Animal, ISound
    {
        public Cat(string catName, int catAge, Sex catSex) 
            : base(catName, catAge, catSex)
        {
        }

        public override void ProduceSound(Animal newCat)
        {
            Console.WriteLine("Miau");
        }
    }
}
