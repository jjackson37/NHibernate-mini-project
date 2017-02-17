using ObjectModelLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer
{
    interface IObjectService
    {
        bool Add(Guid Id);
        bool Edit(Guid Id);
        bool Delete(Guid Id);
        List<object> GetAll();
        object FindById(Guid Id);
        List<object> FindByName(string name);
    }
}
