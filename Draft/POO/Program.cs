

using System.Data;
using System.Data.Common;
using Npgsql;
using POO.Config;

var connection = PostgresConfig.GetConnection();
connection?.Open();

using var adapter = new NpgsqlDataAdapter("SELECT * FROM users", connection);

var dataTable = new DataTable();

adapter.Fill(dataTable);


foreach (dynamic row in dataTable.Rows) 
{   
    foreach (dynamic col in dataTable.Columns) 
    {
        Console.Write(row[col] + " ");
    }
    Console.WriteLine();
}