using HelperClasses.Measurements;
using ServicesLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.LorryFormViews
{
    public partial class AddLorryFormView : Form
    {
        public AddLorryFormView()
        {
            InitializeComponent();
        }

        private void loadCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            loadWeightTextBox.Enabled = loadCheckBox.Checked;
            loadWeightLabel.Enabled = loadCheckBox.Checked;
        }

        private void submitButton_Click(object sender, System.EventArgs e)
        {
            FuelEconomy milage = new FuelEconomy();
            milage.milesPerGallon = Convert.ToDecimal(milageTextBox.Text);
            Weight weight = new Weight();
            weight.kilograms = Convert.ToDecimal(weightTextBox.Text);
            Weight loadWeight = new Weight();
            if (loadCheckBox.Checked)
            {
                loadWeight.kilograms = Convert.ToDecimal(loadWeightTextBox.Text);
            }
            Volume maxFuel = new Volume();
            maxFuel.litres = Convert.ToDecimal(maxFuelTextBox.Text);

            LorryServices lorryServiceObj = new LorryServices();
            lorryServiceObj.Add(
                vehicleNameTextBox.Text,
                numberPlateTextBox.Text,
                milage,
                weight,
                loadCheckBox.Checked,
                loadWeight,
                maxFuel,
                Convert.ToInt32(maxPassengersTextBox.Text)
                );

            (Owner as LorryFormView).FillLorryList();
            Close();
        }
    }
}