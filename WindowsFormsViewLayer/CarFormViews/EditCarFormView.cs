using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.CarFormViews
{
    public partial class EditCarFormView : Form
    {
        private CarServices carServicesObj = new CarServices();
        private Car carToEdit;

        public EditCarFormView(Car carToEdit)
        {
            this.carToEdit = carToEdit;
            InitializeComponent();
        }

        private void EditCarFormView_Load(object sender, EventArgs e)
        {
            vehicleNameTextBox.Text = carToEdit.vehicleName;
            numberPlateTextBox.Text = carToEdit.numberPlate;
            carTypeComboBox.Text = carToEdit.carType.ToString();
            weightTextBox.Text = decimal.Round(carToEdit.weight.kilograms, 2).ToString();
            maxPassengersTextBox.Text = carToEdit.maximumPassengers.ToString();
            maxFuelTextBox.Text = decimal.Round(carToEdit.maximumFuel.litres, 2).ToString();
            milageTextBox.Text = decimal.Round(carToEdit.milage.milesPerGallon, 2).ToString();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            carToEdit.vehicleName = vehicleNameTextBox.Text;
            carToEdit.milage.milesPerGallon = Convert.ToDecimal(milageTextBox.Text);
            carToEdit.weight.kilograms = Convert.ToDecimal(weightTextBox.Text);
            carToEdit.maximumFuel.litres = Convert.ToDecimal(maxFuelTextBox.Text);
            carToEdit.currentFuel.litres = carToEdit.maximumFuel.litres;
            switch (carTypeComboBox.Text)
            {
                case "Convertible":
                    carToEdit.carType = Car.CarType.Convertible;
                    break;

                case "Coupe":
                    carToEdit.carType = Car.CarType.Coupe;
                    break;

                case "Hatchback":
                    carToEdit.carType = Car.CarType.Hatchback;
                    break;

                case "Sedan":
                    carToEdit.carType = Car.CarType.Sedan;
                    break;

                case "SUV":
                    carToEdit.carType = Car.CarType.SUV;
                    break;
            }
            if (Convert.ToInt32(maxPassengersTextBox.Text) >= carToEdit.passengers.Count)
            {
                carToEdit.maximumPassengers = Convert.ToInt32(maxPassengersTextBox.Text);
            }
            carServicesObj.Update(carToEdit);
            (Owner as CarFormView).FillCarList();
            Close();
        }
    }
}