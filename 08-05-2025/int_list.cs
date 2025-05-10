using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main (){

        List <string> fruits = new List<string>(){"Apple","Banana"};
        fruits.Add("Cherry");
        fruits.Add("Mango");
        fruits.Add("Grapes");

        fruits.Insert(2,"Blueberry");

        fruits.Remove("Banana");

        fruits.RemoveAt(3);

        if(fruits.Contains("Apple")){
            Console.WriteLine("Present 'apple'");
        }
        else{
            Console.WriteLine("Not present 'apple'");
        }

        fruits.Sort();

        foreach(string intem in fruits){
            Console.WriteLine(item);
        }
}

}