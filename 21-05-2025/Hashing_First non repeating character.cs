class Program
{
    static void Main()
    {
        string word = Console.ReadLine();

        Dictionary<char,int> dic = new Dictionary<char,int>();

        foreach (var c in word)
            {
            if (dic.ContainsKey(c))
            {
                dic[c]++;
            }
            else
            {
                dic[c] = 1;
            }
        }

        foreach(var c in word)
        {
              if (dic[c] == 1)
            {
                Console.WriteLine("The first non repeated character = " + c);
                return;
            }

        }
    }
}
