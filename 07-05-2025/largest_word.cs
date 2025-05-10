class Program
{
    public static void Main(string[] args)

    {

        string word = Console.ReadLine();
        string[] arr = word.Split(" ");
        Method(arr);
    }
    public static void Method(string[] arr)
    {


        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i].Length < arr[j].Length)
                {
                    string temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        Console.WriteLine(arr[arr.Length - 1]);
    }
}




