namespace ObjectModelLayer
{
    public abstract class Automobile : Vehicle
    {
        public virtual decimal milage { get; set; }
        public virtual string numberPlate { get; set; }
    }
}