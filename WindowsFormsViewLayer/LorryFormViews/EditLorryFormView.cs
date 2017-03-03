using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.LorryFormViews
{
    public partial class EditLorryFormView : Form
    {
        private LorryServices lorryServiceObj = new LorryServices();
        private Lorry lorryToEdit;

        public EditLorryFormView(Lorry lorryToEdit)
        {
            this.lorryToEdit = lorryToEdit;
            InitializeComponent();
        }

        private void EditLorryFormView_Load(object sender, EventArgs e)
        {
            vehicleNameTextBox.Text = lorryToEdit.vehicleName;
            numberPlateTextBox.Text = lorryToEdit.numberPlate;
            weightTextBox.Text = lorryToEdit.weight.kilograms.ToString();
            loadCheckBox.Checked = lorryToEdit.hasLoad;
            loadWeightTextBox.Text = lorryToEdit.weight.kilograms.ToString();
            maxPassengersTextBox.Text = lorryToEdit.maximumPassengers.ToString();
            maxFuelTextBox.Text = lorryToEdit.maximumFuel.litres.ToString();
            milageTextBox.Text = lorryToEdit.milage.milesPerGallon.ToString();
        }

        private void loadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            loadWeightLabel.Enabled = loadCheckBox.Checked;
            loadWeightTextBox.Enabled = loadCheckBox.Checked;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            lorryToEdit.vehicleName = vehicleNameTextBox.Text;
            lorryToEdit.numberPlate = numberPlateTextBox.Text;
            lorryToEdit.weight.kilograms = Convert.ToDecimal(weightTextBox.Text);
            lorryToEdit.hasLoad = loadCheckBox.Checked;
            lorryToEdit.weight.kilograms = Convert.ToDecimal(loadWeightTextBox.Text);
            lorryToEdit.maximumPassengers = Convert.ToInt32(maxPassengersTextBox.Text);
            lorryToEdit.maximumFuel.litres = Convert.ToDecimal(maxFuelTextBox.Text);
            lorryToEdit.milage.milesPerGallon = Convert.ToDecimal(milageTextBox.Text);

            lorryServiceObj.Update(lorryToEdit);
            Close();
            (Owner as LorryFormView).FillLorryList();
        }
    }
}