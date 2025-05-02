using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int[] arr={90,40,70,50,60,20,30};
     Method(arr);
     Console.WriteLine("Sorted array : ");
     for(int i=0;i<arr.Length;i++){
         Console.WriteLine(arr[i]);
     }
}
public static void Method(int[] arr){
    for(int i=0;i<arr.Length;i++){
        for(int j=i+1;j<arr.Length;j++){
            if(arr[i]>arr[j]){
                int temp = arr[j];
                arr[j]=arr[i];
                arr[i]=temp;
            }
        }
    }
}
}

