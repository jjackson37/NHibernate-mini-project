using ObjectModelLayer;
using ServicesLayer;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.LorryFormViews.PassengerLorryFormViews
{
    public partial class PassengerLorryFormView : Form
    {
        Lorry lorryToEdit;
        LorryServices lorryServicesObj = new LorryServices();

        public PassengerLorryFormView(Lorry lorryToEdit)
        {
            this.lorryToEdit = lorryToEdit;
            InitializeComponent();
        }

        public void fillPassengerList()
        {
            passengersListView.Items.Clear();
            foreach (var item in lorryToEdit.passengers)
            {
                ListViewItem passengerItem = new ListViewItem(item.firstName);
                passengerItem.SubItems.Add(item.lastName);
                passengersListView.Items.Add(passengerItem);
            }
            checkMaxPassengerCount();
        }

        private void checkMaxPassengerCount()
        {
            addButton.Enabled = !(lorryToEdit.passengers.Count >= lorryToEdit.maximumPassengers);
        }

        private void refreshButton_Click(object sender, System.EventArgs e)
        {
            fillPassengerList();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            lorryToEdit.passengers.Remove(getSelectedPassenger());
            fillPassengerList();
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            AddPassengerLorryFormView addPassengerLorryFormView = new AddPassengerLorryFormView(lorryToEdit);
            addPassengerLorryFormView.ShowDialog(this);
        }

        private void PassengerLorryFormView_FormClosed(object sender, FormClosedEventArgs e)
        {
            lorryServicesObj.Update(lorryToEdit);
            (Owner as LorryFormView).FillLorryList();
        }

        private Passenger getSelectedPassenger()
        {
            int selectedIndex = passengersListView.SelectedIndices[0];
            return lorryToEdit.passengers[0];
        }
    }
}