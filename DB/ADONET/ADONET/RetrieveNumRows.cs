using System;
using System.Data.SqlClient;

class RetrieveNumRows
{
    static void Main()
    {
        SqlConnection sqlcon = new SqlConnection("Server=.\\SQLEXPRESS; " +
            "Database=Northwind; Integrated Security=true");
        sqlcon.Open();
        using (sqlcon)
        {
            //that retrieves from the Northwind sample database in MS SQL Server
            //the number of  rows in the Categories table
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Categories",sqlcon);
            Console.WriteLine((int)command.ExecuteScalar());
        }
    }
}
