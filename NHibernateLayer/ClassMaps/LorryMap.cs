using FluentNHibernate.Mapping;
using ObjectModelLayer;

namespace NHibernateLayer.ClassMaps
{
    internal class LorryMap : ClassMap<Lorry>
    {
        public LorryMap()
        {
            Id(x => x.Id).GeneratedBy.GuidComb();
            Map(x => x.vehicleName).Not.Nullable();
            Map(x => x.numberPlate).Not.Nullable();
            Component(x => x.milage, m =>
            {
                m.Map(x => x.milesPerGallon).Column("milage").Not.Nullable();
            });
            Component(x => x.weight, m =>
            {
                m.Map(x => x.kilograms).Column("Weight").Not.Nullable();
            });
            Map(x => x.hasLoad).Not.Nullable();
            Component(x => x.loadWeight, m =>
            {
                m.Map(x => x.kilograms).Column("loadWeight").Nullable();
            });
            Component(x => x.currentFuel, m =>
            {
                m.Map(x => x.litres).Column("currentFuel").Not.Nullable();
            });
            Component(x => x.maximumFuel, m =>
            {
                m.Map(x => x.litres).Column("maximumFuel").Not.Nullable();
            });
            Map(x => x.currentPassengers).Not.Nullable();
            Map(x => x.maximumPassengers).Not.Nullable();
        }
    }
}