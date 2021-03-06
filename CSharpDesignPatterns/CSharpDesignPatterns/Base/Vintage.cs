﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    class Vintage : AbstractRoadBike
    {
        public override decimal Price { get; } = 600.00m;

        public Vintage(IWheel wheel) : this(BikeColor.Forrest, wheel)
        {

        }

        public Vintage(BikeColor color, IWheel wheel) : base(color, wheel)
        {

        }
    }
}
