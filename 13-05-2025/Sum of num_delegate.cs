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
        delsum add;
        add = Sum;

        Console.WriteLine(add(3, 4));
    }
}



