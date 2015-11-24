namespace AnimalsStructure
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string frogName, int frogAge, Sex frogSex)
            : base(frogName, frogAge, frogSex)
        {
        }

        public override void ProduceSound(Animal newCat)
        {
            Console.WriteLine("Croak");
        }
    }
}
