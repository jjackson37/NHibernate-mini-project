using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Linq;

namespace ConsoleViewLayer
{
    internal class MotorbikePassengerConsoleView : IPassengerConsoleView
    {
        private Motorbike selectedMotorbike;
        private MotorbikeServices motorbikeServiceObj = new MotorbikeServices();

        public MotorbikePassengerConsoleView(Motorbike selectedMotorbike)
        {
            this.selectedMotorbike = selectedMotorbike;
        }

        public void Add()
        {
            if (selectedMotorbike.passengers.Count != selectedMotorbike.maximumPassengers)
            {
                Passenger passengerToAdd = new Passenger();
                Console.WriteLine("Add passenger");
                Console.Write("First name: ");
                passengerToAdd.firstName = Console.ReadLine();
                Console.Write("Last name: ");
                passengerToAdd.lastName = Console.ReadLine();
                selectedMotorbike.passengers.Add(passengerToAdd);
                selectedMotorbike = motorbikeServiceObj.Update(selectedMotorbike);
            }
            else
            {
                Console.WriteLine("This vehicle is full");
            }
        }

        public void Delete()
        {
            Console.WriteLine("Delete passenger");
            Console.Write("Id: ");
            Guid motorbikeId = Guid.Parse(Console.ReadLine());
            Passenger passengerToDelete = selectedMotorbike.passengers.SingleOrDefault(x => x.Id == motorbikeId);
            selectedMotorbike.passengers.Remove(passengerToDelete);
            selectedMotorbike = motorbikeServiceObj.Update(selectedMotorbike);
        }

        public void List()
        {
            foreach (Passenger currentPassenger in selectedMotorbike.passengers)
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