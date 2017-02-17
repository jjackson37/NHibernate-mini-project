using System;

namespace ConsoleViewLayer
{
    internal class AquaticConsoleView : IConsoleView
    {
        public void Load()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Aquatic Vehicles");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Boat");
                Console.WriteLine("\t2. Submarine");
                Console.WriteLine("\t3. Back\n");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        BoatView();
                        break;

                    case '2':
                        SubmarineView();
                        break;

                    case '3':
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input\n");
                        break;
                }
            }
        }

        private void BoatView()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Boat");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Display boats");
                Console.WriteLine("\t2. Add new boat");
                Console.WriteLine("\t3. Edit a boat");
                Console.WriteLine("\t4. Delete a boat");
                Console.WriteLine("\t5. Load/deload load");
                Console.WriteLine("\t6. Back\n");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        break;

                    case '2':
                        break;

                    case '3':
                        break;

                    case '4':
                        break;

                    case '5':
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

        private void SubmarineView()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Submarine");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Display submarines");
                Console.WriteLine("\t2. Add new submarine");
                Console.WriteLine("\t3. Edit a submarine");
                Console.WriteLine("\t4. Delete a submarine");
                Console.WriteLine("\t5. Load/deload load");
                Console.WriteLine("\t6. Toggle submerge");
                Console.WriteLine("\t7. Simulate oxygen level after distance");
                Console.WriteLine("\t8. Back\n");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        break;

                    case '2':
                        break;

                    case '3':
                        break;

                    case '4':
                        break;

                    case '5':
                        break;

                    case '6':
                        break;

                    case '7':
                        break;

                    case '8':
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}