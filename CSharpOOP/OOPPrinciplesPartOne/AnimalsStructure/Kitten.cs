namespace AnimalsStructure
{
    using System;

    class Kitten : Cat, ISound
    {
        public Kitten(string kittenName, int kittenAge)
            : base(kittenName, kittenAge, Sex.female)
        {
        }
    }
}
