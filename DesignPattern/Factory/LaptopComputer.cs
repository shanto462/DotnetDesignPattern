﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    public class LaptopComputer : IComputer
    {
        public void ShutDown()
        {
            Console.WriteLine("Shutting down my Laptop :(");
        }
    }
}
