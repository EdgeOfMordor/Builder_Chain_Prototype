using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Prototype
{
    class Book : ICloneable
    {
        public string Name { get; set; }

        public Author Author { get; set; } = new Author();

        public object Clone()
        {
            var Author = new Author() { Name = this.Author.Name };
            return new Book() { Name = this.Name, Author = Author };
        }
    }

    public class Author
    {
        public string Name { get; set; }
    }
}
