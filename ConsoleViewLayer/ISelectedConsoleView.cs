using System;

namespace ConsoleViewLayer
{
    internal interface ISelectedConsoleView : IConsoleView
    {
        void SelectById();

        void SelectById(Guid Id);

        void SearchByName();

        void List();

        void Add();
    }
}