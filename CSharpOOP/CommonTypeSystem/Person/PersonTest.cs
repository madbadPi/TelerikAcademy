namespace Person
{
    using System;

    public class PersonTest
    {
        static void Main(string[] args)
        {            
            Person newPerson = new Person("Ivo");
            Person otherPerson = new Person("Alex", null);
            Person seconPerson = new Person("Ani", 24);
            Console.WriteLine(newPerson);
            Console.WriteLine(otherPerson);
            Console.WriteLine(seconPerson);                   
        }
    }
}
