using System;
using System.IO;
using System.Security;


class ReadAndPrintFilePath
{
    static void Main()
    {
        try
        {
            //string filePath = @"C:\WINDOWS\win.in";
            string filePath = Console.ReadLine();
            string result = File.ReadAllText(filePath);
            Console.WriteLine(result);
        }
        catch (ArgumentException)
        {
            Console.Error.WriteLine("Path is a zero-length, contains only white space, or contains one or more invalid characters");
        }
        catch (PathTooLongException)
        {
            Console.Error.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("The specified path is invalid");
        }
        catch (IOException)
        {
            Console.Error.WriteLine("An I/O error occurred while opening the file");
        }
        catch (UnauthorizedAccessException)
        {
            Console.Error.WriteLine("Path specified a file that is read-only.");
        }        
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
    }
}
