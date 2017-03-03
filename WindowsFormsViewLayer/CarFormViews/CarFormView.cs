using ObjectModelLayer;
using ServicesLayer;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsViewLayer.CarFormViews;
using WindowsFormsViewLayer.CarFormViews.PassengerCarFormViews;

namespace WindowsFormsViewLayer
{
    public partial class CarFormView : Form
    {
        private CarServices carServicesObj = new CarServices();

        public CarFormView()
        {
            InitializeComponent();
            FillCarList();
        }

        public void FillCarList()
        {
            IList<Car> allCars = carServicesObj.GetAll();

            carList.Items.Clear();

            foreach (var currentCar in allCars)
            {
                ListViewItem carItem = new ListViewItem(currentCar.vehicleName);
                carItem.SubItems.Add(currentCar.numberPlate);
                carItem.SubItems.Add(currentCar.carType.ToString());
                carItem.SubItems.Add(string.Format("{0} kg",
                    decimal.Round(currentCar.weight.kilograms, 2)));
                carItem.SubItems.Add(string.Format("{0}/{1} l",
                    decimal.Round(currentCar.currentFuel.litres, 2),
                    decimal.Round(currentCar.maximumFuel.litres, 2)));
                carItem.SubItems.Add(string.Format("{0} mpg",
                    decimal.Round(currentCar.milage.milesPerGallon, 2)));
                carItem.SubItems.Add(string.Format("{0}/{1}",
                    currentCar.passengers.Count,
                    currentCar.maximumPassengers));
                carList.Items.Add(carItem);
            }
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            AddCarFormView addCarFormView = new AddCarFormView();
            addCarFormView.ShowDialog(this);
        }

        private void calculateFuelButton_Click(object sender, System.EventArgs e)
        {
            CalcualteFuelCarFormView calculateFuelCarFormView = new CalcualteFuelCarFormView(GetSelectedCar());
            calculateFuelCarFormView.ShowDialog(this);
        }

        private void CarFormView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            carServicesObj.Delete(GetSelectedCar());
            FillCarList();
        }

        private void editButton_Click(object sender, System.EventArgs e)
        {
            EditCarFormView editCarFormView = new EditCarFormView(GetSelectedCar());
            editCarFormView.ShowDialog(this);
        }

        private Car GetSelectedCar()
        {
            int selectedIndex = carList.SelectedIndices[0];
            IList<Car> allCars = carServicesObj.GetAll();
            return allCars[selectedIndex];
        }

        private void refuelButton_Click(object sender, System.EventArgs e)
        {
            carServicesObj.Refuel(GetSelectedCar());
            FillCarList();
        }

        private void refreshButton_Click(object sender, System.EventArgs e)
        {
            FillCarList();
        }

        private void passengerButton_Click(object sender, System.EventArgs e)
        {
            PassengerCarFormView passengerCarFormView = new PassengerCarFormView(GetSelectedCar());
            passengerCarFormView.ShowDialog(this);
        }
    }
}