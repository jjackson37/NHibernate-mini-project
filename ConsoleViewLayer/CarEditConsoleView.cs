using ObjectModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleViewLayer
{
    internal class CarEditConsoleView : CarConsoleView
    {
        private Car originalCar = new Car();
        private Car editedCar = new Car();

        public CarEditConsoleView(Car carToEdit)
        {
            editedCar = carToEdit.Clone();
            originalCar = carToEdit.Clone();
        }

        public Car Load()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Unedited:");
                PrintInfo(originalCar, false);
                Console.WriteLine("Edited:");
                PrintInfo(editedCar, false);
                Console.WriteLine("Select field to edit");
                Console.WriteLine("\t1. Vehicle name");
                Console.WriteLine("\t2. Number plate");
                Console.WriteLine("\t3. Car type");
                Console.WriteLine("\t4. Milage");
                Console.WriteLine("\t5. Weight");
                Console.WriteLine("\t6. Maximum fuel");
                Console.WriteLine("\t7. Maximum passengers");
                Console.WriteLine("\t8. Current passengers");
                Console.WriteLine("\t9. Save changes");
                Console.WriteLine("\t0. Discard changes and go back");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        editName();
                        break;
                    case '2':
                        editNumberPlate();
                        break;
                    case '3':
                        editCarType();
                        break;
                    case '4':
                        editMilage();
                        break;
                    case '5':
                        editWeight();
                        break;
                    case '6':
                        editMaximumFuel();
                        break;
                    case '7':
                        editMaximumPassengers();
                        break;
                    case '8':
                        editCurrentPassengers();
                        break;
                    case '9':
                        exit = true;
                        break;
                    case '0':
                        Console.WriteLine("Discard changes? Y/N");
                        if (Console.ReadKey(true).KeyChar == 'y')
                        {
                            editedCar = originalCar;
                            exit = true;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            return editedCar;
        }

        private void editName()
        {
            Console.Write("Name: ");
            editedCar.vehicleName = Console.ReadLine();
        }

        private void editNumberPlate()
        {
            Console.Write("Number plate: ");
            editedCar.numberPlate = Console.ReadLine();
        }

        private void editCarType()
        {
            Console.WriteLine("1. Hatchback");
            Console.WriteLine("2. Sedan");
            Console.WriteLine("3. SUV");
            Console.WriteLine("4. Coupe");
            Console.WriteLine("5. Convertible");
            Console.Write("Car type: ");
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    editedCar.carType = Car.CarType.Hatchback;
                    Console.WriteLine("Hatchback");
                    break;
                case '2':
                    editedCar.carType = Car.CarType.Sedan;
                    Console.WriteLine("Sedan");
                    break;
                case '3':
                    editedCar.carType = Car.CarType.SUV;
                    Console.WriteLine("SUV");
                    break;
                case '4':
                    editedCar.carType = Car.CarType.Coupe;
                    Console.WriteLine("Coupe");
                    break;
                case '5':
                    editedCar.carType = Car.CarType.Convertible;
                    Console.WriteLine("Convertible");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }

        private void editMilage()
        {
            Console.Write("Milage(mpg): ");
            editedCar.milage = Convert.ToDecimal(Console.ReadLine());
        }

        private void editWeight()
        {
            Console.Write("Weight(kg): ");
            editedCar.weight = Convert.ToDecimal(Console.ReadLine());
        }

        private void editMaximumFuel()
        {
            Console.Write("Maximum fuel(l): ");
            editedCar.maximumFuel = Convert.ToDecimal(Console.ReadLine());
        }

        private void editMaximumPassengers()
        {
            Console.Write("Maximum passengers: ");
            editedCar.maximumPassengers = Convert.ToInt32(Console.ReadLine());
        }

        private void editCurrentPassengers()
        {
            Console.Write("Current passengers: ");
            editedCar.currentPassengers = Convert.ToInt32(Console.ReadLine());
        }
    }
}
