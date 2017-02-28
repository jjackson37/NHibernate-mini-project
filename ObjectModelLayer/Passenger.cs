using System;

namespace ObjectModelLayer
{
    public class Passenger : ObjectModel
    {
        public Passenger()
        {
        }

        public Passenger(string firstName, string lastName, Vehicle vehicleId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public virtual Guid Id { get; set; }
        public virtual string firstName { get; set; }
        public virtual string lastName { get; set; }
    }
}