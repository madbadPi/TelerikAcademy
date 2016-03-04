namespace CreateNorthwindTwin
{
    using System;
    using CreateDAOClass; 

    public class Start
    {
        static void Main()
        {
            //Create a database called NorthwindTwin with 
            //the same structure as Northwind using the 
            //features from DbContext
            //need to change the name of the initial catalog=NorthwindTwin in App.config
            using (var db = new NorthwindEntities())
            {
                db.Database.CreateIfNotExists();
            }
        }
    }
}
