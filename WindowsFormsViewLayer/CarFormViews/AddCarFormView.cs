using HelperClasses.Measurements;
using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.CarFormViews
{
    public partial class AddCarFormView : Form
    {
        private CarServices carServicesObj = new CarServices();

        public AddCarFormView()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            FuelEconomy milage = new FuelEconomy();
            milage.milesPerGallon = Convert.ToDecimal(milageTextBox.Text);

            Weight weight = new Weight();
            weight.kilograms = Convert.ToDecimal(weightTextBox.Text);

            Volume fuel = new Volume();
            fuel.litres = Convert.ToDecimal(maxFuelTextBox.Text);

            Car.CarType carType = new Car.CarType();
            carType = Car.CarType.Unknown;

            switch (carTypeComboBox.Text)
            {
                case "Convertible":
                    carType = Car.CarType.Convertible;
                    break;

                case "Coupe":
                    carType = Car.CarType.Coupe;
                    break;

                case "Hatchback":
                    carType = Car.CarType.Hatchback;
                    break;

                case "Sedan":
                    carType = Car.CarType.Sedan;
                    break;

                case "SUV":
                    carType = Car.CarType.SUV;
                    break;
            }

            carServicesObj.Add(
                vehicleNameTextBox.Text,
                numberPlateTextBox.Text,
                carType,
                milage,
                weight,
                fuel,
                Convert.ToInt32(maxPassengersTextBox.Text)
                );

            (Owner as CarFormView).fillCarList();
            Close();
        }
    }
}