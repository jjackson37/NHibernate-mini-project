using System;

namespace ConsoleViewLayer
{
    class ConsoleViewMain : IView
    {
        public void LoadView()
        {
            bool exit = false;

            Console.WriteLine("Vehicle DB\n");
            Console.WriteLine("Choose an option:\n");
            Console.WriteLine("1. Land vehicles");
            Console.WriteLine("2. Aquatic vehicles");
            Console.WriteLine("3. Air vehicles");
            Console.WriteLine("4. Quit program\n");

            while (!exit)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        var landView = new ConsoleViewLand();
                        break;
                    case '2':
                        var aquaticView = new ConsoleViewAquatic();
                        break;
                    case '3':
                        var airView = new ConsoleViewAir();
                        break;
                    case '4':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
