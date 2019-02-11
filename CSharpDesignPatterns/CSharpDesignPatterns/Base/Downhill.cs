using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    class Downhill : AbstractMountainBike
    {
        public Downhill(IWheel wheel) : this(BikeColor.Pink, wheel)
        {

        }

        public Downhill(BikeColor color, IWheel wheel) : base(color, wheel)
        {

        }
    }
}
