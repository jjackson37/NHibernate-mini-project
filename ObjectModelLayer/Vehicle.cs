using System;

namespace ObjectModelLayer
{
    public abstract class Vehicle
    {
        public virtual Guid Id { get; set; }
        public virtual string vehicleName { get; set; }
        public virtual decimal currentFuel { get; set; }
        public virtual decimal maximumFuel { get; set; }
        public virtual decimal weight { get; set; }
        public virtual int currentPassengers { get; set; }
        public virtual int maximumPassengers { get; set; }
    }
}