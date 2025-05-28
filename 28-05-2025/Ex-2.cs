using System;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    internal class Ex_2
    {
        static void Main()
        {
            Console.WriteLine("Enter the customer id");
            string getid = Console.ReadLine();
            GetOrdersByCustomer(getid);
        }

        public static void GetOrdersByCustomer(string CustomerID)
        {
            string CS = "Data Source = (localdb)\\MSSQLLocalDB;DataBase = NorthWind ; Integrated Security = true";

            string query = "Select  OrderID, ShippedDate,ShipAddress from Orders where CustomerID = @getid";

            SqlConnection conn = new SqlConnection(CS);

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@getid", CustomerID);

            try
            {
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                  
                  DateTime ShippedDate = Convert.ToDateTime(reader[1]);
                  string ShipAddress = reader[2].ToString();

                    Console.WriteLine(reader[0].ToString().PadRight(30) + ShippedDate.ToString().PadRight(30) + ShipAddress);
                }

                reader.Close();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
