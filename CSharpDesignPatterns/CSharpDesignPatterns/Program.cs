using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;
using Singleton;
using Adapter;
using Decorator;
using Facade;
using Iterator;
using Observer;
using Visitor;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitorPatternDemo();
            //ObserverPatternDemo();
            //IteratorPatternDemo2();
            //IteratorPatternDemo();
            //FacadePatternDemo();
            //DecoratorPatternDemo();
            //AdapterPatternDemo();
            //SingletonPatternDemo();
            //BuilderPatternDemo();
            //TouringBike();
            // VintageBike();
            //AbstractFactoryDemo();
        }

        private static void VisitorPatternDemo()
        {
            IWheel wheel = new NarrowWheel(24);
            wheel.AcceptVisitor(new WheelDiagnostics());
            wheel.AcceptVisitor(new WheelInventory());
        }

        private static void ObserverPatternDemo()
        {
            Speedometer mySpeedometer = new Speedometer();
            SpeedMonitor monitor = new SpeedMonitor(mySpeedometer);
            GearBox gearBox = new GearBox(mySpeedometer);

            // Set current speed property to a value
            mySpeedometer.CurrentSpeed = 10;
            mySpeedometer.CurrentSpeed = 20;
            mySpeedometer.CurrentSpeed = 25;
            mySpeedometer.CurrentSpeed = 30;
            mySpeedometer.CurrentSpeed = 35;
        }

        private static void IteratorPatternDemo2()
        {
            Console.WriteLine("=============== Road Bikes ================");
            RoadBikeRange roadRange = new RoadBikeRange();
            foreach (IBicycle bicycle in roadRange.Range)
            {
                Console.WriteLine(bicycle);
            }
            Console.WriteLine("============== Mountain Bikes ===============");
            MountainBikeRange mountainRange = new MountainBikeRange();
            foreach (IBicycle bicycle in mountainRange.Range)
            {
                Console.WriteLine(bicycle);
            }
        }

        private static void IteratorPatternDemo()
        {
            Console.WriteLine("=== Road Bikes ===");
            RoadBikeRange roadRange = new RoadBikeRange();
            PrintIterator(roadRange.GetEnumerator());
            Console.WriteLine("===============================================================");
            Console.WriteLine("=== Mountain Bikes ===");
            MountainBikeRange mountainRange = new MountainBikeRange();
            PrintIterator(mountainRange.GetEnumerator());

        }

        public static void PrintIterator(IEnumerator iter)
        {
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }

        /* Facade Design Pattern Method */
        private static void FacadePatternDemo()
        {
            BikeFacade facade = new BikeFacade();
            facade.PrepareForSale(new Downhill(BikeColor.Gold, new WideWheel(28)));
        }
        /* Decorator Design Pattern Method */
        private static void DecoratorPatternDemo()
        {
            //Standard Touring Bike
            IBicycle myTourBike = new Touring(BikeColor.Gold, new NarrowWheel(24));
            Console.WriteLine(myTourBike);

            myTourBike = new CustomGripOption(myTourBike);
            Console.WriteLine(myTourBike);

            myTourBike = new LeatherSeatOption(myTourBike);
            Console.WriteLine(myTourBike);

            myTourBike = new GoldFrameOption(myTourBike);
            Console.WriteLine(myTourBike);

        }

        private static void AdapterPatternDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();

            wheels.Add(new NarrowWheel(24));
            wheels.Add(new WideWheel(20));
            wheels.Add(new NarrowWheel(26));
            wheels.Add(new UltraWheelAdapter(new UltraWheel(28)));

            foreach (IWheel wheel in wheels)
            {
                Console.WriteLine(wheel);
            }
        }
        private static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("Next serial " + generator.NextSerial);
            Console.WriteLine("Next serial " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("Next serial " + generator.NextSerial);

        }
        private static void VintageBike()
        {
            AbstractRoadBike vintageRoadBike = new Vintage(BikeColor.Ocean, new NarrowWheel(10));
            BikeBuilder builder = new RoadBikeBuilder(vintageRoadBike);
            BikeDirector director = new RoadBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
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
