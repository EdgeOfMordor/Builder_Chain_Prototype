using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Chain
{
    class Scandalmonger : Human
    {
        public override void GetNews(News news)
        {
            if (news != null)
            {
                news.Counter++;
                human.GetNews(news);
            }
        }
    }
}
