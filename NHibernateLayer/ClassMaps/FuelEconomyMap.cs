using FluentNHibernate.Mapping;
using HelperClasses.Measurements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLayer.ClassMaps
{
    class FuelEconomyMap : ComponentMap<FuelEconomy>
    {
        public FuelEconomyMap()
        {
            Map(x => x.milesPerGallon).Column("milage");
        }
    }
}
