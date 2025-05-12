using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=true";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT ProductID, ProductName FROM Products";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Products");

            foreach (DataRow row in dataSet.Tables["Products"].Rows)
            {
                Console.WriteLine($"{row["ProductID"]}, {row["ProductName"]}");
            }
        }
    }
}
