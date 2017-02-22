using FluentNHibernate.Mapping;
using HelperClasses.Measurements;

namespace NHibernateLayer.ClassMaps
{
    internal class VolumeMap : ComponentMap<Volume>
    {
        public VolumeMap()
        {
            Map(x => x.litres).Column("Fuel");
        }
    }
}