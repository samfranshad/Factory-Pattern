﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public int NumberOfWheels { get; set; } = 4;
        public void Drive()
        {
            Console.WriteLine("Building a new Car!");
        }
    }
}
