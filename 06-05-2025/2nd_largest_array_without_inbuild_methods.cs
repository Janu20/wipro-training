class Program
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

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[i])
                {
                    int temp;
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        Console.WriteLine("The 2nd largest element is = " + arr[arr.Length - 2]);

        }

    }