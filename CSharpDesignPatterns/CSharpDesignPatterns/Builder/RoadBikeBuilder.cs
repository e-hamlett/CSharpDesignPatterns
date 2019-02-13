using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns; // Added to access the namespace

namespace Builder
{
    public class RoadBikeBuilder : BikeBuilder
    {
        /* 
         * Class object AbstractRoadBike is assigned by the constructor and retrieved
         * by the property Bicycle
         */
        private AbstractRoadBike _roadBikeInProgress;
        /*
         * Property of RoadBikeBuilder used to return an object of IBicycle.
         * This object is of type AbstractRoadBike that implements the IBicycle Interface
         */
        public override IBicycle Bicycle
        {
            get
            {
                return _roadBikeInProgress;
            }
        }
        /*
         * Constructorof the Class RoadBikeBuilder that takes a parameter
         * of AbstractRoadBike and assigns that parameter to the class field
         * _roadBikeInProgress
         */
        public RoadBikeBuilder(AbstractRoadBike roadBike)
        {
            this._roadBikeInProgress = roadBike;
        }
        /*  
         * method, public - access modifier, override - used todefine its behavior
         * instead of the parent class that it extends, void - no return type
         */
        public override void BuildStreetTires()
        {
            Console.WriteLine(" Building RoadBike Street Tires");
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine(" Building RoadBike Handle Bars");
        }

    }
}
