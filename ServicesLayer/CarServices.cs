using NHibernate.Linq;
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
        public Car Add(string vehicleName, string numberPlate, Car.CarType carType, decimal milage,
            decimal weight, decimal maximumFuel, int maximumPassengers, int currentPassengers)
        {
            Car carToAdd = new Car(vehicleName,numberPlate,carType,milage,weight,maximumFuel
                ,currentPassengers,maximumPassengers);
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Save(carToAdd);
                    tx.Commit();
                }
            }
            return carToAdd;
        }

        public void Delete(Car CarToDelete)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Delete(CarToDelete);
                    tx.Commit();
                }
            }
        }

        public IList<Car> GetByName(string name)
        {
            IList<Car> listToReturn = null;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    listToReturn = session.Query<Car>()
                        .Where(c => c.vehicleName == name).ToList();
                    tx.Commit();
                }
            }
            return listToReturn;
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

        public Car Update(Car CarToUpdate)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Update(CarToUpdate);
                    tx.Commit();
                }
            }
            return CarToUpdate;
        }

        public Car CalculateFuel(Car CarToCalculate, decimal distance)
        {
            CarToCalculate.currentFuel -= (distance * CarToCalculate.milage);
            if (CarToCalculate.currentFuel < 0)
            {
                CarToCalculate.currentFuel = 0;
            }
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Update(CarToCalculate);
                    tx.Commit();
                }
            }
            return CarToCalculate;
        }

        public Car Refuel(Car CarToRefuel)
        {
            CarToRefuel.currentFuel = CarToRefuel.maximumFuel;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Update(CarToRefuel);
                    tx.Commit();
                }
            }
            return CarToRefuel;
        }
    }
}
