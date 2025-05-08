using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)

    {
        List<int> num = new List<int>();
        num.Add(1);
        num.Add(2);
        num.Add(3);
        num.Add(4);

        foreach (int item in num)
        {
            Console.WriteLine(item);
        }
    }
}