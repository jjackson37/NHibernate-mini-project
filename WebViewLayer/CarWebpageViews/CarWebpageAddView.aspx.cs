using HelperClasses.Measurements;
using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebViewLayer.CarWebpageViews
{
    public partial class CarWebpageAddView : Page
    {
        CarServices carServicesObj = new CarServices();

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateCarTypeDropdownList();
        }

        private void PopulateCarTypeDropdownList()
        {
            Array itemValues = Enum.GetValues(typeof(Car.CarType));

            for (int i = 0; i <= itemValues.Length - 1; i++)
            {
                ListItem item = new ListItem(itemValues.GetValue(i).ToString());
                carTypeDdl.Items.Add(item);
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            Car.CarType carTypeOfNewCar = Car.CarType.Unknown;
            switch (carTypeDdl.Text)
            {
                case "Unknown":
                    carTypeOfNewCar = Car.CarType.Unknown;
                    break;
                case "Hatchback":
                    carTypeOfNewCar = Car.CarType.Hatchback;
                    break;
                case "Sedan":
                    carTypeOfNewCar = Car.CarType.Sedan;
                    break;
                case "SUV":
                    carTypeOfNewCar = Car.CarType.SUV;
                    break;
                case "Coupe":
                    carTypeOfNewCar = Car.CarType.Coupe;
                    break;
                case "Convertible":
                    carTypeOfNewCar = Car.CarType.Convertible;
                    break;
            }

            FuelEconomy milageOfNewCar = new FuelEconomy();
            milageOfNewCar.milesPerGallon = Convert.ToDecimal(milageTxtBox.Text);

            Weight weightOfNewCar = new Weight();
            weightOfNewCar.kilograms = Convert.ToDecimal(weightTxtBox.Text);

            Volume fuelCapacityOfNewCar = new Volume();
            fuelCapacityOfNewCar.litres = Convert.ToDecimal(fuelCapacityTxtBox.Text);

            carServicesObj.Add(vehicleNameTxtBox.Text, numberPlateTxtBox.Text, carTypeOfNewCar,
                milageOfNewCar, weightOfNewCar, fuelCapacityOfNewCar,
                Convert.ToInt32(passengerCapacityTxtBox.Text));

            Response.Redirect("CarWebPageView.aspx");
        }
    }
}