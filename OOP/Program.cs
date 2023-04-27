using Library_Task.Book;
using System;
using System.Text;

namespace T4_Template_FileTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Les Miserables", "Victor Hugo", 1463, 19, "lS");
            Console.WriteLine(book.Name); // Output: Les Miserables
            Console.WriteLine(book.AuthorName); // Output: Victor Hugo
            Console.WriteLine(book.PageCount); // Output: 1463
            Console.WriteLine(book.Price); // Output: 19.99
            Console.WriteLine(book.Code);

            Library library = new Library(book);
        }
    }
}