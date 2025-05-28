using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Ex_5
    {
        static void Main()
        {
            Console.WriteLine("Enter the Id to be deleted");
            int ID = Convert.ToInt32(Console.ReadLine());

            string CS = "Data Source = (localdb)\\MSSQLLocalDB;DataBase = NorthWind ; Integrated Security = true";

            string query = "Delete from Products Where ProductID = @id";

            SqlConnection conn = new SqlConnection(CS);

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", ID);

            try
            {
                conn.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Product deleted successfully.");
                }
                else
                {
                    Console.WriteLine("No product found with the given ID.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
