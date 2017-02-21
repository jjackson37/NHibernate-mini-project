using FluentNHibernate.Mapping;
using HelperClasses.Measurements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLayer.ClassMaps
{
    class VolumeMap : ComponentMap<Volume>
    {
        public VolumeMap()
        {
            Map(x => x.litres).Column("Fuel");
        }
    }
}
