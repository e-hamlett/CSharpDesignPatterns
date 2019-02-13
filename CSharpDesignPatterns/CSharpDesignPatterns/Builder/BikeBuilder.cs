using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns; // we need access to this namespace in order to call IBicycle

namespace Builder
{
    public abstract class BikeBuilder
    {
        public abstract IBicycle Bicycle { get; }
        /* 
         * virtual keyword used to optionally override in child class
         * void means no return type
         * public is the access modifer - everyone can see
         */
        public virtual void BuildStreetTires() { }
        public virtual void BuildWideTires() { }
        public virtual void BuildHandleBars() { }
    }
}
