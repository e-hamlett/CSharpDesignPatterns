﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Bearings : IVisitable
    {
        public void AcceptVisitor(IWheelVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
