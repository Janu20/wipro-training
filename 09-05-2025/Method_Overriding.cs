 //employee class --> parent

 internal class Employee
 {
     public void emp()
     {
         Console.WriteLine("This is Employee method");
     }
 }

// manager class --> child

    internal class Managar :Employee
    {
        public void Man()
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
        employee.emp();

        

        Managar manager= new Managar();
        manager.Man();
        manager.emp();

        Employee emppoly = new Managar();
        emppoly.emp();
    }
}

