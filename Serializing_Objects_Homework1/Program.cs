using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializing_Objects_Homework1
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Объявить в консольном приложении класс Book с полями: название, стоимость, автор, год.
             * Создать коллекцию элементов Book и заполнить тестовыми данными. 
             * С помощью класса BinaryFormatter сохранить состояние приложения в двоичный файл.
             * 2. На основании задания 1 восстановить состояние приложения из двоичного файла.*/

            string name = "Ревизор";
            double cost = 50000;
            string author = "Гоголь Н.";
            int year = 2019;

            Book book1 = new Book(name, cost, author, year);
            Book book2 = new Book(name, cost, author, year);
            Book book3 = new Book(name, cost, author, year);
            Book book4 = new Book(name, cost, author, year);

            List<Book> books = new List<Book>() { book1, book2, book3, book4 };

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("book.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, books);
                Console.WriteLine("Объект создан");
            }

            using (FileStream fs = new FileStream("book.dat", FileMode.OpenOrCreate))
            {
                List<Book> newBooks = (List<Book>)formatter.Deserialize(fs);

                foreach (var book in newBooks)
                {
                    book.ShowBooks();
                }
            }

        }
    }
}
