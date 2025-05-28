using System;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    internal class Ex_3
    {
        static void Main()
        {
            string CS = "Data Source = (localdb)\\MSSQLLocalDB;DataBase = NorthWind ; Integrated Security = true";

            string name = "Test Product";
            int sid = 1;
            int cid = 1;
            double price = 25;


            string query = "Insert into Products (ProductName,SupplierID,CategoryID,UnitPrice) values(@Name,@Sid,@Cid,@Price)";

            SqlConnection conn = new SqlConnection(CS);

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Sid", sid);
            command.Parameters.AddWithValue("@Cid", cid);
            command.Parameters.AddWithValue("@Price", price);



            try
            {
                conn.Open();

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Product Name : " + name + "Supplier Id : " + sid + "Customer Id : " + cid + "Price : " + price);
                }
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
}
