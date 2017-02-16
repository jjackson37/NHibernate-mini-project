using System;

namespace ObjectModelLayer
{
    public abstract class AquaticVehicle : Vehicle
    {
        public virtual bool hasCargo { get; set; }
        public virtual decimal? cargoWeight { get; set; }
    }
}