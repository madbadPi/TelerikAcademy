using System;

class ReadDifferentTypeVariable
{
    static void Main()
    {
        Console.WriteLine("Enter type int, double or string of the variable ");
        string typeVariable = Console.ReadLine();
        switch (typeVariable)
        {
            case "int": Console.WriteLine("Enter the value of the variable:");
                var intVariable = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine("The type of the variable is {0} and the value is {1}", typeVariable, intVariable);
                break;
            case "double": Console.WriteLine("Enter the value of the variable:");
                var doubleVariable = double.Parse(Console.ReadLine()) + 1;
                Console.WriteLine("The type of the variable is {0} and the value is {1}", typeVariable, doubleVariable);
                break;
            case "string": Console.WriteLine("Enter the value of the variable:");
                var stringVariable = Console.ReadLine() + "*";
                Console.WriteLine("The type of the variable is {0} and the value is {1}", typeVariable, stringVariable);
                break;    
            default: Console.WriteLine("Wrong type"); break;
        }
    }
}