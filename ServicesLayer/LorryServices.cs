﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectModelLayer;

namespace ServicesLayer
{
    class LorryServices : IObjectService
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

        public bool Refuel(Guid Id)
        {
            throw new NotImplementedException();
        }

        public bool SimulateFuel(Guid Id, decimal distance)
        {
            throw new NotImplementedException();
        }

        public bool ToggleLoad(Guid Id, decimal weight)
        {
            throw new NotImplementedException();
        }
    }
}
