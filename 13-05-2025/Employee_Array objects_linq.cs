using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

public class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }

    public int Age { get; set; }

}

class Program
{
    static void Main(string[] args)
    {
        Employee[] EmployeeArray = new Employee[]
        {
            new Employee(){EmployeeID = 1, EmployeeName = "John", Age = 18},
            new Employee(){EmployeeID = 2, EmployeeName = "Steve", Age = 21},
            new Employee(){EmployeeID = 3, EmployeeName = "Bill", Age = 25},
            new Employee(){EmployeeID = 4, EmployeeName = "Ram", Age = 20},
            new Employee(){EmployeeID = 5, EmployeeName = "Ron", Age = 31},
            new Employee(){EmployeeID = 6, EmployeeName = "Chris", Age = 17},
            new Employee(){EmployeeID = 7, EmployeeName = "Rob", Age = 19},

        };
        /* Employee[] Employees = new Employee[10];

         int i = 0;

         foreach(Employee employee in EmployeeArray)
         {
             if(employee.Age >12 && employee.Age < 20)
             {
                 Employees[i] = employee;
                 Console.WriteLine(employee.EmployeeName);
                 i++;
             }
         }*/

       
        Employee[] EmployeeTeenager = EmployeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
        Employee Bill = EmployeeArray.Where(s => s.EmployeeName == "Bill").FirstOrDefault();
        Employee Employee5 = EmployeeArray.Where(s => s.EmployeeID == 5).FirstOrDefault();

        foreach(Employee emp in EmployeeTeenager)
        {
            Console.WriteLine(emp.EmployeeName);
        }
        
        Console.WriteLine(Bill.EmployeeName);
        Console.WriteLine(Employee5.EmployeeID);
    }
}
//FirstOrDefault -- give me the value if not fount dont show error instead of that give me default value





