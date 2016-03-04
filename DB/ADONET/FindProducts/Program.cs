using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string inputstr = Console.ReadLine();
        //string inputstr = "Chef Anton's Cajun Seasoning, Aniseed Syrup, Grandma's Boysenberry Spread, none, true, chef, seasoning, Chai%, Chang\", Aniseed Syrup\\, Chef Anton's Cajun_Seasoning";
        string[] inputwords = inputstr.Split(new string[] { ", "},StringSplitOptions.None);
        string dbconnstr = "Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security=true";
        SqlConnection dbconn = new SqlConnection(dbconnstr);
        dbconn.Open();
        using (dbconn)
        {
            for (int i = 0; i < inputwords.Length; i++)
            {
                string inputword = inputwords[i];                
                SqlCommand command = new SqlCommand("SELECT COUNT(ProductName) FROM Products WHERE ProductName = @word", dbconn);
                command.Parameters.Add("@word", inputword);
                int counter = (int)command.ExecuteScalar();
                if (counter >= 1)
                {
                    Console.WriteLine(inputword);
                }
                //SqlCommand command = new SqlCommand("SELECT ProductName FROM Products", dbconn);
                //SqlDataReader reader = command.ExecuteReader();
                //using (reader)
                //{
                //    while (reader.Read())
                //    {
                //        string currentproduct = reader["ProductName"].ToString();
                //        for (int i = 0; i < inputwords.Length; i++)
                //        {
                //            if (currentproduct == inputwords[i])
                //            {
                //                Console.WriteLine(inputwords[i]);
                //                break;
                //            }
                //        }
                //    }
                //}
            }

        }
    }
}

