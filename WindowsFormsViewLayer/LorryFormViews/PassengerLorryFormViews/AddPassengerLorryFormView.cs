using ObjectModelLayer;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.LorryFormViews.PassengerLorryFormViews
{
    public partial class AddPassengerLorryFormView : Form
    {
        Lorry lorryToEdit;

        public AddPassengerLorryFormView(Lorry lorryToEdit)
        {
            this.lorryToEdit = lorryToEdit;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, System.EventArgs e)
        {
            Passenger newPassenger = new Passenger();
            newPassenger.firstName = firstNameTextBox.Text;
            newPassenger.lastName = lastNameTextBox.Text;
            lorryToEdit.passengers.Add(newPassenger);
            (Owner as PassengerLorryFormView).fillPassengerList();
            Close();
        }
    }
}