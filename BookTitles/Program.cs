using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book01 = new Book();
            Book book02 = new Book();
            Book book03 = new Book();

            book01.Title = "Harry Potter";
            book02.Title = "Hitchikers Guide To The Galaxy";
            book03.Title = "Lord Of The Rings";

            List<Book> list = new List<Book>();
            list.Add(book01);
            list.Add(book02);
            list.Add(book03);

            Console.WriteLine(list[0].Title);
            Console.WriteLine(list[1].Title);
            Console.WriteLine(list[2].Title);
        }
    }
}
