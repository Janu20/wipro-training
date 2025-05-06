class Program
{
    public static void Main(string[] args)

    {

        string word = Console.ReadLine();
        int count = 0;

        for(int i = 0; i < word.Length; i++)
        {
            if (word[i]==' ')
            {
                count++;
            }
        }
        Console.WriteLine(count + 1);
        }

    }




