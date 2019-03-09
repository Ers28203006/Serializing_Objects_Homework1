using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializing_Objects_Homework1
{
    [Serializable]
    class Book
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string name, double cost, string author, int year)
        {
            Name = name;
            Cost = cost;
            Author = author;
            Year = year;
        }

        public void ShowBooks()
        {
            Console.WriteLine("Название книги: {0}", Name);
            Console.WriteLine("Стоимость книги: {0}", Cost);
            Console.WriteLine("Автор книги: {0}", Author);
            Console.WriteLine("Год публикации книги: {0}", Year);
            Console.WriteLine("***********************");
        }

    }
}
