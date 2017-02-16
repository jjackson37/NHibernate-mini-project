namespace ObjectModelLayer
{
    public class Submarine : AquaticVehicle
    {
        public virtual bool submerged { get; set; }
        public virtual decimal maximumOxygenVolume { get; set; }
        public virtual decimal currentOxygenVolume { get; set; }
    }
}