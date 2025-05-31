using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Book
    {
       public  bool book_borrow = false;
        public int Book_Id;
        public string Title;
        public string Author;
        public string Description;

        public Book() { }
        public Book(int id, string title, string author, string description)
        {
            Book_Id = id;
            Title = title;
            Author = author;
            Description = description;
        }
    }
    class Student
    {
        public int Student_Id;
        public string Name;
        public string Department;


    }
    class Program
    {
        static void Main()
        {
            List<Book> list = new List<Book>();
            list.Add(new Book(1, "To Kill a Mockingbird", "Harper Lee", "A novel about racial injustice."));
            list.Add(new Book(2, "1984", "George Orwell", "A dystopian novel on surveillance and totalitarianism."));
            list.Add(new Book(3, "The Great Gatsby", "F. Scott Fitzgerald", "A critique of the American dream."));
            list.Add(new Book(4, "Pride and Prejudice", "Jane Austen", "A romantic novel about manners."));
            list.Add(new Book(5, "The Hobbit", "J.R.R. Tolkien", "A fantasy adventure in Middle-earth."));
            list.Add(new Book(6, "Moby Dick", "Herman Melville", "The quest to hunt the white whale."));
            list.Add(new Book(7, "War and Peace", "Leo Tolstoy", "A historical epic set during the Napoleonic Wars."));
            list.Add(new Book(8, "The Catcher in the Rye", "J.D. Salinger", "A teenager's journey through alienation."));
            list.Add(new Book(9, "Jane Eyre", "Charlotte Brontë", "A gothic romance with a strong heroine."));
            list.Add(new Book(10, "The Alchemist", "Paulo Coelho", "A philosophical story about following your dreams."));


            List<Student> students = new List<Student>();

            Console.WriteLine("_____LIBRARY MANAGEMENT______");
            Console.WriteLine("");

            Console.WriteLine("Select\n1.Librarian\n2.Student");
            int sel = Convert.ToInt32(Console.ReadLine());

            if (sel == 2)
            {

                Console.WriteLine("Enter your details :");
                Console.WriteLine("");

                Console.Write("Name : ");
                string name = Console.ReadLine();
               


                Console.Write("Student id : ");
                int s_id = Convert.ToInt32(Console.ReadLine());
                

                Console.Write("Department : ");
                string dept = Console.ReadLine();

                Student stu = new Student();
                stu.Name = name;
                stu.Student_Id = s_id;
                stu.Department = dept;
                students.Add(stu);


                Console.WriteLine("Would yoy like to view the list of books ? \n if yes then enter 'YES' ");

                string view_books = Console.ReadLine();
                if (view_books == "YES") ;
                {
                    foreach (Book items in list)
                    {
                        Console.WriteLine("Title : " + items.Title + " Author : " + items.Author + " Book_id : " + items.Book_Id + " Descriptions : " + items.Description);
                    }
                }
                Program.Borrow(list);
            }
            if (sel == 1)
            {
                Console.WriteLine("Choose\n1.Add\n 2.Delete");
                int Lib_sel = Convert.ToInt32(Console.ReadLine());
                if (Lib_sel == 1)
                {
                    Program.Adding(list);

                }
                else if (Lib_sel == 2)
                {
                    Program.Deleting(list);
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

            }
        }



       
        public static void Borrow(List<Book> list)
        {
           
                Console.Write("Select which book you need by Book_Id");
                int getid = Convert.ToInt32(Console.ReadLine());

                foreach (Book items in list)
                {
                    if (getid == items.Book_Id)
                    {
                    if (items.book_borrow == false)
                    {
                        Console.WriteLine("Sorry, this book is already borrowed.");
                    }
                        Console.WriteLine("You have Selected : ");
                        Console.WriteLine("");
                        Console.WriteLine("Title : " + items.Title + " Author : " + items.Author + " Book_id : " + items.Book_Id + " Descriptions : " + items.Description);

                        Console.WriteLine("You borrowed at " + DateTime.Today);

                        Console.WriteLine("Your due date is " + DateTime.Today.AddDays(7).ToShortDateString());
                        items.book_borrow = true;
                    }
                }
            }
          
        
        

        public static void Deleting( List<Book>list)
        {
            Console.WriteLine("Which book need to be deleted give the 'Book_Id' : ");
            int b_id = Convert.ToInt32(Console.ReadLine());

            foreach(Book items in list)
            {
                if(b_id == items.Book_Id)
                {
                    list.Remove(items);
                }
            }
            Console.WriteLine("Check the book list enter 'YES'");
             string check = Console.ReadLine();

            if(check == "YES")
            {
                foreach (Book items in list)
                {
                    Console.WriteLine("Title : " + items.Title + " Author : " + items.Author + " Book_id : " + items.Book_Id + " Descriptions : " + items.Description);
                }

            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }

        public static void Adding( List<Book>list) 
        {
            Console.WriteLine("Enter the details of the book to be added : ");
            Console.WriteLine("Book_id :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Book_name :");
            string name = Console.ReadLine();
            Console.WriteLine("Book_Author :");
            string auth = Console.ReadLine();
            Console.WriteLine("Book_description :");
            string desc = Console.ReadLine();


            list.Add (new Book { Book_Id = id , Title = name,Author=auth,Description=desc });

            Console.WriteLine("Check the book list enter 'YES'");
             string check = Console.ReadLine();

            if (check == "YES")
            {
                foreach (Book items in list)
                {
                    Console.WriteLine("Title : " + items.Title + " Author : " + items.Author + " Book_id : " + items.Book_Id + " Descriptions : " + items.Description);
                }

            }
            else
            {
                Console.WriteLine("Invalid input");
            }


        }

    }
}



