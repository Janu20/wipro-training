using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num =10120300;
        string s = num.ToString();
        int count = 0;
        
        for(int i=0;i<s.Length;i++){
            if(s[i]=='0'){
                count++;
            }
            else{
                continue;
            }
            
        }
        Console.WriteLine(count);
    }
}