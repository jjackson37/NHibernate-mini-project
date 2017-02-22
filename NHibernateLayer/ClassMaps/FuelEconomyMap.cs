using FluentNHibernate.Mapping;
using HelperClasses.Measurements;

namespace NHibernateLayer.ClassMaps
{
    internal class FuelEconomyMap : ComponentMap<FuelEconomy>
    {
        public FuelEconomyMap()
        {
            Map(x => x.milesPerGallon)
                .Column("milage");
        }
    }
}