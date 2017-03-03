using HelperClasses.Measurements;
using ServicesLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.MotorbikeViews
{
    public partial class AddMotorbikeFormView : Form
    {
        public AddMotorbikeFormView()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, System.EventArgs e)
        {
            FuelEconomy milage = new FuelEconomy();
            milage.milesPerGallon = Convert.ToDecimal(milageTextBox.Text);
            Weight weight = new Weight();
            weight.kilograms = Convert.ToDecimal(weightTextBox.Text);
            Weight loadWeight = new Weight();
            Volume maxFuel = new Volume();
            maxFuel.litres = Convert.ToDecimal(maxFuelTextBox.Text);

            MotorbikeServices motorbikeServiceObj = new MotorbikeServices();
            motorbikeServiceObj.Add(
                vehicleNameTextBox.Text,
                numberPlateTextBox.Text,
                milage,
                weight,
                maxFuel,
                Convert.ToInt32(maxPassengersTextBox.Text),
                sideCarCheckBox.Checked
                );

            (Owner as MotorbikeFormView).FillMotorbikeList();
            Close();
        }
    }
}