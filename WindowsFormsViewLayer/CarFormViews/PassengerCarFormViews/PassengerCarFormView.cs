using ObjectModelLayer;
using ServicesLayer;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.CarFormViews.PassengerCarFormViews
{
    public partial class PassengerCarFormView : Form
    {
        Car carToEdit;
        CarServices carServicesObj = new CarServices();

        public PassengerCarFormView(Car carToEdit)
        {
            this.carToEdit = carToEdit;
            InitializeComponent();
            fillPassengerList();
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            AddPassengerCarFormView addPassengerCarFormView = new AddPassengerCarFormView(carToEdit);
            addPassengerCarFormView.ShowDialog(this);
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            carToEdit.passengers.Remove(getSelectedPassenger());
            fillPassengerList();
        }

        private void refreshButton_Click(object sender, System.EventArgs e)
        {
            fillPassengerList();
        }

        public void fillPassengerList()
        {
            passengersListView.Items.Clear();
            foreach (var item in carToEdit.passengers)
            {
                ListViewItem passengerItem = new ListViewItem(item.firstName);
                passengerItem.SubItems.Add(item.lastName);
                passengersListView.Items.Add(passengerItem);
            }
            checkMaxPassengerCount();
        }

        private void checkMaxPassengerCount()
        {
            addButton.Enabled = !(carToEdit.passengers.Count >= carToEdit.maximumPassengers);
        }

        private void PassengerCarFormView_FormClosed(object sender, FormClosedEventArgs e)
        {
            carServicesObj.Update(carToEdit);
            (Owner as CarFormView).FillCarList();
        }

        private Passenger getSelectedPassenger()
        {
            int selectedIndex = passengersListView.SelectedIndices[0];
            return carToEdit.passengers[0];
        }
    }
}