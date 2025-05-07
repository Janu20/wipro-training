class Program
{
    public static void Main(string[] args)

    {

        string word = Console.ReadLine();

        string[] sp = word.Split(" ");

        bool[] has = new bool[sp.Length];

        Method(sp, has);
    }

        public static void Method(string[] sp, bool[] has)
        {
        for (int i = 0; i < sp.Length; i++)
        {
            if (has[i] == false)
            {
              for(int j = i + 1; j < sp.Length; j++)
                {
                    if (sp[i] == sp[j])
                    {
                        has[j] = true;
                    }
                }
            }
        }
        for(int k = 0; k < has.Length; k++)
        {
            if (has[k] == true) {

                Console.WriteLine(sp[k]);
            }
        }
       }
    
      
    }




