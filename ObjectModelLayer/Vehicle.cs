﻿using HelperClasses.Measurements;
using System;

namespace ObjectModelLayer
{
    public abstract class Vehicle
    {
        public virtual Guid Id { get; set; }
        public virtual string vehicleName { get; set; }
        public virtual Volume currentFuel { get; set; }
        public virtual Volume maximumFuel { get; set; }
        public virtual Weight weight { get; set; }
        public virtual int currentPassengers { get; set; }
        public virtual int maximumPassengers { get; set; }
    }
}