using ConsoleApp4.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            Book book3 = new Book()
            {
                name = "QaracaqQiz",
                Price = 16,
                author = "M.I Haqverdiyev",
            };

            Book book4 = new Book()
            {
                name = "Ali ve nino",
                Price = 11,
                author = "Elekber Eliyev",
            };

            Book book5 = new Book()
            {
                name = "Tamasha",
                Price = 19,
                author = "Yetim Eyvaz",
            };

            Book book6 = new Book()
            {
                name = "Orxan",
                Price = 18,
                author = " Haqverdiyev ",
            };

            books.Add(book);
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);
            books.Add(book6);

            Data<Book> data = new Data<Book>();
            var result = data.FilterDatas(books, 10, 25);
            foreach(var item in result)
            {
                Console.WriteLine(item.name);
            }

        }
    }
}
