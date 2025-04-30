using System;

public class HelloWorld
{
    public static void method(int[] arr){
        for(int i=0;i<arr.Length;i++){
            Console.WriteLine("The " + (i+1) + " Array element is = " +arr[i]);
        }
        
    }
    public static void Main(string[] args)
    {
        int [] arr ={10,20,30,40,50};
        method(arr);
    }
}