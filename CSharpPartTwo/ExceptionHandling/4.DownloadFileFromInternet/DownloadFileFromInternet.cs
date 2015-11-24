using System;
using System.Net;

class DownloadFileFromInternet
{
    static void Main()
    {
        try
        {
            WebClient test = new WebClient();
            test.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"../../Logo-BASD.jpg");
        }
        catch (WebException)
        {
            Console.Error.WriteLine("The address is invalid.");
        }
        catch (NotSupportedException)
        {
            Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
        }
    }
}
