using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
      int[] arr ={1,2,3,4,5,6,7};
      Method(arr,0);
    }
    public static void Method(int[] arr,int index){
        if(index >= arr.Length){
           return ;
        }
        else{
        
       Console.WriteLine(arr[index]);
       Method(arr,index+1);
      
        }
             
    }

}