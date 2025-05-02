using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr={10,20,30,40,50,60};
        int target = int.Parse(Console.ReadLine());
        Method(arr,target);
        
        
    }
    public static void Method(int[] arr,int target){
        for(int i=0;i<arr.Length;i++){
            if(target == arr[i]){
                Console.WriteLine(" The target  " + arr[i] +" found at index "+i);
                return;
            }
           
        }
         Console.WriteLine("Target not found" );
    }
}