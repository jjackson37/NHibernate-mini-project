using HelperClasses.Measurements;
using System;

namespace ObjectModelLayer
{
    public class Motorbike : Automobile, ICloneable
    {
        public Motorbike()
        {

        }

        public Motorbike(string vehicleName, string numberPlate, FuelEconomy milage, Weight weight,
            Volume maximumFuel, int currentPassengers, int maximumPassengers, bool sideCar)
        {
            this.vehicleName = vehicleName;
            this.numberPlate = numberPlate;
            this.milage = milage;
            this.weight = weight;
            this.maximumFuel = maximumFuel;
            currentFuel = maximumFuel;
            this.currentPassengers = currentPassengers;
            this.maximumPassengers = maximumPassengers;
            this.sideCar = sideCar;
        }

        public virtual bool sideCar{get;set;}

        public virtual Motorbike Clone()
        {
            return (Motorbike)MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}