using System;

class LCSExample
{
    public static void LCS(string X, string Y)
    {
        int m = X.Length;
        int n = Y.Length;
        int[,] dp = new int[m + 1, n + 1];

        // Fill the dp table
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (X[i - 1] == Y[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        // Recover the LCS string
        int index = dp[m, n];
        char[] lcs = new char[index];
        int a = m, b = n;

        while (a > 0 && b > 0)
        {
            if (X[a - 1] == Y[b - 1])
            {
                lcs[index - 1] = X[a - 1];
                a--; b--; index--;
            }
            else if (dp[a - 1, b] > dp[a, b - 1])
                a--;
            else
                b--;
        }

        Console.WriteLine("LCS length: " + dp[m, n]);
        Console.WriteLine("LCS: " + new string(lcs));
    }

    public static void Main()
    {
        Console.WriteLine("Enter first string:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter second string:");
        string str2 = Console.ReadLine();

        LCS(str1, str2);
    }
}
