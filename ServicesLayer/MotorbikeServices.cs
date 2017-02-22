using HelperClasses.Measurements;
using NHibernate.Linq;
using NHibernateLayer;
using ObjectModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicesLayer
{
    public class MotorbikeServices
    {
        public Motorbike Add(string vehicleName, string numberPlate, FuelEconomy milage,
            Weight weight, Volume maximumFuel, int maximumPassengers, int currentPassengers, bool sideCar)
        {
            Motorbike motorbikeToAdd = new Motorbike(vehicleName, numberPlate, milage, weight, maximumFuel
                , currentPassengers, maximumPassengers, sideCar);
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Save(motorbikeToAdd);
                    tx.Commit();
                }
            }
            return motorbikeToAdd;
        }

        public Motorbike CalculateFuel(Motorbike motorbikeToCalculate, Distance distance)
        {
            motorbikeToCalculate.currentFuel.gallons -= (distance.miles / motorbikeToCalculate.milage.milesPerGallon);
            if (motorbikeToCalculate.currentFuel.litres < 0)
            {
                motorbikeToCalculate.currentFuel.litres = 0;
            }
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Update(motorbikeToCalculate);
                    tx.Commit();
                }
            }
            return motorbikeToCalculate;
        }

        public void Delete(Motorbike motorbikeToDelete)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Delete(motorbikeToDelete);
                    tx.Commit();
                }
            }
        }

        public IList<Motorbike> GetAll()
        {
            IList<Motorbike> listToReturn = null;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    listToReturn = session.CreateCriteria<Motorbike>().List<Motorbike>();
                    tx.Commit();
                }
            }
            return listToReturn;
        }

        public Motorbike GetById(Guid Id)
        {
            Motorbike motorbikeToReturn = null;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    motorbikeToReturn = session.Get<Motorbike>(Id);
                    tx.Commit();
                }
            }
            return motorbikeToReturn;
        }

        public IList<Motorbike> GetByName(string name)
        {
            IList<Motorbike> listToReturn = null;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    listToReturn = session.Query<Motorbike>()
                        .Where(c => c.vehicleName == name).ToList();
                    tx.Commit();
                }
            }
            return listToReturn;
        }

        public Motorbike Refuel(Motorbike motorbikeToRefuel)
        {
            motorbikeToRefuel.currentFuel = motorbikeToRefuel.maximumFuel;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Update(motorbikeToRefuel);
                    tx.Commit();
                }
            }
            return motorbikeToRefuel;
        }

        public Motorbike Update(Motorbike motorbikeToUpdate)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Update(motorbikeToUpdate);
                    tx.Commit();
                }
            }
            return motorbikeToUpdate;
        }
    }
}