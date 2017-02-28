using HelperClasses.Measurements;
using System;
using System.Collections.Generic;

namespace ObjectModelLayer
{
    public class Motorbike : Automobile, ICloneable
    {
        public Motorbike()
        {
            passengers = new List<Passenger>();
        }

        public Motorbike(string vehicleName, string numberPlate, FuelEconomy milage, Weight weight,
            Volume maximumFuel, int maximumPassengers, bool sideCar)
        {
            this.vehicleName = vehicleName;
            this.numberPlate = numberPlate;
            this.milage = milage;
            this.weight = weight;
            this.maximumFuel = maximumFuel;
            currentFuel = maximumFuel;
            this.maximumPassengers = maximumPassengers;
            this.sideCar = sideCar;
            passengers = new List<Passenger>();
        }

        public virtual bool sideCar { get; set; }

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