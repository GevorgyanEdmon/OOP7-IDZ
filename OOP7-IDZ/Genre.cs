using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7_IDZ
{
    internal class Genre
    {
        private string name;
        private List<Book> books;

        public Genre(string pName)
        {
            name = pName;
            books = new List<Book>();
        }
        public void Add(Book book)
        {
            books.Add(book);
        }
        public void Delete(Book book)   
        {
            if (books.Contains(book))
            {
                books.Remove(book);
            }
            else
            {
                Console.WriteLine("Данная книга не найдена");
                Console.WriteLine();
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Название жанра: {name}  \nКоличество уникальных книг: {books.Count.ToString()}");
            Console.WriteLine();
        }
        public List<Book> GetList()
        {
            return books;
        }
    }
}
