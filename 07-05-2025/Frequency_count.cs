class Program
{
    public static void Main(string[] args)

    {
        int[] arr = {1,2,2,3,4,4,4 };
       
        bool[] has = new bool[arr.Length];

        Method(arr, has);
    }

    public static void Method(int[] arr, bool[] has)
    {
        int count = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (has[i] == false)
            {
                count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        has[j] = true;
                        count++;


                    }
                  
                }

                Console.WriteLine(arr[i] + " = " + count);
            }
        }
    }
}





