﻿using FactoryMethodPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factory
{
    public class BikeFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}
