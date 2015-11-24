using System;

class ReadPrintCompanyAndManagerInfo
{
    static void Main()
    {
        Console.WriteLine("Write company name, address, phone number, fax number and web site:");
        string name = Console.ReadLine();
        string address = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        Console.WriteLine("Write company manager first name, last name, age and a phone number:");
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string age = Console.ReadLine();
        string managerPhoneNum = Console.ReadLine();
        Console.WriteLine("Company information:\nname :{0}\naddress : {1}\nphone number : {2}\nfax number : {3}\nweb site : {4}", name, address, phoneNumber, faxNumber, webSite);
        Console.WriteLine("Manager information:\nname :{0} {1}\nage : {2}\nphone number : {3}", firstName, lastName, age, managerPhoneNum);
    }
}
