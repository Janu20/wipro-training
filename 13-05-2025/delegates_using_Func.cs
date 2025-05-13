using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

delegate int delsum(int a,int b);
    
class TestClass
{
 // define a method that have same signature of the customdel
  
    public static int  Sum(int a,int b)
    {
        return a + b;    }
    static void Main()
    {
        Func<int, int, int> Add = Sum;

        Console.WriteLine(Add(10, 10));
    }
}



