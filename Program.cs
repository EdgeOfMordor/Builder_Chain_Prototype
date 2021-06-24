using ConsoleApp5.Builder;
using ConsoleApp5.Chain;
using ConsoleApp5.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //WoodenHouseBuilder woodenHouse = new WoodenHouseBuilder();
            //ConcreteHouse concreteHouse = new ConcreteHouse();
            //new Director(concreteHouse).Construct();
            //new Director(woodenHouse).Construct();

            //Book book = new Book();
            //book.Name = "Name";
            //book.Author.Name = "AuthorName";
            //var book2 = (Book)book.Clone();
            //book2.Author.Name = "2Athorname";
            //Console.WriteLine(book.Author.Name);
            //Console.WriteLine(book2.Author.Name);

            Scandalmonger sc1 = new Scandalmonger();
            Scandalmonger sc2 = new Scandalmonger();
            Honorable hc = new Honorable();

            sc1.human = sc2;
            sc2.human = hc;
            hc.human = sc1;

            News news = new News(Chain.Type.Important, "Smot");

            sc1.GetNews(news);

            Console.WriteLine(news.Counter);

            Console.ReadKey();
        }
    }
}
