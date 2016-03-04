using System;
using System.Data.OleDb;

class Program
{
    static void Main()
    {
        string connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\Programming\\CS\\DB\\ADONET\\ReadAndDisplayFromExcel\\scores.xlsx; Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\"";
        string query = "Select * From [Sheet1$]";
        OleDbConnection excelconn = new OleDbConnection(connString);
        excelconn.Open();
        using(excelconn)
        {
            OleDbCommand command = new OleDbCommand("Select * From [Sheet1$]", excelconn);
            OleDbDataReader reader = command.ExecuteReader();
            using(reader)
            {
                while (reader.Read())
                {
                    string name = reader[0].ToString();
                    string score = reader[1].ToString();
                    Console.WriteLine("{0}-{1}", name, score);
                }
            }
        }
    }
}
