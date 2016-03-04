namespace InheritingEmployeeClass
{
    using System;
    using System.Collections.Generic;
    using CreateDAOClass;
    using System.Data.Linq;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            Employee testempl = new Employee();
            var db = new NorthwindEntities();            
            using (db)
            {
                
                Employee empl = db.Employees.First();             

                var territories = empl.TerritoriesSet;
                
                Console.WriteLine("All territories for employee {0} are:", empl.FirstName);
                
                foreach (var territory in territories)
                {
                    Console.WriteLine(territory.TerritoryDescription);
                }
            }

        }
    }
}
