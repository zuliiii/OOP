using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Task.Book
{
    public class Book
    {

        public Book(string name, string authorName, int pageCount, int price, string code)
        {
            this.Name = name;
            this.AuthorName = authorName;
            this.PageCount = pageCount;
            this.Price = price;
            this.Code = code;

        }


        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public int Price { get; set; }

        public string Code
        {
            get; set;
        }

    }
}






