using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Builder
{
    class WoodenHouseBuilder : Builder
    {
        House house = new House("Wooden");
        public override void BuildFoundation()
        {
        }

        public override void BuildRoof()
        {
            house.Add("Wooden Roof");
        }

        public override void BuildWalls()
        {
            house.Add("Wooden walls");
        }

        public override House GetResult()
        {
            return house;
        }
    }
}
