using HelperClasses.Measurements;
using System;

namespace ObjectModelLayer
{
    public class Lorry : Automobile, ICloneable
    {
        public virtual bool hasLoad { get; set; }
        public virtual Weight loadWeight { get; set; }

        public Lorry()
        {

        }

        public Lorry(string vehicleName, string numberPlate, FuelEconomy milage, Weight weight, bool hasLoad,
            Weight loadWeight, Volume maximumFuel, int currentPassengers, int maximumPassengers)
        {
            this.vehicleName = vehicleName;
            this.numberPlate = numberPlate;
            this.milage = milage;
            this.weight = weight;
            this.hasLoad = hasLoad;
            this.loadWeight = loadWeight;
            this.maximumFuel = maximumFuel;
            currentFuel = maximumFuel;
            this.currentPassengers = currentPassengers;
            this.maximumPassengers = maximumPassengers;
        }

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