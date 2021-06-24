using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Builder
{
    class House
    {
        List<object> parts = new List<object>();

        string Type { get; set; }

        public House(string type)
        {
            Type = type;
        }

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine(Type);
            foreach(var p in parts)
            {
                Console.WriteLine(p);
            }
        }
    }
}
