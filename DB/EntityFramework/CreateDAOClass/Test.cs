namespace CreateDAOClass
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Test
    {
        static void Main()
        {
            //insert a list of customers
            List<Customer> listOfCustomers = new List<Customer>{
                new Customer() { 
                    CustomerID = "AAAB",
                    CompanyName = "Bety", 
                    Address = "Mladost 1 bl.1A",
                    ContactName = "Ivan Ivanov"},
                new Customer() {
                    CustomerID = "BB",
                    CompanyName = "Plastic", 
                    Address = "Liulin 7",
                    ContactName = "Ani Angelova"},
                new Customer() {
                    CustomerID = "BC",
                    CompanyName = "InovativeTech", 
                    Address = "Liulin 1",
                    ContactName = "Pesho Angelov"}
            };
            Console.WriteLine("Insert customers:");
            for (int i = 0; i < listOfCustomers.Count; i++)
            {                
                CustomersFunctionality.InsertCustomer(listOfCustomers[i]);
                Console.WriteLine("{0}-{1}-{2}-{3}", listOfCustomers[i].CustomerID, listOfCustomers[i].ContactName, listOfCustomers[i].CompanyName, listOfCustomers[i].Address);
            }
            Console.WriteLine("-----------------");
            //modify customers
            Console.WriteLine("Modify customers:");
            for (int i = 0; i < listOfCustomers.Count; i++)
            {
                string address = "new adress";
                string companyName = "new company";
                string contactName = "new contact name";
                CustomersFunctionality.ModifyCustomer(listOfCustomers[i].CustomerID, contactName, companyName, address);                
                Console.WriteLine("{0}-{1}-{2}-{3}", listOfCustomers[i].CustomerID, listOfCustomers[i].ContactName, listOfCustomers[i].CompanyName, listOfCustomers[i].Address);
            }
            Console.WriteLine("-----------------");
            //delete customers
            Console.WriteLine("Delete customers:");
            for (int i = 0; i < listOfCustomers.Count; i++)
            {                
                CustomersFunctionality.DeleteCustomer(listOfCustomers[i].CustomerID);                
                Console.WriteLine("{0}-{1}-{2}-{3}", listOfCustomers[i].CustomerID, listOfCustomers[i].ContactName, listOfCustomers[i].CompanyName, listOfCustomers[i].Address);
            }
        }
    }
}
