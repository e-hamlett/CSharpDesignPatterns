using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;


namespace Iterator
{
    public class RoadBikeRange
    {
        private IList<IBicycle> _bicycles;

        public virtual IList<IBicycle> Range
        {
            get
            {
                return _bicycles;
            }
        }

        public RoadBikeRange()
        {
            _bicycles = new List<IBicycle>();
            //defines the range of models
            _bicycles.Add(new Touring(new NarrowWheel(24)));
            _bicycles.Add(new Touring(BikeColor.Blue, new NarrowWheel(22)));
            _bicycles.Add(new Touring(BikeColor.Yellow, new NarrowWheel(23)));
            _bicycles.Add(new Vintage(new NarrowWheel(21)));
            _bicycles.Add(new Vintage(BikeColor.Gold, new NarrowWheel(25)));

        }

        public virtual IEnumerator<IBicycle> GetEnumerator()
        {
            return _bicycles.GetEnumerator();
        }
    }

}
