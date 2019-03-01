using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Iterator
{
    public class MountainBikeRange
    {
        private IBicycle[] _bicycles;

        public virtual IBicycle[] Range
        {
            get { return _bicycles; }
        }
        public MountainBikeRange()
        {
            _bicycles = new IBicycle[5];
            //defines the range of MountainBikes available to purchase
            _bicycles[0] = new Downhill(new WideWheel(28));
            _bicycles[1] = new Downhill(BikeColor.Ocean, new WideWheel(26));
            _bicycles[2] = new Downhill(BikeColor.Orange, new WideWheel(29));
            _bicycles[3] = new CrossCountry(new WideWheel(23));
            _bicycles[4] = new CrossCountry(BikeColor.Purple, new WideWheel(22));
        }

        public virtual IEnumerator<IBicycle> GetEnumerator()
        {
            //explicit cast inorder to use the generic types and make the _bicycle array into a collection of numerable objects
            return ((IEnumerable<IBicycle>)_bicycles).GetEnumerator();
        }


    }
}
