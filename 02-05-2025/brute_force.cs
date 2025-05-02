using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        
      int[] arr={2,4,3,5,7,6,9};
      Console.Write("Enter the target : ");
      int target = int.Parse(Console.ReadLine());
      Method(arr,target);
      
        
    }
    public static void Method(int[] arr,int target){
        for(int i=0;i<arr.Length;i++){
            for(int j= i+1;j<arr.Length;j++){
                if(arr[i]+arr[j]==target){
                    Console.WriteLine(arr[i]+ " + "+arr[j]+" = "+target);
                }
            }
        }
    }
}
