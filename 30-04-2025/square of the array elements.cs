using System;

public class HelloWorld
{
    public static void method(int[] arr){
        for(int i=arr.Length-1;i >= 0;i--){
            Console.WriteLine("The "+ (i+1)+ " array element square number = " +(arr[i] *arr[i]));
        }
        
    }
    public static void Main(string[] args)
    {
        int [] arr ={10,20,30,40,50};
        method(arr);
    }
}