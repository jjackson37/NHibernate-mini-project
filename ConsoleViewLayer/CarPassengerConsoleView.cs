using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleViewLayer
{
    class CarPassengerConsoleView : IPassengerConsoleView
    {
        private Car selectedCar;
        private CarServices carServiceObj = new CarServices();

        public CarPassengerConsoleView(Car selectedCar)
        {
            this.selectedCar = selectedCar;
        }

        public void Add()
        {
            Passenger passengerToAdd = new Passenger();
            Console.WriteLine("Add passenger");
            Console.Write("First name: ");
            passengerToAdd.firstName = Console.ReadLine();
            Console.Write("Last name: ");
            passengerToAdd.lastName = Console.ReadLine();
            selectedCar.passengers.Add(passengerToAdd);
            selectedCar = carServiceObj.Update(selectedCar);
        }

        public void Delete()
        {
            Console.WriteLine("Delete passenger");
            Console.Write("Id: ");
            Guid carId = Guid.Parse(Console.ReadLine());
            Passenger passengerToDelete = selectedCar.passengers.SingleOrDefault(x => x.Id == carId);
            selectedCar.passengers.Remove(passengerToDelete);
            selectedCar = carServiceObj.Update(selectedCar);
        }

        public void List()
        {
            foreach (Passenger currentPassenger in selectedCar.passengers)
            {
                Console.WriteLine("Id: " + currentPassenger.Id);
                Console.WriteLine(@"First name: ""{0}"" Last name: ""{1}""", currentPassenger.firstName, currentPassenger.lastName);
                Console.WriteLine();
            }
        }

        public void Load()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Passengers");
                Console.WriteLine("Choose an option:\n");
                Console.WriteLine("\t1. Display passengers");
                Console.WriteLine("\t2. Add new passenger");
                Console.WriteLine("\t3. Delete a passenger");
                Console.WriteLine("\t4. Back\n");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        List();
                        break;

                    case '2':
                        Add();
                        break;

                    case '3':
                        Delete();
                        break;

                    case '4':
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
