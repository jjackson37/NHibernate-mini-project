using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleViewLayer
{
    internal class CarConsoleView : ISelectedConsoleView
    {
        CarServices carServicesObj = new CarServices();

        public void Load()
        {

        }

        public void SelectById()
        {
            Console.Write("Id: ");
            try
            {
                Guid carId = Guid.Parse(Console.ReadLine());
                Select(carServicesObj.GetById(carId));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No cars matching this Id in database\n");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message + "\n");
            }
        }

        public void SelectById(Guid Id)
        {
            try
            {
                Select(carServicesObj.GetById(Id));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No cars matching this Id in database\n");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message + "\n");
            }
        }

        public void SearchByName()
        {
            Console.Write("Name: ");
            IList<Car> results = carServicesObj.GetByName(Console.ReadLine());
            foreach (Car selectedCar in results)
            {
                PrintInfo(selectedCar, true);
            }
        }

        public void Select(Car selectedCar)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nSelected Car:");
                PrintInfo(selectedCar, false);
                Console.WriteLine("Choose an option:");
                Console.WriteLine("\t1. Edit");
                Console.WriteLine("\t2. Delete");
                Console.WriteLine("\t3. Calculate fuel");
                Console.WriteLine("\t4. Refuel");
                Console.WriteLine("\t5. Back");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        CarEditConsoleView carEditConsoleView = new CarEditConsoleView(selectedCar);
                        selectedCar = carServicesObj.Update(carEditConsoleView.Load());
                        break;
                    case '2':
                        Console.Write("Type vehicle name to confirm:");
                        if (Console.ReadLine() == selectedCar.vehicleName)
                        {
                            carServicesObj.Delete(selectedCar);
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Cancelled");
                        }
                        break;
                    case '3':
                        Console.Write("Enter distance in miles: ");
                        selectedCar = carServicesObj.CalculateFuel(selectedCar,
                            Convert.ToInt32(Console.ReadLine()));
                        break;
                    case '4':
                        selectedCar = carServicesObj.Refuel(selectedCar);
                        break;
                    case '5':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }

        protected void PrintInfo(Car selectedCar, bool showId)
        {
            Console.WriteLine();
            if (showId)
            {
                Console.WriteLine("Id: " + selectedCar.Id);
            }
            Console.WriteLine("Name: {0} Numberplate: {1} Type: {2}\n"
                                + "Milage: {3}mpg Weight: {4}kg\n"
                                + "Current fuel: {5}l Maximum fuel: {6}l\n"
                                + "Current passengers: {7} Maximum passengers: {8}\n"
                                , selectedCar.vehicleName, selectedCar.numberPlate, selectedCar.carType
                                , decimal.Round(selectedCar.milage, 2), decimal.Round(selectedCar.weight, 2)
                                , decimal.Round(selectedCar.currentFuel, 2), decimal.Round(selectedCar.maximumFuel, 2)
                                , selectedCar.currentPassengers, selectedCar.maximumPassengers);
        }

        public void List()
        {
            IList<Car> carList = carServicesObj.GetAll();
            foreach (Car selectedCar in carList)
            {
                PrintInfo(selectedCar, true);
            }
        }

        public void Add()
        {
            Console.WriteLine("Add car");
            Console.Write("Name: ");
            string vehicleName = Console.ReadLine();
            string numberPlateEntry, numberPlate = null;
            while (numberPlate == null)
            {
                Console.Write("Number plate: ");
                numberPlateEntry = Console.ReadLine().Replace(" ", "");
                if(numberPlateEntry.Length != 7)
                {
                    Console.WriteLine("Invalid numberplate length");
                }
                else
                {
                    numberPlate = numberPlateEntry;
                }
            }
            Console.WriteLine("1. Hatchback");
            Console.WriteLine("2. Sedan");
            Console.WriteLine("3. SUV");
            Console.WriteLine("4. Coupe");
            Console.WriteLine("5. Convertible");
            Car.CarType carType = Car.CarType.Unknown;
            while (carType == Car.CarType.Unknown)
            {
                Console.Write("Car type: ");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        carType = Car.CarType.Hatchback;
                        Console.WriteLine("Hatchback");
                        break;
                    case '2':
                        carType = Car.CarType.Sedan;
                        Console.WriteLine("Sedan");
                        break;
                    case '3':
                        carType = Car.CarType.SUV;
                        Console.WriteLine("SUV");
                        break;
                    case '4':
                        carType = Car.CarType.Coupe;
                        Console.WriteLine("Coupe");
                        break;
                    case '5':
                        carType = Car.CarType.Convertible;
                        Console.WriteLine("Convertible");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            Console.Write("Milage (Miles/Gallon): ");
            decimal milage = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Weight (kg): ");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Maximum fuel (litres): ");
            decimal maximumFuel = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Maximum passengers: ");
            int maximumPassengers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Current passengers: ");
            int currentPassengers = Convert.ToInt32(Console.ReadLine());
            Car addedCar = carServicesObj.Add(vehicleName, numberPlate, carType, milage, weight, maximumFuel,
                maximumPassengers, currentPassengers);
            SelectById(addedCar.Id);
        }
    }
}
