using HelperClasses.Measurements;
using System;
using System.Collections.Generic;

namespace ObjectModelLayer
{
    public abstract class Vehicle : ObjectModel
    {
        public virtual Volume currentFuel { get; set; }
        public virtual Guid Id { get; set; }
        public virtual Volume maximumFuel { get; set; }
        public virtual int maximumPassengers { get; set; }
        public virtual string vehicleName { get; set; }
        public virtual Weight weight { get; set; }
        public virtual IList<Passenger> passengers { get; set; }
    }
}