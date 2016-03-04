namespace ConcurrentChangesOnSameRecord
{
    using CreateDAOClass;
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            //Try to open two different data contexts and perform concurrent changes 
            //on the same records. What will happen at SaveChanges()? - it will going to update 
            //the record two times first to "Ihu" than to "Bla"
            //How to deal with it? - use only one connection

            var db1 = new NorthwindEntities();
            var db2 = new NorthwindEntities();

            Customer customer1 = db1.Customers.FirstOrDefault(c => c.CustomerID == "A");
            Customer customer2 = db2.Customers.FirstOrDefault(c => c.CustomerID == "A");
            customer1.ContactName = "Ihu";
            customer2.ContactName = "Bla";
            
            db1.SaveChanges();
            db2.SaveChanges();            
        }
    }
}
