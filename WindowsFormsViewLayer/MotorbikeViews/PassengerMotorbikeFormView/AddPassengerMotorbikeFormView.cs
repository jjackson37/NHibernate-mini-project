using ObjectModelLayer;
using System.Windows.Forms;
using WindowsFormsViewLayer.MotorbikeViews.PassengerMotorbikeFormView;

namespace WindowsFormsViewLayer.MotorbikeFormViews.PassengerMotorbikeFormViews
{
    public partial class AddPassengerMotorbikeFormView : Form
    {
        Motorbike motorbikeToEdit;

        public AddPassengerMotorbikeFormView(Motorbike motorbikeToEdit)
        {
            this.motorbikeToEdit = motorbikeToEdit;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, System.EventArgs e)
        {
            Passenger newPassenger = new Passenger();
            newPassenger.firstName = firstNameTextBox.Text;
            newPassenger.lastName = lastNameTextBox.Text;
            motorbikeToEdit.passengers.Add(newPassenger);
            (Owner as PassengerMotorbikeFormView).fillPassengerList();
            Close();
        }
    }
}