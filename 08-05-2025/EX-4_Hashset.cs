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
        List<int> numbers = new List<int> { 3, 3, 5, 6, 7, 9, 7, 4, 10, 8 };

        HashSet<int> num = new HashSet<int> (numbers);

        Console.WriteLine("Unique elements are : ");

        foreach(var item in num)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Count of unique elements : " + num.Count);





    }
}
