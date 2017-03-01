using HelperClasses.Measurements;
using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Collections.Generic;

namespace ConsoleViewLayer
{
    internal class MotorbikeConsoleView : ISelectedConsoleView
    {
        private MotorbikeServices motorbikeServicesObj = new MotorbikeServices();

        public void Add()
        {
            Console.WriteLine("Add motorbike");
            Console.Write("Name: ");
            string vehicleName = Console.ReadLine();

            string numberPlateEntry, numberPlate = null;
            while (numberPlate == null)
            {
                Console.Write("Number plate: ");
                numberPlateEntry = Console.ReadLine().Replace(" ", "");
                if (numberPlateEntry.Length != 7)
                {
                    Console.WriteLine("Invalid numberplate length");
                }
                else
                {
                    numberPlate = numberPlateEntry;
                }
            }

            Console.Write("Milage (Miles/Gallon): ");
            FuelEconomy milage = new FuelEconomy();
            milage.milesPerGallon = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Weight (kg): ");
            Weight weight = new Weight();
            weight.kilograms = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Maximum fuel (litres): ");
            Volume maximumFuel = new Volume();
            maximumFuel.litres = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Maximum passengers: ");
            int maximumPassengers = Convert.ToInt32(Console.ReadLine());

            bool sideCar = false, sideCarValidInput = false;
            while (!sideCarValidInput)
            {
                Console.Write("Sidecar (Y/N):");
                switch (Console.ReadKey().KeyChar)
                {
                    case 'y':
                        sideCar = true;
                        sideCarValidInput = true;
                        break;

                    case 'n':
                        sideCar = true;
                        sideCarValidInput = true;
                        break;

                    default:
                        Console.WriteLine("\nInvalid input");
                        break;
                }
            }

            Motorbike addedMotorbike = motorbikeServicesObj.Add(vehicleName, numberPlate, milage, weight, maximumFuel,
                maximumPassengers, sideCar);

            SelectById(addedMotorbike.Id);
        }

        public void List()
        {
            IList<Motorbike> motorbikeList = motorbikeServicesObj.GetAll();
            foreach (Motorbike selectedMotorbike in motorbikeList)
            {
                PrintInfo(selectedMotorbike, true);
            }
        }

        public void Load()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Motorbike");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Display motorbikes");
                Console.WriteLine("\t2. Search motorbikes");
                Console.WriteLine("\t3. Add new motorbike");
                Console.WriteLine("\t4. Select a motorbike");
                Console.WriteLine("\t5. Back\n");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        List();
                        break;

                    case '2':
                        SearchByName();
                        break;

                    case '3':
                        Add();
                        break;

                    case '4':
                        SelectById();
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

        public void SearchByName()
        {
            Console.Write("Name: ");
            IList<Motorbike> results = motorbikeServicesObj.GetByName(Console.ReadLine());
            foreach (Motorbike selectedMotorbike in results)
            {
                PrintInfo(selectedMotorbike, true);
            }
        }

        public void Select(Motorbike selectedMotorbike)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nSelected Motorbike:");
                PrintInfo(selectedMotorbike, false);
                Console.WriteLine("Choose an option:");
                Console.WriteLine("\t1. Edit");
                Console.WriteLine("\t2. Delete");
                Console.WriteLine("\t3. Calculate fuel");
                Console.WriteLine("\t4. Refuel");
                Console.WriteLine("\t5. Passengers");
                Console.WriteLine("\t6. Back");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        MotorbikeEditConsoleView motorbikeEditConsoleView = new MotorbikeEditConsoleView(selectedMotorbike);
                        selectedMotorbike = motorbikeServicesObj.Update(motorbikeEditConsoleView.Load());
                        break;

                    case '2':
                        Console.Write("Type vehicle name to confirm:");
                        if (Console.ReadLine() == selectedMotorbike.vehicleName)
                        {
                            motorbikeServicesObj.Delete(selectedMotorbike);
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Cancelled");
                        }
                        break;

                    case '3':
                        Console.Write("Enter distance in miles: ");
                        Distance distance = new Distance();
                        distance.miles = Convert.ToDecimal(Console.ReadLine());
                        selectedMotorbike = motorbikeServicesObj.CalculateFuel(selectedMotorbike, distance);
                        break;

                    case '4':
                        selectedMotorbike = motorbikeServicesObj.Refuel(selectedMotorbike);
                        break;

                    case '5':
                        MotorbikePassengerConsoleView motorbikePassengers = new MotorbikePassengerConsoleView(selectedMotorbike);
                        motorbikePassengers.Load();
                        break;

                    case '6':
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }

        public void SelectById()
        {
            Console.Write("Id: ");
            try
            {
                Guid motorbikeId = Guid.Parse(Console.ReadLine());
                Select(motorbikeServicesObj.GetById(motorbikeId));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No motorbikes matching this Id in database\n");
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
                Select(motorbikeServicesObj.GetById(Id));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No motorbikes matching this Id in database\n");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message + "\n");
            }
        }

        protected void PrintInfo(Motorbike selectedMotorbike, bool showId)
        {
            Console.WriteLine();
            if (showId)
            {
                Console.WriteLine("Id: " + selectedMotorbike.Id);
            }
            Console.WriteLine(@"Name: ""{0}"" Numberplate: {1}"
                                + "\nMilage: {2}mpg Weight: {3}kg\n"
                                + "Current fuel: {4}/{5}l\n"
                                + "Current passengers: {6}/{7}\n"
                                + "Sidecar: {8}\n"
                                , selectedMotorbike.vehicleName, selectedMotorbike.numberPlate
                                , decimal.Round(selectedMotorbike.milage.milesPerGallon, 2), decimal.Round(selectedMotorbike.weight.kilograms, 2)
                                , decimal.Round(selectedMotorbike.currentFuel.litres, 2), decimal.Round(selectedMotorbike.maximumFuel.litres, 2)
                                , selectedMotorbike.passengers.Count, selectedMotorbike.maximumPassengers, selectedMotorbike.sideCar);
        }
    }
}