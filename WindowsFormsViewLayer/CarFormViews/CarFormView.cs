using ObjectModelLayer;
using ServicesLayer;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsViewLayer.CarFormViews;

namespace WindowsFormsViewLayer
{
    public partial class CarFormView : Form
    {
        CarServices carServicesObj = new CarServices();
        private bool quitProgramOnClose;

        public CarFormView()
        {
            quitProgramOnClose = true;
            InitializeComponent();
            fillCarList();
        }

        private void CarFormView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (quitProgramOnClose)
            {
                Application.Exit();
            }
        }

        private void fillCarList()
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
                carItem.SubItems.Add(decimal.Round(currentCar.milage.milesPerGallon, 2).ToString());
                carItem.SubItems.Add(string.Format("{0}/{1}",
                    currentCar.passengers.Count,
                    currentCar.maximumPassengers));
                carList.Items.Add(carItem);
            }
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            quitProgramOnClose = false;
            Close();
            MainFormView mainFormView = new MainFormView();
            mainFormView.Show();
        }

        private void refuelButton_Click(object sender, System.EventArgs e)
        {
            carServicesObj.Refuel(getSelectedCar());
            fillCarList();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            carServicesObj.Delete(getSelectedCar());
            fillCarList();
        }

        private Car getSelectedCar()
        {
            int selectedIndex = carList.SelectedIndices[0];
            IList<Car> allCars = carServicesObj.GetAll();
            return allCars[selectedIndex];
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            quitProgramOnClose = false;
            Close();
            AddCarFormView addCarFormView = new AddCarFormView();
            addCarFormView.Show();
        }
    }
}
