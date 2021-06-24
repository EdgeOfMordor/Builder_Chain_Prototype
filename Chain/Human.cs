using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Chain
{
    abstract class Human
    {
        public bool IsHonest { get; set; }

        public Human human { get; set; }


        
        public virtual void GetNews(News news)
        {
            if (news != null)
            {
                news.Counter++;
                human.GetNews(news);
            }
        }


    }
}
