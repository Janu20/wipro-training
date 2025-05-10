using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
class Program
{
    public static void Main()
    {
        ArrayList num = new ArrayList();

        num.Add(20);
        num.Add(10);
        num.Add(30);
        num.Add(80);
        num.Add(100);
        num.Add(40);
        num.Add(50);
        num.Add(70);
        num.Add(60);
        num.Add(90);

        num.Sort();
        Console.WriteLine("Numbers after sorted : " );

        foreach( var item in num)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("The max vaue is : " + num[num.Count - 1]);
        Console.WriteLine("The max vaue is : " + num[0]);

        Console.WriteLine("Average of all num : ");


        int sum = 0;
        
        foreach (var item in num)
        {
            
            sum += Convert.ToInt32(item);
        }
        Console.WriteLine(sum / num.Count);

        

    }
}