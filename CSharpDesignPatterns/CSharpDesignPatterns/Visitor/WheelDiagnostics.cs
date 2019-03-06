using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Visitor
{
    public class WheelDiagnostics : IWheelVisitor
    {
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("Running Wheels Diagnotic Tests");
        }

        public void Visit(Spokes spokes)
        {
            Console.WriteLine("Running Spokes Diagnostic Test");
        }

        public void Visit(Bearings bearings)
        {
            Console.WriteLine("Running Bearings Diagnostic Test");
        }
    }
}
