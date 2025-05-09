using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public int Salary;

        public void PrintDetails()
        {
            Console.WriteLine("Employee_ID : " + EmployeeID);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Department : " + Department);
            Console.WriteLine("Salary : " + Salary);
        }

        public void UpdateSalary()
        {
            Salary = Salary + 2000;
            Console.WriteLine("Updated Salary is : " + Salary);
        }

        public void AnnualSalary()
        {
            int Annual_sal = Salary * 12;
            Console.WriteLine("Annual Salary is : " + Annual_sal);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using ConsoleApp1;

class Program
{
    

    public static void Main()
    {
        Employee employee1 = new Employee();
        employee1.EmployeeID = 1;
        employee1.Name = " Janani G";
        employee1.Department = "Development";
        employee1.Salary = 90000;

        employee1.PrintDetails();
        employee1.UpdateSalary();
        employee1.AnnualSalary();

        Console.WriteLine(" ");

        Employee employee2 = new Employee { EmployeeID = 2,Name = "Usha",Department = "Testing",Salary = 50000};
        employee2.PrintDetails();
        employee2.UpdateSalary();
        employee2.AnnualSalary();
        

    }
}
