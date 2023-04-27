using Library_Task.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Task.Library
{
    public class Library
    {
        private Book[] books;

        public Library()
        {
            this.books = new Book[0];
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref this.books, this.books.Length + 1);
            this.books[this.books.Length - 1] = book;
        }

        public Book GetBook(string name)
        {
            return Array.Find(books, book => book.Name == name);
        }

        public Book[] FindAllBooks(string name)
        {
            return Array.FindAll(this.books, book => book.Name == name);
        }

        //public int RemoveAllBooks()
        //{
         
        //}
    }
}
