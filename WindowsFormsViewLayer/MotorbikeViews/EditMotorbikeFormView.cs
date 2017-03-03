using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.MotorbikeViews
{
    public partial class EditMotorbikeFormView : Form
    {
        private MotorbikeServices motorbikeServicesObj = new MotorbikeServices();
        private Motorbike motorbikeToEdit;

        public EditMotorbikeFormView(Motorbike motorbikeToEdit)
        {
            this.motorbikeToEdit = motorbikeToEdit;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, System.EventArgs e)
        {
            motorbikeToEdit.vehicleName = vehicleNameTextBox.Text;
            motorbikeToEdit.numberPlate = numberPlateTextBox.Text;
            motorbikeToEdit.weight.kilograms = Convert.ToDecimal(weightTextBox.Text);
            motorbikeToEdit.sideCar = sideCarCheckBox.Checked;
            motorbikeToEdit.maximumPassengers = Convert.ToInt32(maxPassengersTextBox.Text);
            motorbikeToEdit.maximumFuel.litres = Convert.ToDecimal(maxFuelTextBox.Text);
            motorbikeToEdit.milage.milesPerGallon = Convert.ToDecimal(milageTextBox.Text);

            motorbikeServicesObj.Update(motorbikeToEdit);
            Close();
            (Owner as MotorbikeFormView).FillMotorbikeList();
        }

        private void EditMotorbikeFormView_Load(object sender, System.EventArgs e)
        {
            vehicleNameTextBox.Text = motorbikeToEdit.vehicleName;
            numberPlateTextBox.Text = motorbikeToEdit.numberPlate;
            weightTextBox.Text = motorbikeToEdit.weight.kilograms.ToString();
            sideCarCheckBox.Checked = motorbikeToEdit.sideCar;
            maxPassengersTextBox.Text = motorbikeToEdit.maximumPassengers.ToString();
            maxFuelTextBox.Text = motorbikeToEdit.maximumFuel.litres.ToString();
            milageTextBox.Text = motorbikeToEdit.milage.milesPerGallon.ToString();
        }
    }
}