using HelperClasses.Measurements;
using System;
using System.Collections.Generic;

namespace ObjectModelLayer
{
    public class Lorry : Automobile, ICloneable
    {
        public Lorry()
        {
            passengers = new List<Passenger>();
        }

        public Lorry(string vehicleName, string numberPlate, FuelEconomy milage, Weight weight, bool hasLoad,
            Weight loadWeight, Volume maximumFuel, int maximumPassengers)
        {
            this.vehicleName = vehicleName;
            this.numberPlate = numberPlate;
            this.milage = milage;
            this.weight = weight;
            this.hasLoad = hasLoad;
            this.loadWeight = loadWeight;
            this.maximumFuel = maximumFuel;
            currentFuel = maximumFuel;
            this.maximumPassengers = maximumPassengers;
            passengers = new List<Passenger>();
        }

        public virtual bool hasLoad { get; set; }
        public virtual Weight loadWeight { get; set; }

        public virtual Lorry Clone()
        {
            return (Lorry)MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}