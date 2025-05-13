using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

delegate void CustomDel(string s);
    
class TestClass
{
 // define a method that have same signature of the customdel
   static void Hello(String s)
    {
        Console.WriteLine("Hello" + s);
    }

    static void Goodbye(String s)
    {
        Console.WriteLine("Goodbye" + s);
    }

    static void Main()
    {
        CustomDel hiDel, byeDel, multiDel;

        hiDel = Hello;

        byeDel = Goodbye;

        multiDel = hiDel + byeDel;

        Console.WriteLine("Invoking delegate hiDel : ");
        hiDel("A");

        Console.WriteLine("Invoking delegate byeDel : ");
        byeDel("B");

        Console.WriteLine("Invoking delegate multiDel : ");
        multiDel("C");



    }
}



