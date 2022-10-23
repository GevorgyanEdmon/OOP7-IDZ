using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7_IDZ
{
    internal class Storage
    {
        private List<Genre> data;

        public Storage()
        {
            data = new List<Genre>();
        }
        public void Add(Genre genre)
        {
            data.Add(genre);
        }
        public void Delete(Genre genre)
        {
            if (data.Contains(genre))  data.Remove(genre);
            else Console.WriteLine("Жанр не найден");
        }
        public void Find(string name)
        {
            bool found = false;
            foreach (Genre genre in data)
            {
                List<Book> books = genre.GetList();
                foreach (Book user in books)
                {
                    if (name.Equals(user.name))
                    {
                        Console.WriteLine("Книга найдена, информация о жанре: ");
                        genre.GetInfo();
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Книга не найдена");
            }
        }
    }
}
