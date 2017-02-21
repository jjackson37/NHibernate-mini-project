using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleViewLayer
{
    interface ISelectedConsoleView
    {
        void SelectById();
        void SelectById(Guid Id);
        void SearchByName();
        void List();
        void Add();
    }
}
