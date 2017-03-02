using ObjectModelLayer;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.CarFormViews.PassengerCarFormViews
{
    public partial class AddPassengerCarFormView : Form
    {
        Car carToEdit;

        public AddPassengerCarFormView(Car carToEdit)
        {
            this.carToEdit = carToEdit;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, System.EventArgs e)
        {
            Passenger newPassenger = new Passenger();
            newPassenger.firstName = firstNameTextBox.Text;
            newPassenger.lastName = lastNameTextBox.Text;
            carToEdit.passengers.Add(newPassenger);
            (Owner as PassengerCarFormView).fillPassengerList();
            Close();
        }
    }
}