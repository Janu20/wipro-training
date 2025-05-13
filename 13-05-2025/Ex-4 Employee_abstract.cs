 abstract class Employee
 {
     public abstract void CalculateSalary();

     public void ShowBasicInfo()
     {
         Console.WriteLine("Employee details");
     }
 }
 
internal class FullTimeEmployee : Employee
{
    int basic_salary = 50000;
    int allowance = 2000;
    public override void CalculateSalary()
    {
        int salary = basic_salary + allowance;
        Console.WriteLine("Salary = " + salary);
    }
}

    class PartTimeEmployee : Employee
    {
        double hourly_rate= 10;
        double Hours_worked = 89;
        public override void CalculateSalary()
        {
            double Salary = hourly_rate * Hours_worked;
            Console.WriteLine("Salary =" + Salary);
        }
    }
class Program
{
    

    public static void Main()
    {


        Employee employee;

        employee= new FullTimeEmployee();

        
        employee.ShowBasicInfo();
        employee.CalculateSalary();

        employee = new PartTimeEmployee();

        employee.CalculateSalary();
        employee.CalculateSalary();
        







    }
}
