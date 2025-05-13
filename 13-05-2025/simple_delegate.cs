using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

delegate void CustomDel(string s);
    
class TestClass
{
 // define a method that have same signature of the customdel
    static void Hello(string s)
    {
        Console.WriteLine("Heloo," + s + "!");
    }

    static void Main()
    {
        CustomDel hiDel;

        // declarig instance of the customdel
        hiDel = Hello;

        Console.WriteLine("Invoking delegate hiDel:");
        hiDel("A");
    }
}


