using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Ex_6
    {
        static void Main()
        {
            string CS = "Data Source = (localdb)\\MSSQLLocalDB;DataBase = NorthWind ; Integrated Security = true";

            string query = "SELECT o.OrderID, c.CompanyName, o.OrderDate FROM Orders o INNER JOIN Customers c ON o.CustomerID = c.CustomerID";

            SqlConnection con = new SqlConnection(CS);

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    int id = Convert.ToInt32(r[0]);
                    string name = r[1].ToString();
                    string Orderdate = r[2].ToString();

                    Console.WriteLine(id + "       " + name + "       " + Orderdate);


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }
    }
}
