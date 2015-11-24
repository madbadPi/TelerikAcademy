namespace AnimalsStructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnimalsTest
    {
        static void Main()
        {
            //List<Animal> animals = new List<Animal>
            Animal[] animals = new Animal[]
            {
                new Cat("Alex", 2, Sex.female),
                new Dog("Bruno",3, Sex.male),
                new Frog("Bro",4, Sex.male),
                new Tomcat("Tom", 2),
                new Kitten("Kitty", 5)
            };

            Console.WriteLine(animals.Average(a => a.Age));
        }
    }
}
