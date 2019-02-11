using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    class CrossCountry : AbstractMountainBike
    {
        public CrossCountry(IWheel wheel) : this(BikeColor.Yellow, wheel)
        {

        }

        public CrossCountry(BikeColor color, IWheel wheel) : base(color, wheel)
        {

        }
    }
}
