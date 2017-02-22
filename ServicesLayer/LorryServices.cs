using HelperClasses.Measurements;
using NHibernate.Linq;
using NHibernateLayer;
using ObjectModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicesLayer
{
    public class LorryServices
    {
        public Lorry Add(string vehicleName, string numberPlate, FuelEconomy milage, Weight weight, bool hasLoad,
            Weight loadWeight, Volume maximumFuel, int currentPassengers, int maximumPassengers)
        {
            Lorry lorryToAdd = new Lorry(vehicleName, numberPlate, milage, weight, hasLoad, loadWeight,
                maximumFuel, currentPassengers, maximumPassengers);
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Save(lorryToAdd);
                    tx.Commit();
                }
            }
            return lorryToAdd;
        }
            
        public void Delete(Lorry lorryToDelete)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Delete(lorryToDelete);
                    tx.Commit();
                }
            }
        }

        public Lorry Update(Lorry lorryToUpdate)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Update(lorryToUpdate);
                    tx.Commit();
                }
            }
            return lorryToUpdate;
        }

        public Lorry GetById(Guid Id)
        {
            Lorry lorryToReturn = null;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    lorryToReturn = session.Get<Lorry>(Id);
                    tx.Commit();
                }
            }
            return lorryToReturn;
        }

        public IList<Lorry> GetByName(string name)
        {
            IList<Lorry> listToReturn = null;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    listToReturn = session.Query<Lorry>()
                        .Where(c => c.vehicleName == name).ToList();
                    tx.Commit();
                }
            }
            return listToReturn;
        }

        public IList<Lorry> GetAll()
        {
            IList<Lorry> listToReturn = null;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    listToReturn = session.CreateCriteria<Lorry>().List<Lorry>();
                    tx.Commit();
                }
            }
            return listToReturn;
        }

        public Lorry Refuel(Lorry lorryToRefuel)
        {
            lorryToRefuel.currentFuel = lorryToRefuel.maximumFuel;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Update(lorryToRefuel);
                    tx.Commit();
                }
            }
            return lorryToRefuel;
        }

        public Lorry CalculateFuel(Lorry lorryToCalculate, Distance distance)
        {
            lorryToCalculate.currentFuel.gallons -= (distance.miles * lorryToCalculate.milage.milesPerGallon);
            if (lorryToCalculate.currentFuel.litres < 0)
            {
                lorryToCalculate.currentFuel.litres = 0;
            }
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Update(lorryToCalculate);
                    tx.Commit();
                }
            }
            return lorryToCalculate;
        }
    }
}