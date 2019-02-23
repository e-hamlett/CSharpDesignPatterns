using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            BuilderPatternDemo();
            TouringBike();
            //AbstractFactoryDemo();
        }

        private static void TouringBike()
        {
            AbstractRoadBike roadBike = new Touring(BikeColor.Gold, new NarrowWheel(12));
            BikeBuilder builder = new RoadBikeBuilder(roadBike);
            BikeDirector director = new RoadBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        }

        private static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new Downhill(BikeColor.Gold, new WideWheel(32));
            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);


        }
        private static void AbstractFactoryDemo()
        {
            /* Parent class object instance is created byt its child class.
             * This parent class can only see methods, or types that it creates and the child class uses.
             * Any methods or types created by the child cannot be seen unless it was first created by the parent. 
             */
            AbstractBikeFactory factory = new RoadBikeFactory();

            /*Create Bike Parts
             * Interface object is created. The factory  objects created above calls
             * the method that returns the intereface that it is assigned to. These
             * Create methods create a new object of a Frame or Seat. This object
             * can be either Road or Mountain. In this case the RoadFrame and RoadSeat.        
             */
            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            /*Show what we created
             * 
             */
            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }
    }
}
