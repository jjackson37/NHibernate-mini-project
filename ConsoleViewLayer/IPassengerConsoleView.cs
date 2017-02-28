using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleViewLayer
{
    interface IPassengerConsoleView : IConsoleView
    {
        void List();
        void Add();
        void Delete();
    }
}
