using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Chain
{
    class Honorable : Human
    {
        public override void GetNews(News news)
        {
            if (news != null && news.type == 0 && news.Counter < 10)
            {
                news.Counter++;
                human.GetNews(news);             
            }
        }
    }
}
