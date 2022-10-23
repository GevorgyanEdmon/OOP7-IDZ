using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7_IDZ
{
    internal class Book
    {
        public string name;
        public string author;
        public float price;
        public Book(string pAuthor, string pName, float pPrice)
        {
            name = pName;
            price = pPrice;
            author = pAuthor;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Название: {name} \n Цена: {price} \n Автор: {author}");
            Console.WriteLine();
        }
    }
}
