using ObjectModelLayer;
using ServicesLayer;
using System;

namespace ConsoleViewLayer
{
    internal class LandConsoleView : IConsoleView
    {
        public void Load()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Land Vehicles");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Car");
                Console.WriteLine("\t2. Lorry");
                Console.WriteLine("\t3. Back\n");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        CarView();
                        break;

                    case '2':
                        LorryView();
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

        private void CarView()
        {
            bool exit = false;
            CarConsoleView carViewObj = new CarConsoleView();
            CarServices carServiceObj = new CarServices();

            while (!exit)
            {
                Console.WriteLine("Car");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Display cars");
                Console.WriteLine("\t2. Add new car");
                Console.WriteLine("\t3. Select a car");
                Console.WriteLine("\t4. Back\n");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        carViewObj.ListCarView();
                        break;

                    case '2':
                        carViewObj.AddCarView();
                        break;

                    case '3':
                        Console.Write("Id: ");
                        try
                        {
                            Guid carId = Guid.Parse(Console.ReadLine());
                            carViewObj.SelectCarView(carServiceObj.GetById(carId));
                        }
                        catch (Exception x)
                        {
                            Console.WriteLine(x.Message);
                        }
                        break;

                    case '4':
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }

        private void LorryView()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Lorry");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Display lorrys");
                Console.WriteLine("\t2. Add new lorry");
                Console.WriteLine("\t3. Edit a lorry");
                Console.WriteLine("\t4. Delete a lorry");
                Console.WriteLine("\t5. Simulate fuel consumption");
                Console.WriteLine("\t6. Refuel");
                Console.WriteLine("\t7. Attach/detach load");
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