using ConsoleViewLayer.LandVehicleViews;
using System;

namespace ConsoleViewLayer
{
    internal class MainConsoleView : IConsoleView
    {
        public void Load()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Vehicle DB");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Land vehicles");
                Console.WriteLine("\t2. Aquatic vehicles");
                Console.WriteLine("\t3. Air vehicles");
                Console.WriteLine("\t4. Quit program\n");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        var landView = new LandConsoleView();
                        landView.Load();
                        break;

                    case '2':
                        var aquaticView = new AquaticConsoleView();
                        aquaticView.Load();
                        break;

                    case '3':
                        var airView = new AirConsoleView();
                        airView.Load();
                        break;

                    case '4':
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input\n");
                        break;
                }
            }
        }
    }
}