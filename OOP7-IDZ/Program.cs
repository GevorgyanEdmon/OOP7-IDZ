using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7_IDZ
{
    class Programm
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Авонина К.Е.", "Романы", 466 );
            Book book2 = new Book("Генкин О.К.", "Список историй", 299);
            Book book3 = new Book("Жеров П.К.", "Черный кот", 400);
            book3.GetInfo();
            Book book4 = new Book("Иванов П.К.", "Готовка на улице", 100);
            Genre genre1 = new Genre("Роман");
            genre1.Add(book1);
            genre1.Add(book2);
            genre1.Delete(book2);
            Genre genre2 = new Genre("Истории");
            genre2.Add(book2);
            Genre genre3 = new Genre("Готовка");
            genre3.Add(book4);
            Storage data = new Storage();
            data.Add(genre1);
            data.Add(genre2);
            data.Add(genre3);

            data.Find("Романы");
            data.Find("Книга156");
        }
    }
}
