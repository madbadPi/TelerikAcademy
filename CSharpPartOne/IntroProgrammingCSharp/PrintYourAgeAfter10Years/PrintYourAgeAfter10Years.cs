using System;

class PrintYourAgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Write your age");
        string ageStr = Console.ReadLine();
        try
        {
            int age = int.Parse(ageStr);
            if ((age <= 0) || (age >= 120))
            {
                throw new OverflowException();
            }
            else
            {
                age = age + 10;
                DateTime date = DateTime.Today;
                date = date.AddYears(10);
                Console.WriteLine("Your age on " + date + " will be " + age);                
            }

        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Age missing.");           
        }
        catch (FormatException)
        {
            Console.WriteLine("Not a valid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Not a valid age.");
        }     
    }
}
