namespace FindAllCustByOrdersAndShipping
{
    using CreateDAOClass;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class Program
    {
        public static void FindCustomersByOrdersAndShipping(NorthwindEntities db, string shipCountry, int orderYear)
        {
            var selectedCustomers = db.Orders
                .Where(o => o.OrderDate.Value.Year == orderYear && o.ShipCountry == shipCountry)
                .Select(c => c.Customer.CompanyName)
                .ToList();

            Print(selectedCustomers);
        }

        public static void FindCustomersByOrdersAndShippingNativeSQL(NorthwindEntities db, string country, int year)
        {
            string nativeSQLQuery = "SELECT c.CompanyName " +
                                    "FROM Orders o " +
                                        "INNER JOIN Customers c " +
                                        "ON c.CustomerID = o.CustomerID " +
                                    "WHERE o.ShipCountry = 'Canada' AND DATEDIFF(YEAR, o.OrderDate, '1997') = 0 ";
            var selectedCustomers = db.Database.SqlQuery<string>(nativeSQLQuery).ToList();
            Print(selectedCustomers);
        }

        public static void Print(List<string> listOfCustomers)
        {
            foreach (var cust in listOfCustomers)
            {
                Console.WriteLine(cust);
            }
        }

        public static void FindSalesByRegionAndPeriod(NorthwindEntities db, string region, DateTime periodStartDate, DateTime periodEndDate)
        {
            var salesQuery = db.Orders
                .Where(o => o.ShipRegion == region && o.OrderDate >= periodStartDate && o.OrderDate <= periodEndDate)
                .Select(o => o.OrderID)
                .ToList();

            foreach (var sale in salesQuery)
            {
                Console.WriteLine(sale);
            }            
        }

        static void Main()
        {
            NorthwindEntities db = new NorthwindEntities();
            using (db)
            {
                //Write a method that finds all customers who have orders made in 1997 and shipped to Canada
                FindCustomersByOrdersAndShipping(db, "Canada", 1997);                
                Console.WriteLine("--------------");
                //Implement previous by using native SQL query and executing it through the DbContext
                FindCustomersByOrdersAndShippingNativeSQL(db, "Canada", 1997);
                Console.WriteLine("--------------");
                //Write a method that finds all the sales by specified region and period (start / end dates)
                FindSalesByRegionAndPeriod(db, "RJ", new DateTime(1996, 1, 1), new DateTime(1997, 12, 31));
            }
        }
    }
}
