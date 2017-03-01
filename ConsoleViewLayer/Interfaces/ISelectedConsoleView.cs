using System;

namespace ConsoleViewLayer
{
    internal interface ISelectedConsoleView : IConsoleView
    {
        void Add();

        void List();

        void SearchByName();

        void SelectById();

        void SelectById(Guid Id);
    }
}