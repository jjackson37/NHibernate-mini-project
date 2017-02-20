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
    class CarConsoleView
    {
        CarServices carServicesObj = new CarServices();

        public void SelectCarView(Car selectedCar)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nSelected Car:\n");
                PrintCarInfo(selectedCar, false);
                Console.WriteLine("Choose an option:");
                Console.WriteLine("\t1. Edit");
                Console.WriteLine("\t2. Delete");
                Console.WriteLine("\t3. Calculate fuel");
                Console.WriteLine("\t4. Refuel");
                Console.WriteLine("\t5. Back");
                Console.ReadKey();
            }
        }

        private void PrintCarInfo(Car selectedCar, bool showId)
        {
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

        public void ListCarView()
        {
            IList<Car> carList = carServicesObj.GetAll();
            foreach (Car selectedCar in carList)
            {
                PrintCarInfo(selectedCar, true);
            }
        }

        public void AddCarView()
        {
            Console.WriteLine("Add car");
            Console.Write("Name: ");
            string name = Console.ReadLine();
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
        }
    }
}
