class program
{
    public static void Main(string[] args)

    {
        int[] arr = new int[5];
        Console.WriteLine("Enter the 5 arr elements :");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Method(arr);

    }
        public static void Method(int[] arr)
    {

        Array.Sort(arr); 
        Console.WriteLine("The 2nd largest element is : "+arr[arr.Length - 2]);
        
    }

}
    


