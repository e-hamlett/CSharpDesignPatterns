﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGenerator
    {
        //private - Access modifier that restricts access to the class only.
        //static - ensures no instances of this variable are able to be created. It can only be one.
        //volitale - indicates a field that may be modified by multiple threads that are executing at the same time.

        private static volatile SerialNumberGenerator instance;

        //object - the root of all objects in dotNet
        private static object synchronizationRoot = new object();

        private int _count = 12345;
        //property of the class serial number generator that is read-only
        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialNumberGenerator() { }

        public int NextSerial
        {
            get { return ++_count; }
        }
    }
}
