namespace ObjectModelLayer
{
    public class Car : LandVehicle
    {
        public enum CarType
        {
            Hatchback = 0,
            Sedan = 1,
            SUV = 2,
            Coupe = 3,
            Convertible = 4
        }

        public virtual CarType carType { get; set; }

    }
}