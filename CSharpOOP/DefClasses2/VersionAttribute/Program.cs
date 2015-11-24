namespace VersionAttribute
{
    using System;
    
    [VersionAttribute("1.01")]
    class Program
    {
        static void Main()
        {
            object[] versionAttributes = typeof(Program).GetCustomAttributes(typeof(VersionAttribute), false);
            Console.WriteLine(versionAttributes[0]);
        }
    }
}
