// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
//ctrl K + C (Disable)
//ctrl K + U (Enable)
//ctl + .
//f9 breadkpoint
//shift + f5 => stop
//Console.ReadLine();

#region Read
SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
sqlConnectionStringBuilder.DataSource = ".";
sqlConnectionStringBuilder.InitialCatalog = "TestDB";
sqlConnectionStringBuilder.UserID = "cho";
sqlConnectionStringBuilder.Password = "122688$&@"; //password must be greater than 8
SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
string query = "select * from Tbl_Blog ";
sqlConnection.Open();
SqlCommand cmd = new SqlCommand(query, sqlConnection);
SqlDataAdapter adapter = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
adapter.Fill(dt);
sqlConnection.Close();

//dataset
//datatable
//data row
//data column
foreach (DataRow dr in dt.Rows)
{
    Console.Write(dr["BlogId"]);
    Console.WriteLine(dr["BlogTitle"]);
    Console.WriteLine(dr["BlogAuthor"]);
    Console.WriteLine(dr["BlogContent"]);
}


Console.ReadKey();

#endregion