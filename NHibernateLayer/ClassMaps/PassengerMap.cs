using FluentNHibernate.Mapping;
using ObjectModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
