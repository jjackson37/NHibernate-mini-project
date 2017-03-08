using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebViewLayer.CarWebpageViews
{
    public partial class CarEditWebpageView : Page
    {
        CarServices carServicesObj = new CarServices();
        Car carToEdit = new Car();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submitEditBtn_Click(object sender, EventArgs e)
        {
            carToEdit = carServicesObj.GetById(Guid.Parse(idTxtBox.Text));
            carToEdit.vehicleName = vehicleNameTxtBox.Text;
            carToEdit.numberPlate = numberPlateTxtBox.Text;
            switch (carTypeDdl.Text)
            {
                case "Unknown":
                    carToEdit.carType = Car.CarType.Unknown;
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
                case "Coupe":
                    carToEdit.carType = Car.CarType.Coupe;
                    break;
                case "Convertible":
                    carToEdit.carType = Car.CarType.Convertible;
                    break;
            }
            carToEdit.weight.kilograms = Convert.ToDecimal(weightTxtBox.Text);
            carToEdit.maximumFuel.litres = Convert.ToDecimal(fuelCapacityTxtBox.Text);
            carToEdit.milage.milesPerGallon = Convert.ToDecimal(milageTxtBox.Text);
            carToEdit.maximumPassengers = Convert.ToInt32(passengerCapacityTxtBox.Text);

            carServicesObj.Update(carToEdit);
            Response.Redirect("CarWebPageView.aspx");
        }

        protected void submitLoadCarBtn_Click(object sender, EventArgs e)
        {
            PopulateCarTypeDropdownList();

            carToEdit = carServicesObj.GetById(Guid.Parse(idTxtBox.Text));
            vehicleNameTxtBox.Text = carToEdit.vehicleName;
            numberPlateTxtBox.Text = carToEdit.numberPlate;
            carTypeDdl.SelectedValue = carToEdit.carType.ToString();
            weightTxtBox.Text = carToEdit.weight.kilograms.ToString();
            fuelCapacityTxtBox.Text = carToEdit.maximumFuel.litres.ToString();
            milageTxtBox.Text = carToEdit.milage.milesPerGallon.ToString();
            passengerCapacityTxtBox.Text = carToEdit.maximumPassengers.ToString();

            idEntryPanel.Visible = false;
            editFormPanel.Visible = true;
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
    }
}