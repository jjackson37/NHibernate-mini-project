using System;

namespace ConsoleViewLayer
{
    internal class AirConsoleView : IConsoleView
    {
        public void Load()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Air Vehicles");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Plane");
                Console.WriteLine("\t2. Balloon");
                Console.WriteLine("\t3. Back\n");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        PlaneView();
                        break;

                    case '2':
                        BalloonView();
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

        private void PlaneView()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Plane");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Display planes");
                Console.WriteLine("\t2. Add new plane");
                Console.WriteLine("\t3. Edit a plane");
                Console.WriteLine("\t4. Delete a plane");
                Console.WriteLine("\t5. Raise/lower altitude");
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

        private void BalloonView()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Balloon");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Display balloons");
                Console.WriteLine("\t2. Add new balloon");
                Console.WriteLine("\t3. Edit a balloon");
                Console.WriteLine("\t4. Delete a balloon");
                Console.WriteLine("\t5. Drop sandbags");
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
    }
}