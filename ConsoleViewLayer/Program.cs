using HelperClasses.Measurements;
using System;

namespace ConsoleViewLayer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mainView = new MainConsoleView();
            mainView.Load();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}