using ObjectModelLayer;
using ServicesLayer;
using System.Windows.Forms;
using WindowsFormsViewLayer.MotorbikeFormViews.PassengerMotorbikeFormViews;

namespace WindowsFormsViewLayer.MotorbikeViews.PassengerMotorbikeFormView
{
    public partial class PassengerMotorbikeFormView : Form
    {
        Motorbike motorbikeToEdit;
        MotorbikeServices motorbikeServicesObj = new MotorbikeServices();

        public PassengerMotorbikeFormView(Motorbike motorbikeToEdit)
        {
            this.motorbikeToEdit = motorbikeToEdit;
            InitializeComponent();
        }

        public void fillPassengerList()
        {
            passengersListView.Items.Clear();
            foreach (var item in motorbikeToEdit.passengers)
            {
                ListViewItem passengerItem = new ListViewItem(item.firstName);
                passengerItem.SubItems.Add(item.lastName);
                passengersListView.Items.Add(passengerItem);
            }
            checkMaxPassengerCount();
        }

        private void checkMaxPassengerCount()
        {
            addButton.Enabled = !(motorbikeToEdit.passengers.Count >= motorbikeToEdit.maximumPassengers);
        }

        private void refreshButton_Click(object sender, System.EventArgs e)
        {
            fillPassengerList();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            motorbikeToEdit.passengers.Remove(getSelectedPassenger());
            fillPassengerList();
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            AddPassengerMotorbikeFormView addPassengerMotorbikeFormView = new AddPassengerMotorbikeFormView(motorbikeToEdit);
            addPassengerMotorbikeFormView.ShowDialog(this);
        }

        private void PassengerMotorbikeFormView_FormClosed(object sender, FormClosedEventArgs e)
        {
            motorbikeServicesObj.Update(motorbikeToEdit);
            (Owner as MotorbikeFormView).FillMotorbikeList();
        }

        private Passenger getSelectedPassenger()
        {
            int selectedIndex = passengersListView.SelectedIndices[0];
            return motorbikeToEdit.passengers[0];
        }

        private void PassengerMotorbikeFormView_Load(object sender, System.EventArgs e)
        {
            fillPassengerList();
        }
    }
}