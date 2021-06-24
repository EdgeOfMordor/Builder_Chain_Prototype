using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Builder
{
    class Director
    {
        Builder Builder { get; set; }
        public Director(Builder builder)
        {
            Builder = builder;
        }

        public void Construct()
        {
            Builder.BuildFoundation();
            Builder.BuildWalls();
            Builder.BuildRoof();
            Builder
                .GetResult()
                .Show();
        }
    }
}
