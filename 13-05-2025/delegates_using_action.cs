using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

delegate void delsum(int a);
    
class TestClass
{
 // define a method that have same signature of the customdel
  
    public static void noreturndel1(int a)
    {
        Console.WriteLine("There is no return type 1");
    }
    public static void noreturndel2(int a)
    {
        Console.WriteLine("There is no return type 2");
    }
    static void Main()
    {
        Action<int> ac1 = noreturndel1;  // action is used instead of func because there is no return type 

        Action<int> ac2 = noreturndel2;  // if there is a return type in method go for func<>

        ac1(1);
        ac2(89);
    }
}


