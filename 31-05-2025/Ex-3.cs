using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Questions
    {
        public static void Main(string[] args)
        {
            int score = 0;
            Dictionary<int, string> questions = new Dictionary<int, string>();

            Console.WriteLine("--------Welcome to our Quiz--------");
            Console.WriteLine("");

            questions.Add(1, " What is the capital of Australia?");
            questions.Add(2, "Who wrote the play 'Romeo and Juliet'?");
            questions.Add(3, " Which planet is known as the Red Planet?");
            questions.Add(4, "What is the largest ocean on Earth?");
            questions.Add(5, "In which year did World War II end?");
            


            Random random = new Random();
            var To_suffle = questions.OrderBy(q => random.Next()).ToList();
            foreach (var item in To_suffle)
            {

                Console.WriteLine(item.Key + " --> " + item.Value);
                if (item.Key == 1)
                {
                    Console.WriteLine("1. Sydney\n2. Melbourne\n3. Canberra\n4. Brisbane");

                    int ans1 = Convert.ToInt32(Console.ReadLine());

                    if (ans1 == 3)
                    {
                        Console.WriteLine("Correct answers");
                        score += 10;
                    }
                    else if (ans1 == 1 || ans1 == 2 || ans1 == 4)
                    {
                        Console.WriteLine("Wrong answers");
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }

                if (item.Key == 2)
                {
                    Console.WriteLine("1. Charles Dickens\n2. William Shakespeare\n3. Jane Austen\n4. Mark Twain");

                    int ans2 = Convert.ToInt32(Console.ReadLine());

                    if (ans2 == 2)
                    {
                        Console.WriteLine("Correct answers");
                        score += 10;
                    }
                    else if (ans2 == 1 || ans2 == 3 || ans2 == 4)
                    {
                        Console.WriteLine("Wrong answers");
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }
                if (item.Key == 3)
                {
                    Console.WriteLine("1. Venus\n2. Mars\n3. Jupiter\n4. Mercury");

                    int ans3 = Convert.ToInt32(Console.ReadLine());

                    if (ans3 == 2)
                    {
                        Console.WriteLine("Correct answers");
                        score += 10;
                    }
                    else if (ans3 == 1 || ans3 == 3 || ans3 == 4)
                    {
                        Console.WriteLine("Wrong answers");
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }
                if (item.Key == 4)
                {
                    Console.WriteLine("1. Indian Ocean \n2. Atlantic Ocean \n3. Arctic Ocean \n4. Pacific Ocean");

                    int ans4 = Convert.ToInt32(Console.ReadLine());

                    if (ans4 == 4)
                    {
                        Console.WriteLine("Correct answers");
                        score += 10;
                    }
                    else if (ans4 == 1 || ans4 == 3 || ans4 == 2)
                    {
                        Console.WriteLine("Wrong answers");
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }
                if (item.Key == 5)
                {
                    Console.WriteLine("1. 1845 \n2. 1998 \n3. 1945 \n4. 1965");

                    int ans5 = Convert.ToInt32(Console.ReadLine());

                    if (ans5 == 3)
                    {
                        Console.WriteLine("Correct answers");
                        score += 10;
                    }
                    else if (ans5 == 1 || ans5 == 4 || ans5 == 2)
                    {
                        Console.WriteLine("Wrong answers");
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                    }
                }
                    }
            Console.WriteLine("Do you like to check Your Score ?\n Type 'YES' to view Score .");
            string view_score = Console.ReadLine();

            if (view_score == "YES")
            {
                Console.WriteLine("Your score = " + score);

                if (score == 0)
                {
                    Console.WriteLine(" Oops! Better luck next time. Don't give up!");
                }
                else if (score == 10)
                {
                    Console.WriteLine("Needs improvement. Time to hit the books!");
                }
                else if (score == 20)
                {
                    Console.WriteLine("Not bad, but you can definitely do better with some more practice.");
                }
                else if (score == 30)
                {
                    Console.WriteLine("Good effort! A little more revision and you'll ace it.");
                }
                else if (score == 40)
                {
                    Console.WriteLine("Great job! You really know your stuff.");
                }
                else if (score == 50)
                {
                    Console.WriteLine("Excellent! You're a quiz master!");
                }


            }
        }
        }
    }

