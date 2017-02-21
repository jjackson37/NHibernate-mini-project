using System;

namespace ObjectModelLayer
{
    public class Car : Automobile, ICloneable
    {
        public Car() { }

        public Car(string vehicleName, string numberPlate, CarType carType, decimal milage, decimal weight,
            decimal maximumFuel, int currentPassengers, int maximumPassengers)
        {
            this.vehicleName = vehicleName;
            this.numberPlate = numberPlate;
            this.carType = carType;
            this.milage = milage;
            this.weight = weight;
            this.maximumFuel = maximumFuel;
            currentFuel = maximumFuel;
            this.currentPassengers = currentPassengers;
            this.maximumPassengers = maximumPassengers;
        }

        public enum CarType
        {
            Unknown = 0,
            Hatchback = 1,
            Sedan = 2,
            SUV = 3,
            Coupe = 4,
            Convertible = 5
        }

        public virtual CarType carType { get; set; }
        public virtual Car Clone() { return (Car)MemberwiseClone(); }
        object ICloneable.Clone() { return Clone(); }
    }
}