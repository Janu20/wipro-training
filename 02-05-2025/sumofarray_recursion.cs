using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
      int sum = 0;    
      int[] arr ={1,2,3,4,5,6,7};
      Method(arr,0,sum);
     
     
    }
    public static void Method(int[]arr,int index,int sum){
        
        if(index >= arr.Length){
            Console.WriteLine(sum);
            return;
        }
        sum += arr[index];
        
        Method(arr,index+1,sum);
        
    }  
    }

