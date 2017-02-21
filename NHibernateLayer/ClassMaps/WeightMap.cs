using FluentNHibernate.Mapping;
using HelperClasses.Measurements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLayer.ClassMaps
{
    class WeightMap : ComponentMap<Weight>
    {
        WeightMap()
        {
            Map(x => x.kilograms).Column("weight");
        }
    }
}
