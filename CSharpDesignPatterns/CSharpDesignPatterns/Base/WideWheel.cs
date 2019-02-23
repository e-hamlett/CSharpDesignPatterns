using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public class WideWheel : AbstractWheel
    {
        public WideWheel(int size) : base(size, true)
        {
            Console.WriteLine("The size of the Wide Wheel is " + size + " inches.");
        }
    }
}
