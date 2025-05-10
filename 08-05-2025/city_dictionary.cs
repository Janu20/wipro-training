using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
class Program
{
    public static void Main()
    {
        Dictionary<string, string> cities = new Dictionary<string, string>
        {
            {"Mumbai","Maharashta" },
            {"Bangalore","Karnataka" },
            {"Chennai","Tamil Nadu" },
            {"Kolkata","West Bengal" },
            {"Hyderabad","Telangana" }
        };
        Console.WriteLine("Indian Cities and their States: ");

       

        foreach (var item in cities)
        {
            Console.WriteLine(item.Key+" is in "+item.Value);
        }

        if (cities.ContainsKey("Chennai"))
        {
            Console.WriteLine("Chennai is present in the dictionary");
        }
    }
}