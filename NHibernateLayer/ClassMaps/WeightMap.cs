using FluentNHibernate.Mapping;
using HelperClasses.Measurements;

namespace NHibernateLayer.ClassMaps
{
    internal class WeightMap : ComponentMap<Weight>
    {
        private WeightMap()
        {
            Map(x => x.kilograms)
                .Column("weight");
        }
    }
}