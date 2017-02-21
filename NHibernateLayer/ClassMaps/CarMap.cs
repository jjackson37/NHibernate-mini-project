using FluentNHibernate.Mapping;
using ObjectModelLayer;
using System;

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
            Component(x => x.milage, m => 
            {
                m.Map(x => x.milesPerGallon).Column("milage").Not.Nullable();
            });
            Component(x => x.weight, m =>
            {
                m.Map(x => x.kilograms).Column("weight").Not.Nullable();
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