namespace CreateDAOClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CustomersFunctionality
    {
        public static string InsertCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("The customer can't be null");
            }
            else
            {
                var db = new NorthwindEntities();
                using (db)
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }
                return customer.CustomerID;
            }
        }
        public static void ModifyCustomer(string customerID, string contactName, string companyName, string address)
        {
            var db = new NorthwindEntities();
            using (db)
            {
                var customer = db.Customers
                .FirstOrDefault(c => c.CustomerID == customerID);
                customer.ContactName = contactName;
                customer.CompanyName = companyName;
                customer.Address = address;
                db.SaveChanges();
            }            
        }

        public static void DeleteCustomer(string customerID)
        {
            using (var db = new NorthwindEntities())
            {
                var customer = db.Customers
                    .FirstOrDefault(c => c.CustomerID == customerID);
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }
    }
}
