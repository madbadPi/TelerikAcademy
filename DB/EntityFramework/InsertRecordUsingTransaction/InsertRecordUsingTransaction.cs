namespace InsertRecordUsingTransaction
{
    using CreateDAOClass;
    using System;
    using System.Transactions;

    class InsertRecordUsingTransaction
    {
        private static void InsertOrderUsingExternalTransaction(NorthwindEntities db, Order order)
        {
            using (db)
            {
                using(var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Orders.Add(order);
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Can't insert record", ex.Message);
                        transaction.Rollback();
                    }
                }
            }
        }

        static void Main()
        {
            NorthwindEntities db = new NorthwindEntities();
            Order newOrder = new Order
            {
                CustomerID = "1",
                OrderDate = DateTime.Now,
                ShippedDate = DateTime.Now,
                ShipAddress = "Mladost 1",
                ShipCountry = "Bulgaria"
            };
            InsertOrderUsingExternalTransaction(db, newOrder);
        }        
    }
}
