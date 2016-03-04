using System;
using System.Data.SqlClient;

class AddRowInTable
{
    static void Main()
    {
        SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS; " +
            "Database=Northwind; Integrated Security=true");
        conn.Open();
        using (conn)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Products (ProductName, Discontinued) VALUES (@productName, @discontinued)", conn);
            command.Parameters.AddWithValue("@productName", "Bread");
            command.Parameters.AddWithValue("@discontinued", "1");            
            command.ExecuteNonQuery();
        }
    }
}
