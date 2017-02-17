using ObjectModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer
{
    interface IObjectService
    {
        void Add(object vehicleToAdd);
        void Edit();
        void Delete();
        void Print();
    }
}
