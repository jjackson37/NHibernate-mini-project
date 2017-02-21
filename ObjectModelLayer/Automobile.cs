using HelperClasses.Measurements;

namespace ObjectModelLayer
{
    public abstract class Automobile : Vehicle
    {
        public virtual FuelEconomy milage { get; set; }
        public virtual string numberPlate { get; set; }
    }
}