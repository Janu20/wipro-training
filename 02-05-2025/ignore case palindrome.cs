using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        
        Console.Write("Give the word : ");
        string word = Console.ReadLine();
        
        
        string rev ="";
        
        for(int i=word.Length-1;i>=0;i--){
            rev+=word[i];
        }
       
        if(string.Equals(word,rev,StringComparison.OrdinalIgnoreCase)){
            Console.WriteLine("It is palindrome");
        }
        else{
            Console.WriteLine("It is not a palindrome");
        }
        
    }
}
