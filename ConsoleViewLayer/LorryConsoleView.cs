using HelperClasses.Measurements;
using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Collections.Generic;

namespace ConsoleViewLayer
{
    internal class LorryConsoleView : ISelectedConsoleView
    {
        private LorryServices lorryServicesObj = new LorryServices();

        public void Add()
        {
            Console.WriteLine("Add lorry");
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

            bool hasLoad = false, validLoadInput = false;
            Weight loadWeight = new Weight();
            while (!validLoadInput)
            {
                Console.Write("Has load (Y/N):");
                switch (Console.ReadKey().KeyChar)
                {
                    case 'y':
                        hasLoad = true;
                        validLoadInput = true;
                        Console.Write("Load weight (kg): ");
                        loadWeight.kilograms = Convert.ToDecimal(Console.ReadLine());
                        break;

                    case 'n':
                        hasLoad = false;
                        validLoadInput = true;
                        break;

                    default:
                        Console.WriteLine("\nInvalid input");
                        break;
                }
            }

            Console.Write("Maximum fuel (litres): ");
            Volume maximumFuel = new Volume();
            maximumFuel.litres = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Maximum passengers: ");
            int maximumPassengers = Convert.ToInt32(Console.ReadLine());

            Lorry addedLorry = lorryServicesObj.Add(vehicleName, numberPlate, milage, weight, hasLoad,
                loadWeight, maximumFuel, maximumPassengers);

            SelectById(addedLorry.Id);
        }

        public void List()
        {
            IList<Lorry> lorryList = lorryServicesObj.GetAll();
            foreach (Lorry selectedLorry in lorryList)
            {
                PrintInfo(selectedLorry, true);
            }
        }

        public void Load()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Lorry");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Display lorrys");
                Console.WriteLine("\t2. Search lorrys");
                Console.WriteLine("\t3. Add new lorry");
                Console.WriteLine("\t4. Select a lorry");
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
            IList<Lorry> results = lorryServicesObj.GetByName(Console.ReadLine());
            foreach (Lorry selectedLorry in results)
            {
                PrintInfo(selectedLorry, true);
            }
        }

        public void Select(Lorry selectedLorry)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nSelected Lorry:");
                PrintInfo(selectedLorry, false);
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
                        LorryEditConsoleView lorryEditConsoleView = new LorryEditConsoleView(selectedLorry);
                        selectedLorry = lorryServicesObj.Update(lorryEditConsoleView.Load());
                        break;

                    case '2':
                        Console.Write("Type vehicle name to confirm:");
                        if (Console.ReadLine() == selectedLorry.vehicleName)
                        {
                            lorryServicesObj.Delete(selectedLorry);
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
                        selectedLorry = lorryServicesObj.CalculateFuel(selectedLorry, distance);
                        break;

                    case '4':
                        selectedLorry = lorryServicesObj.Refuel(selectedLorry);
                        break;

                    case '5':
                        LorryPassengerConsoleView lorryPassengers = new LorryPassengerConsoleView(selectedLorry);
                        lorryPassengers.Load();
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
                Guid lorryId = Guid.Parse(Console.ReadLine());
                Select(lorryServicesObj.GetById(lorryId));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No lorrys matching this Id in database\n");
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
                Select(lorryServicesObj.GetById(Id));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No lorrys matching this Id in database\n");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message + "\n");
            }
        }

        protected void PrintInfo(Lorry selectedLorry, bool showId)
        {
            Console.WriteLine();
            if (showId)
            {
                Console.WriteLine("Id: " + selectedLorry.Id);
            }
            Console.WriteLine(@"Name: ""{0}"" Numberplate: {1}"
                                + "\nMilage: {2}mpg Weight: {3}kg\n"
                                + "Current fuel: {4}/{5}l\n"
                                + "Current passengers: {6}/{7}"
                                , selectedLorry.vehicleName, selectedLorry.numberPlate
                                , decimal.Round(selectedLorry.milage.milesPerGallon, 2), decimal.Round(selectedLorry.weight.kilograms, 2)
                                , decimal.Round(selectedLorry.currentFuel.litres, 2), decimal.Round(selectedLorry.maximumFuel.litres, 2)
                                , selectedLorry.passengers.Count, selectedLorry.maximumPassengers);
            Console.Write("Has load: {0}", selectedLorry.hasLoad);
            if (selectedLorry.hasLoad)
            {
                Console.Write(" Load weight: {0}", decimal.Round(selectedLorry.loadWeight.kilograms, 2));
            }
            Console.WriteLine("\n");
        }
    }
}