using FluentNHibernate.Mapping;
using ObjectModelLayer;

namespace NHibernateLayer.ClassMaps
{
    internal class LorryMap : ClassMap<Lorry>
    {
        public LorryMap()
        {
            Id(x => x.Id)
                .GeneratedBy.GuidComb();

            Map(x => x.vehicleName).Not
                .Nullable();

            Component(x => x.maximumFuel)
                .ColumnPrefix("maximum");

            Component(x => x.currentFuel)
                .ColumnPrefix("current");

            Component(x => x.weight);

            Map(x => x.currentPassengers)
                .Not.Nullable();

            Map(x => x.maximumPassengers)
                .Not.Nullable();

            Component(x => x.milage);
            Map(x => x.numberPlate);
            Map(x => x.hasLoad);

            Component(x => x.loadWeight)
                .ColumnPrefix("load");
        }
    }
}