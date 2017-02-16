namespace ObjectModelLayer
{
    public class Boat : AquaticVehicle
    {
        public enum BoatEnvironment
        {
            Sea = 0,
            River = 1,
            Lake = 2
        }

        public virtual BoatEnvironment boatEnvironment { get; set; }
    }
}