namespace ExecuteStoredProc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CreateDAOClass;

    class Program
    {
        static void Main()
        {
            var db = new NorthwindEntities();
            using (db)
            {
                var query = db.usp_FindTotalIncomeForSupplierAndPeriod("Exotic Liquids", new DateTime(1996, 1, 1), new DateTime(1997, 12, 31)).ToList();
                Console.WriteLine(query[0]);
            }
            
        }
    }
}
