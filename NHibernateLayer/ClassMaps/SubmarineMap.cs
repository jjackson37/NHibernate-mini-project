using FluentNHibernate.Mapping;
using ObjectModelLayer;

namespace NHibernateLayer.ClassMaps
{
    internal class SubmarineMap : ClassMap<Submarine>
    {
        public SubmarineMap()
        {
            Id(x => x.Id).GeneratedBy.GuidComb();
            Map(x => x.vehicleName).Not.Nullable();
            Map(x => x.weight).Not.Nullable();
            Map(x => x.hasCargo).Not.Nullable();
            Map(x => x.cargoWeight).Nullable();
            Map(x => x.currentFuel).Not.Nullable();
            Map(x => x.maximumFuel).Not.Nullable();
            Map(x => x.currentPassengers).Not.Nullable();
            Map(x => x.maximumPassengers).Not.Nullable();
            Map(x => x.submerged).Not.Nullable();
            Map(x => x.currentOxygenVolume).Not.Nullable();
            Map(x => x.maximumOxygenVolume).Not.Nullable();
        }
    }
}