using HelperClasses.Measurements;

namespace ObjectModelLayer
{
    public class Lorry : LandVehicle
    {
        public virtual bool hasLoad { get; set; }
        public virtual decimal? loadWeight { get; set; }
    }
}