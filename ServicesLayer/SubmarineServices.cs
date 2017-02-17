using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectModelLayer;

namespace ServicesLayer
{
    class SubmarineServices : IObjectService
    {
        public bool Add(Guid Id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Guid Id)
        {
            throw new NotImplementedException();
        }

        public object FindById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<object> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool ToggleLoad(Guid Id, decimal weight)
        {
            throw new NotImplementedException();
        }

        public bool ToggleSubmerge(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
