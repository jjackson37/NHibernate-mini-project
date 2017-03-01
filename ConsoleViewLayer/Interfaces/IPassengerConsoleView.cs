namespace ConsoleViewLayer
{
    internal interface IPassengerConsoleView : IConsoleView
    {
        void List();

        void Add();

        void Delete();
    }
}