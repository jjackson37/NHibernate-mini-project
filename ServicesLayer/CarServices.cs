using NHibernateLayer;
using ObjectModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer
{
    public class CarServices
    {
        public bool Add(Car CarToAdd)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetAll()
        {
            IList<Car> listToReturn = null;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    listToReturn = session.CreateCriteria<Car>().List<Car>();
                    tx.Commit();
                }
            }
            return listToReturn;
        }

        public Car GetById(Guid Id)
        {
            Car carToReturn = null;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    carToReturn = session.Get<Car>(Id);
                    tx.Commit();
                }
            }
            return carToReturn;
        }

        public bool Update(Car CarToUpdate)
        {
            throw new NotImplementedException();
        }

        public Car CalculateFuel(Car CarToCalculate, decimal distance)
        {
            throw new NotImplementedException();
        }

        public bool Refuel(Car CarToRefuel)
        {
            throw new NotImplementedException();
        }
    }
}
