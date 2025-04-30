using System;

public class HelloWorld
{
    public static int method(int[] arr){
        int max =arr[0];
        for(int i=0;i<arr.Length;i++){
            if(max<arr[i]){
                max=arr[i];
            }
        }
        
        return max;
    }
    public static void Main(string[] args)
    {
       int[] arr ={20,35,90,345,23,46};
      Console.WriteLine( method(arr));
           
    }
}