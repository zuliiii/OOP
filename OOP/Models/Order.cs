using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Task.Book;


namespace Library_Task.Order
{
    public class Order
    {
        
            public int Id { get; set; }
            public Book[] BookList { get; set; }
            public decimal TotalPrice { get; private set; }
            public DateTime Date { get; set; }

            public Order(int id, Book[] bookList, DateTime date)
            {
                Id = id;
                BookList = bookList;
                Date = date;
                CalculateTotalPrice();
            }

            private void CalculateTotalPrice()
            {
                TotalPrice = 0;
                foreach (var book in BookList)
                {
                    TotalPrice += book.Price;
                }

                decimal discountPercentage = 0;
                if (TotalPrice >= 100 && TotalPrice < 200)
                {
                    discountPercentage = 0.1m;
                }
                else if (TotalPrice >= 200)
                {
                    discountPercentage = 0.2m;
                }

                TotalPrice -= TotalPrice * discountPercentage;
            }
        }

    
}
