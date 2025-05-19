using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Book
    {
        public string Title;
        public string Author;

        // Constructor to create book with title and author
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        // Parameterless constructor for object initializer support
        public Book() { }
    }

    class Program
    {
        public static void Main()
        {
            // Queue of borrowed books
            Queue<Book> bookqueue = new Queue<Book>();
            bookqueue.Enqueue(new Book { Title = "AAA", Author = "AAA1" });
            bookqueue.Enqueue(new Book { Title = "BBB", Author = "BBB1" });
            bookqueue.Enqueue(new Book { Title = "CCC", Author = "CCC1" });
            bookqueue.Enqueue(new Book { Title = "DDD", Author = "DDD1" });
            bookqueue.Enqueue(new Book { Title = "EEE", Author = "EEE1" });

            Console.WriteLine("Borrowed books:");
            foreach (var book in bookqueue)
            {
                Console.WriteLine(book.Title + ", " + book.Author);
            }

            Console.WriteLine("\nThe next book to be returned is:");
            var peeking = bookqueue.Peek();
            Console.WriteLine(peeking.Title + " by " + peeking.Author);

            // Stack of new books
            Stack<Book> newBooks = new Stack<Book>();
            newBooks.Push(new Book("The Catcher in the Rye", "J.D. Salinger"));
            newBooks.Push(new Book("Brave New World", "Aldous Huxley"));
            newBooks.Push(new Book("Moby-Dick", "Herman Melville"));

            Console.WriteLine("\n📚 New Books Stack:");
            foreach (var book in newBooks)
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }

            // Display the last book purchased and process it
            if (newBooks.Count > 0)
            {
                Book lastPurchased = newBooks.Peek();
                Console.WriteLine($"\nLast book purchased: {lastPurchased.Title} by {lastPurchased.Author}");

                Book processedBook = newBooks.Pop();
                Console.WriteLine($"Processed: {processedBook.Title} by {processedBook.Author}");
            }

            // Print remaining borrowed books
            Console.WriteLine("\n📖 Remaining Borrowed Books:");
            foreach (var book in bookqueue)
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }

            // Print remaining new books
            Console.WriteLine("\n📚 Remaining New Books:");
            foreach (var book in newBooks)
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }
        }
    }
}
