using FluentNHibernate.Mapping;
using ObjectModelLayer;

namespace NHibernateLayer.ClassMaps
{
    public class PassengerMap : ClassMap<Passenger>
    {
        public PassengerMap()
        {
            Id(x => x.Id)
                .GeneratedBy.GuidComb();

            Map(x => x.firstName)
                .Not.Nullable();

            Map(x => x.lastName)
                .Not.Nullable();
        }
    }
}