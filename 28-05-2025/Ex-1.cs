using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string CS = " Data Source = (localdb)\\MSSQLLocalDB ; Initial Catalog = NorthWind; Integrated Security = true ";

        string query = "Select CustomerID,CompanyName, Country from Customers";

        SqlConnection conn = new SqlConnection(CS);

        SqlCommand command = new SqlCommand(query, conn);

        try
        {
            conn.Open();
            SqlDataReader rd = command.ExecuteReader();

            Console.WriteLine("CustomerID".PadRight(20) + "CompanyName".PadRight(40) + "Country");
            Console.WriteLine("____________________________________________________________________________");

            while (rd.Read())
            {
               
                string CompanyName = rd[1].ToString();
                string Country = rd[2].ToString();


                Console.WriteLine(rd[0].ToString().PadRight(20) + CompanyName.PadRight(40) + Country);

            }
            rd.Close();
        }
        catch (Exception ex)
        {

        }
        finally
        {
            conn.Close();
        }
    }
}