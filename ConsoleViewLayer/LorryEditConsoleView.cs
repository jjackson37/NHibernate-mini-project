using ObjectModelLayer;
using System;

namespace ConsoleViewLayer
{
    internal class LorryEditConsoleView : LorryConsoleView
    {
        private Lorry editedLorry = new Lorry();
        private Lorry originalLorry = new Lorry();

        public LorryEditConsoleView(Lorry lorryToEdit)
        {
            editedLorry = lorryToEdit.Clone();
            originalLorry = lorryToEdit.Clone();
        }

        public new Lorry Load()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Unedited:");
                PrintInfo(originalLorry, false);

                Console.WriteLine("Edited:");
                PrintInfo(editedLorry, false);

                Console.WriteLine("Select field to edit");
                Console.WriteLine("\t1. Vehicle name");
                Console.WriteLine("\t2. Number plate");
                Console.WriteLine("\t3. Load");
                Console.WriteLine("\t4. Milage");
                Console.WriteLine("\t5. Weight");
                Console.WriteLine("\t6. Maximum fuel");
                Console.WriteLine("\t7. Maximum passengers");
                Console.WriteLine("\t8. Save changes");
                Console.WriteLine("\t9. Discard changes and go back");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        editName();
                        break;

                    case '2':
                        editNumberPlate();
                        break;

                    case '3':
                        editLoad();
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
                        exit = true;
                        break;

                    case '9':
                        Console.WriteLine("Discard changes? Y/N");
                        if (Console.ReadKey(true).KeyChar == 'y')
                        {
                            editedLorry = originalLorry;
                            exit = true;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            return editedLorry;
        }

        private void editLoad()
        {
            bool validLoadInput = false;
            while (!validLoadInput)
            {
                Console.Write("Has load (Y/N):");
                switch (Console.ReadKey().KeyChar)
                {
                    case 'y':
                        editedLorry.hasLoad = true;
                        validLoadInput = true;
                        Console.Write("Load weight (kg): ");
                        editedLorry.loadWeight.kilograms = Convert.ToDecimal(Console.ReadLine());
                        break;

                    case 'n':
                        editedLorry.hasLoad = false;
                        editedLorry.loadWeight = null;
                        validLoadInput = true;
                        break;

                    default:
                        Console.WriteLine("\nInvalid input");
                        break;
                }
            }
        }

        private void editMaximumFuel()
        {
            Console.Write("Maximum fuel(l): ");
            editedLorry.maximumFuel.litres = Convert.ToDecimal(Console.ReadLine());
            editedLorry.currentFuel = editedLorry.maximumFuel;
        }

        private void editMaximumPassengers()
        {
            Console.Write("Maximum passengers: ");
            int newMaximumPassengers = Convert.ToInt32(Console.ReadLine());
            if (editedLorry.passengers.Count <= newMaximumPassengers)
            {
                editedLorry.maximumPassengers = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Too many passengers are currently in this vehicle");
            }
        }

        private void editMilage()
        {
            Console.Write("Milage(mpg): ");
            editedLorry.milage.milesPerGallon = Convert.ToDecimal(Console.ReadLine());
        }

        private void editName()
        {
            Console.Write("Name: ");
            editedLorry.vehicleName = Console.ReadLine();
        }

        private void editNumberPlate()
        {
            Console.Write("Number plate: ");
            editedLorry.numberPlate = Console.ReadLine();
        }

        private void editWeight()
        {
            Console.Write("Weight(kg): ");
            editedLorry.weight.kilograms = Convert.ToDecimal(Console.ReadLine());
        }
    }
}