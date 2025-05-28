using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    internal class Ex_10
    {
        static void Main()
        {
            string CS = "Data Source=(localdb)\\MSSQLLocalDB;Database=NorthWind;Integrated Security=true";

            string query = "SELECT ProductID, ProductName, UnitsInStock FROM Products";

            SqlConnection conn = new SqlConnection(CS);

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Products");

            
            DataTable productTable = ds.Tables["Products"];

            Console.WriteLine("Products with UnitsInStock > 20:\n");

            foreach (DataRow row in productTable.Rows)
            {
                int stock = Convert.ToInt32(row["UnitsInStock"]);

                if (stock > 20)
                {
                    Console.WriteLine("ID: " + row["ProductID"] +
                                      ", Name: " + row["ProductName"] +
                                      ", Stock: " + stock);
                }
            }
        }
    }
}
