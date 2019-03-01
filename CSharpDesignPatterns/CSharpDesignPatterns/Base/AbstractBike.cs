﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public abstract class AbstractBike : IBicycle
    {
        private BikeColor _color;
        private IWheel _wheel;

        public BikeColor ColorType
        {
            get
            {
                return _color;
            }
        }

        public IWheel GetWheel
        {
            get
            {
                return _wheel;
            }
        }

        public abstract decimal Price { get; }

        public AbstractBike(BikeColor color, IWheel wheel)
        {
            this._wheel = wheel;
            this._color = color;
        }

        public virtual void Paint(BikeColor color)
        {
            this._color = color;
        }

        public override string ToString()
        {
            return this.GetType().Name + " Bicycle Color is " + _color + " and the Price is $" + Price;
        }

        public virtual void CleanFrame()
        {
            Console.WriteLine("Cleaning Frame . . . ");
        }

        public virtual void AirTires()
        {
            Console.WriteLine("Airing Tires . . . .");
        }

        public virtual void TestRide()
        {
            Console.WriteLine("Taking Bike for a test ride . . . . .");
        }
    }
}
