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
                Console.WriteLine("\t1. Car");
                Console.WriteLine("\t2. Lorry");
                Console.WriteLine("\t3. Motorbike");
                Console.WriteLine("\t4. Quit program\n");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        var carView = new CarConsoleView();
                        carView.Load();
                        break;

                    case '2':
                        var lorryView = new LorryConsoleView();
                        lorryView.Load();
                        break;

                    case '3':
                        var motorbikeView = new MotorbikeConsoleView();
                        motorbikeView.Load();
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