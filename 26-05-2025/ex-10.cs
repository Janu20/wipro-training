using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string paragraph = @"This is a test. This test is only a test.
                             If this had been an actual emergency, you would have been instructed where to go.
                             This is only a test of the emergency broadcast system.";

       
        var words = paragraph
            .ToLower()
            .Split(new char[] { ' ', '.', ',', '!', '?', '\n', '\r', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

        
        Dictionary<string, int> wordFreq = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (wordFreq.ContainsKey(word))
                wordFreq[word]++;
            else
                wordFreq[word] = 1;
        }

       
        var top5 = wordFreq.OrderByDescending(pair => pair.Value).Take(5);

        Console.WriteLine("Top 5 Most Frequent Words:\n");

        foreach (var pair in top5)
        {
            Console.WriteLine($"Word: '{pair.Key}' - Frequency: {pair.Value}");
        }
    }
}
