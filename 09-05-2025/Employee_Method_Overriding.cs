 //employee class --> parent

  internal class Employee
 {
     public virtual void work()
     {
         Console.WriteLine("This is Employee method");
     }
 }

 // manager class --> child

  internal class Managar :Employee
 {
     public override void work()
    
     {
         Console.WriteLine("This is manager method");
     }
 }

 // main class

 class Program
{
    

    public static void Main()
    {
        Employee employee = new Employee();
        employee.work();

        

        Managar manager= new Managar();
        manager.work();
        

        Employee emp= new Managar();
        emp.work();

    }
}
