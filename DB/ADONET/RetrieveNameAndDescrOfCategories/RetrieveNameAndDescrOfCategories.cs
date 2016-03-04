using System;
using System.Data.SqlClient;

class RetrieveNameAndDescrOfCategories
{
    static void Main()
    {
        SqlConnection sqlcon = new SqlConnection("Server=.\\SQLEXPRESS; " +
            "Database=Northwind; Integrated Security=true");
        sqlcon.Open();
        using (sqlcon)
        {
            //retrieves the name and description of all categories in the Northwind DB
            SqlCommand command = new SqlCommand("SELECT CategoryName, Description FROM Categories", sqlcon);
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("{0} - {1}", categoryName, description);
                }
            }
        }
    }
}

