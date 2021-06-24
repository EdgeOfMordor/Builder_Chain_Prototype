using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Builder
{
    abstract class Builder
    {
        public abstract void BuildFoundation();

        public abstract void BuildWalls();

        public abstract void BuildRoof();

        public abstract House GetResult();
    }
}
