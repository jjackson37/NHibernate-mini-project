using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleViewLayer.LandVehicleViews
{
    internal class LorryConsoleView : ISelectedConsoleView
    {
        LorryServices lorryServiceObj = new LorryServices();

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
            decimal milage = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Weight (kg): ");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Has load (Y/N):");
            bool hasLoad = false, validLoadInput = false;
            while (!validLoadInput)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case 'y':
                        hasLoad = true;
                        validLoadInput = true;
                        break;
                    case 'n':
                        hasLoad = false;
                        validLoadInput = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            decimal? loadWeight = null;
            if (hasLoad)
            {
                Console.Write("Load weight (kg): ");
                loadWeight = Convert.ToDecimal(Console.ReadLine());
            }
            Console.Write("Maximum fuel (litres): ");
            decimal maximumFuel = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Maximum passengers: ");
            int maximumPassengers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Current passengers: ");
            int currentPassengers = Convert.ToInt32(Console.ReadLine());
        }

        public void Select(Lorry selectedLorry)
        {

        }

        protected void PrintInfo(Lorry selectedLorry, bool showId)
        {

        }

        public void List()
        {
            throw new NotImplementedException();
        }

        public void SearchByName()
        {
            throw new NotImplementedException();
        }

        public void SelectById()
        {
            throw new NotImplementedException();
        }

        public void SelectById(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
