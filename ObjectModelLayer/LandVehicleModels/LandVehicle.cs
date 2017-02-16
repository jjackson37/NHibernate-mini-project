namespace ObjectModelLayer
{
    public abstract class LandVehicle : Vehicle
    {
        public virtual decimal milage { get; set; }
        public virtual string numberPlate { get; set; }
    }
}