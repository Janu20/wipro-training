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
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        contacts.Add("9940199368", "Govin");
        contacts.Add("8754465098", "Padma");
        contacts.Add("7398665258", "Janani");
        contacts.Add("9847477966", "Deepak");
        contacts.Add("9765488745", "Tom");

        // updating padma number by removing and adding again

        contacts.Remove("8754465098");
        contacts.Add("875445074", "Padma");

        if (contacts.ContainsValue("Janani"))
        {
            Console.WriteLine("'Janani' is present");
        }
        else
        {

            Console.WriteLine("'Janani' is present");            
        }
        
        foreach (KeyValuePair<string,string> item in contacts){

            Console.WriteLine("Number : " + item.Key + " Names : " + item.Value);

        }
    }
}
