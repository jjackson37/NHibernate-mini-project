using FluentNHibernate.Mapping;
using ObjectModelLayer;

namespace NHibernateLayer.ClassMaps
{
    internal class CarMap : ClassMap<Car>
    {
        public CarMap()
        {
            Id(x => x.Id).GeneratedBy.GuidComb();
            Map(x => x.vehicleName).Not.Nullable();
            Map(x => x.numberPlate).Not.Nullable();
            Map(x => x.carType).Not.Nullable();
            Map(x => x.milage).Not.Nullable();
            Map(x => x.weight).Not.Nullable();
            Map(x => x.currentFuel).Not.Nullable();
            Map(x => x.maximumFuel).Not.Nullable();
            Map(x => x.currentPassengers).Not.Nullable();
            Map(x => x.maximumPassengers).Not.Nullable();
        }
    }
}
