using FluentNHibernate.Mapping;
using ObjectModelLayer;

namespace NHibernateLayer.ClassMaps
{
    internal class BalloonMap : ClassMap<Balloon>
    {
        private BalloonMap()
        {
            Id(x => x.Id).GeneratedBy.GuidComb();
            Map(x => x.vehicleName).Not.Nullable();
            Map(x => x.weight).Not.Nullable();
            Map(x => x.numSandbags).Nullable();
            Map(x => x.sandbagWeight).Nullable();
            Map(x => x.altitude).Not.Nullable();
            Map(x => x.currentFuel).Not.Nullable();
            Map(x => x.maximumFuel).Not.Nullable();
            Map(x => x.currentPassengers).Not.Nullable();
            Map(x => x.maximumPassengers).Not.Nullable();
        }
    }
}