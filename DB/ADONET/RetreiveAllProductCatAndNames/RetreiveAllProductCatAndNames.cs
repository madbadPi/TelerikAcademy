using System;
using System.Data.SqlClient;

class RetreiveAllProductCatAndNames
{
    static void Main()
    {
        SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS; " +
            "Database=Northwind; Integrated Security=true");
        conn.Open();
        using (conn)
        {
            SqlCommand command = new SqlCommand(
                "SELECT p.ProductName, c.CategoryName "+
                "FROM Categories c "+
                "INNER JOIN Products p "+
                "ON c.CategoryID = p.CategoryID", conn);            
            SqlDataReader reader = command.ExecuteReader();           
            using (reader)
            {
                while (reader.Read())
                {
                    string productName = (string)reader["ProductName"];
                    string categoryName = (string)reader["CategoryName"];
                    Console.WriteLine("{0} - {1}", productName, categoryName);
                }
            }
            
        }
    }
}
