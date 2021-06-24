using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Builder
{
    class ConcreteHouse : Builder
    {
        House house = new House("Concrete");
        public override void BuildFoundation()
        {
            house.Add("Concrete foundation");
        }

        public override void BuildRoof()
        {
            house.Add("Concrete roof");
        }

        public override void BuildWalls()
        {
            house.Add("Concrete walls");
        }

        public override House GetResult()
        {
            return house;
        }
    }
}
