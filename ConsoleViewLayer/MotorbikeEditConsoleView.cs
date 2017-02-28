using ObjectModelLayer;
using System;

namespace ConsoleViewLayer
{
    internal class MotorbikeEditConsoleView : MotorbikeConsoleView
    {
        private Motorbike editedMotorbike = new Motorbike();
        private Motorbike originalMotorbike = new Motorbike();

        public MotorbikeEditConsoleView(Motorbike motorbikeToEdit)
        {
            editedMotorbike = motorbikeToEdit.Clone();
            originalMotorbike = motorbikeToEdit.Clone();
        }

        public new Motorbike Load()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Unedited:");
                PrintInfo(originalMotorbike, false);

                Console.WriteLine("Edited:");
                PrintInfo(editedMotorbike, false);

                Console.WriteLine("Select field to edit");
                Console.WriteLine("\t1. Vehicle name");
                Console.WriteLine("\t2. Number plate");
                Console.WriteLine("\t3. Sidecar");
                Console.WriteLine("\t4. Milage");
                Console.WriteLine("\t5. Weight");
                Console.WriteLine("\t6. Maximum fuel");
                Console.WriteLine("\t7. Maximum passengers");
                Console.WriteLine("\t8. Save changes");
                Console.WriteLine("\t9. Dismotorbiked changes and go back");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        editName();
                        break;

                    case '2':
                        editNumberPlate();
                        break;

                    case '3':
                        editSidecar();
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
                        Console.WriteLine("Dismotorbiked changes? Y/N");
                        if (Console.ReadKey(true).KeyChar == 'y')
                        {
                            editedMotorbike = originalMotorbike;
                            exit = true;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            return editedMotorbike;
        }

        private void editSidecar()
        {
            bool sideCarValidInput = false;
            while (!sideCarValidInput)
            {
                Console.Write("Sidecar (Y/N):");
                switch (Console.ReadKey().KeyChar)
                {
                    case 'y':
                        editedMotorbike.sideCar = true;
                        sideCarValidInput = true;
                        break;

                    case 'n':
                        editedMotorbike.sideCar = true;
                        sideCarValidInput = true;
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
            editedMotorbike.maximumFuel.litres = Convert.ToDecimal(Console.ReadLine());
        }

        private void editMaximumPassengers()
        {
            Console.Write("Maximum passengers: ");
            editedMotorbike.maximumPassengers = Convert.ToInt32(Console.ReadLine());
        }

        private void editMilage()
        {
            Console.Write("Milage(mpg): ");
            editedMotorbike.milage.milesPerGallon = Convert.ToDecimal(Console.ReadLine());
        }

        private void editName()
        {
            Console.Write("Name: ");
            editedMotorbike.vehicleName = Console.ReadLine();
        }

        private void editNumberPlate()
        {
            Console.Write("Number plate: ");
            editedMotorbike.numberPlate = Console.ReadLine();
        }

        private void editWeight()
        {
            Console.Write("Weight(kg): ");
            editedMotorbike.weight.kilograms = Convert.ToDecimal(Console.ReadLine());
        }
    }
}