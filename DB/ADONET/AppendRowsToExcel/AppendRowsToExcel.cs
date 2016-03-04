using System;
using System.Data.OleDb;

class AppendRowsToExcel
{
    static void Main()
    {
        string oledbconstr = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\Programming\\CS\\DB\\ADONET\\AppendRowsToExcel\\scores.xlsx; Extended Properties=\"Excel 12.0 Xml;HDR=YES\"";
        OleDbConnection conn = new OleDbConnection(oledbconstr);
        conn.Open();
        using (conn)
        {
            string query = "INSERT INTO [Sheet1$] VALUES(\"Petkan\",100)";
            OleDbCommand command = new OleDbCommand(query, conn);
            command.ExecuteNonQuery();
        }
    }
}
