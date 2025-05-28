using System;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace ConsoleApp2
{
    internal class Ex_4
    {
        static void Main()
        {
            Console.WriteLine("Enter the employee_id to be upated: ");

            int ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the title to be upated: ");

            string Title = Console.ReadLine();

            string CS = "Data Source = (localdb)\\MSSQLLocalDB;DataBase = NorthWind ; Integrated Security = true";

            string query = "Update Employees set Title = @title  where EmployeeID = @id ";

            SqlConnection conn = new SqlConnection(CS);

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@id", ID);
            command.Parameters.AddWithValue("@title", Title);

            try
            {
                conn.Open();

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("ID = " + ID + "Title = " + Title);
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
