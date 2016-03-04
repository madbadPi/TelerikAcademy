using System;
using System.Data.SqlClient;
using System.IO;

class RetrieveAndStoreImagesFromTable
{
    static void Main()
    {
        SqlConnection dbcon = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security=true");
        dbcon.Open();
        byte[] imageByteArray;
        using (dbcon)
        {            
            SqlCommand command = new SqlCommand("SELECT CategoryID, Picture FROM Categories", dbcon);
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    //retrieve image
                    imageByteArray = (byte[])reader["Picture"];
                    string filename = "Picture" + (int)reader["CategoryID"] + ".jpg";                    
                    FileStream stream = File.OpenWrite(filename);
                    using (stream)
                    {
                        //store image in file
                        stream.Write(imageByteArray, 0, imageByteArray.Length);
                    }
                }
            }
        }
    }
}

