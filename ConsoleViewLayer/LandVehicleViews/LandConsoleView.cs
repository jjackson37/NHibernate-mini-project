using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Collections.Generic;

namespace ConsoleViewLayer.LandVehicleViews
{
    public class LandConsoleView : IConsoleView
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

            while (!exit)
            {
                Console.WriteLine("Car");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Display cars");
                Console.WriteLine("\t2. Search cars");
                Console.WriteLine("\t3. Add new car");
                Console.WriteLine("\t4. Select a car");
                Console.WriteLine("\t5. Back\n");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        carViewObj.List();
                        break;

                    case '2':
                        carViewObj.SearchByName();
                        break;

                    case '3':
                        carViewObj.Add();
                        break;

                    case '4':
                        carViewObj.SelectById();
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

        private void LorryView()
        {
            bool exit = false;
            LorryConsoleView lorryViewObj = new LorryConsoleView();

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
                        lorryViewObj.List();
                        break;

                    case '2':
                        lorryViewObj.SearchByName();
                        break;

                    case '3':
                        lorryViewObj.Add();
                        break;

                    case '4':
                        lorryViewObj.SelectById();
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
    }
}