using HelperClasses.Measurements;
using NHibernate.Linq;
using NHibernateLayer;
using ObjectModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicesLayer
{
    public class CarServices
    {
        public Car Add(string vehicleName, string numberPlate, Car.CarType carType, FuelEconomy milage,
            Weight weight, Volume maximumFuel, int maximumPassengers, int currentPassengers)
        {
            Car carToAdd = new Car(vehicleName, numberPlate, carType, milage, weight, maximumFuel
                , currentPassengers, maximumPassengers);
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

        public Car CalculateFuel(Car carToCalculate, Distance distance)
        {
            carToCalculate.currentFuel.gallons -= (distance.miles / carToCalculate.milage.milesPerGallon);
            if (carToCalculate.currentFuel.litres < 0)
            {
                carToCalculate.currentFuel.litres = 0;
            }
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Update(carToCalculate);
                    tx.Commit();
                }
            }
            return carToCalculate;
        }

        public void Delete(Car carToDelete)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Delete(carToDelete);
                    tx.Commit();
                }
            }
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

        public Car Refuel(Car carToRefuel)
        {
            carToRefuel.currentFuel = carToRefuel.maximumFuel;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Update(carToRefuel);
                    tx.Commit();
                }
            }
            return carToRefuel;
        }

        public Car Update(Car carToUpdate)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Update(carToUpdate);
                    tx.Commit();
                }
            }
            return carToUpdate;
        }
    }
}