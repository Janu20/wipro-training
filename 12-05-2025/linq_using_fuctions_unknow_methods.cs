using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Anil", "Sharma", "Abdullah", "Imran", "Siva", "Naresh", "Suresh", "Suma","Abcde" };

        UsingAnonymousMethods(names);


        
    }
    private static void UsingAnonymousMethods(string[] names)
    {
        Func<string, bool> filter = delegate (string s)
        {
            return s.Length == 5;
        };

        Func<string, string> extract = delegate (string s)
        {
            return s;
        };
        Func<string, string> project = delegate (string s)
        {
            return s.ToUpper();
        };



        IEnumerable<string> query = names.Where(filter)
                                   .OrderBy(extract)
                                   .Select(project);

        foreach (string item in query)
        
            Console.WriteLine(item);

        Console.Read();
    }
} 


/* Func<string, string> extract = delegate (string s)
 Func is a function 
<string,string> --> <input,output>
extract --> variable name(can give any names)
delegate(string s) --> unknown method method


