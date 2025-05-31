using System;
using System.Collections.Generic;
using System.Linq;

class Ex-5
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph:");
        string paragraph = Console.ReadLine();

        
        string cleaned = new string(paragraph
            .Where(ch => char.IsLetterOrDigit(ch) || char.IsWhiteSpace(ch))
            .ToArray());

        string[] wordList = cleaned
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        
        var wordCount = new Dictionary<string, int>();
        foreach (string word in wordList)
        {
            string w = word.ToLower();
            if (wordCount.ContainsKey(w))
                wordCount[w]++;
            else
                wordCount[w] = 1;
        }

        
        int vowels = 0, consonants = 0;
        foreach (char letter in paragraph.ToLower())
        {
            if (char.IsLetter(letter))
            {
                if ("aeiou".Contains(letter))
                    vowels++;
                else
                    consonants++;
            }
        }

        
        string longestWord = "", shortestWord = "";
        if (wordList.Length > 0)
        {
            longestWord = wordList[0];
            shortestWord = wordList[0];

            foreach (string word in wordList)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;

                if (word.Length < shortestWord.Length)
                    shortestWord = word;
            }
        }

        
        Console.WriteLine("\n--- Word Count ---");
        foreach (var words in wordCount)
        {
            Console.WriteLine($"{words.Key} : {words.Value}");
        }

        Console.WriteLine($"\nTotal Vowels: {vowels}");
        Console.WriteLine($"Total Consonants: {consonants}");
        Console.WriteLine($"Longest Word: {longestWord}");
        Console.WriteLine($"Shortest Word: {shortestWord}");
    }
}