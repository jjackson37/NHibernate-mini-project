using System;

namespace ConsoleViewLayer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mainView = new ConsoleViewMain();
            mainView.LoadView();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}