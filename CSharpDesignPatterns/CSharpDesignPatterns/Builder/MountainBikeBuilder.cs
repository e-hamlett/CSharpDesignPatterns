using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Builder
{
    public class MountainBikeBuilder : BikeBuilder
    {
        private AbstractMountainBike _mountainBikeInProgress;

        public override IBicycle Bicycle
        {
            get
            {
                return _mountainBikeInProgress;
            }
        }

        public MountainBikeBuilder(AbstractMountainBike mountainBike)
        {
            this._mountainBikeInProgress = mountainBike;
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine(" Building MountainBike Handle Bars");
        }

        public override void BuildWideTires()
        {
            Console.WriteLine(" Building MountainBike Wide Tires");
        }
    }
}
