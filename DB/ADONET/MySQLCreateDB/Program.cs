using System;
using MySql.Data.MySqlClient;
//using MySql.Data;

class Program
{
    static void Main()
    {
        string connstring = "Server=127.0.0.1;Uid=root;Pwd=1234;DataBase=library";
        MySqlConnection dbconn = new MySqlConnection(connstring);
        AddBook("Emil in Lonneberga", "Astrid Lingren", "12.10.2001", "978-9188374240", dbconn);
        AddBook("Karlson on the Roof", "Astrid Lingren", "3.6.2009", "978-0192727725", dbconn);
        AddBook("A Brief History of Time", "Stephen Hawking", "1.1.2000", "978-0553380163", dbconn);
    }

    private static void AddBook(string bookName, string bookAuthor, string publDate, string ISBN, MySqlConnection dbconn)
    {
        int aID = 0;
        dbconn.Open();
        using (dbconn)
        {
            MySqlCommand checkIfAuthorExits = new MySqlCommand("SELECT AuthorID From authors Where AuthorName = @bookAuthor",dbconn);
            checkIfAuthorExits.Parameters.AddWithValue("@bookAuthor", bookAuthor);
            MySqlDataReader reader = checkIfAuthorExits.ExecuteReader();
            using (reader)
            {


                if (reader.Read())
                {
                    aID = (int)reader["AuthorID"];
                }
                else
                {
                    reader.Close();
                    string createAuthorStr = "INSERT INTO authors(AuthorName) VALUES(@authorName)";
                    MySqlCommand createAuthor = new MySqlCommand(createAuthorStr, dbconn);
                    createAuthor.Parameters.AddWithValue("@authorName", bookAuthor);
                    createAuthor.ExecuteNonQuery();
                    aID = (int)reader["AuthorID"];
                }
            }
            
            string commstr = "INSERT INTO books(BookName,AuthorID,PublishingDate,ISBN) VALUES(@BookName,@AuthorID,@PublishingDate,@ISBN)";            
            MySqlCommand command = new MySqlCommand(commstr, dbconn);
            command.Parameters.AddWithValue("@BookName", bookName);
            command.Parameters.AddWithValue("@AuthorID", aID);
            command.Parameters.AddWithValue("@PublishingDate", publDate);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.ExecuteNonQuery();
        }
    }
}
