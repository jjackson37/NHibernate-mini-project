using ObjectModelLayer;
using ServicesLayer;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsViewLayer.MotorbikeViews;
using WindowsFormsViewLayer.MotorbikeViews.PassengerMotorbikeFormView;

namespace WindowsFormsViewLayer
{
    public partial class MotorbikeFormView : Form
    {
        private MotorbikeServices motorbikeServicesObj = new MotorbikeServices();

        public MotorbikeFormView()
        {
            InitializeComponent();
            FillMotorbikeList();
        }

        public void FillMotorbikeList()
        {
            IList<Motorbike> allMotorbikes = motorbikeServicesObj.GetAll();

            motorbikeList.Items.Clear();

            foreach (var currentMotorbike in allMotorbikes)
            {
                ListViewItem motorbikeItem = new ListViewItem(currentMotorbike.vehicleName);
                motorbikeItem.SubItems.Add(currentMotorbike.numberPlate);
                motorbikeItem.SubItems.Add(string.Format("{0} kg",
                    decimal.Round(currentMotorbike.weight.kilograms, 2)));
                motorbikeItem.SubItems.Add(string.Format("{0}/{1} l",
                    decimal.Round(currentMotorbike.currentFuel.litres, 2),
                    decimal.Round(currentMotorbike.maximumFuel.litres, 2)));
                motorbikeItem.SubItems.Add(string.Format("{0} mpg",
                    decimal.Round(currentMotorbike.milage.milesPerGallon, 2)));
                motorbikeItem.SubItems.Add(string.Format("{0}/{1}",
                    currentMotorbike.passengers.Count,
                    currentMotorbike.maximumPassengers));
                motorbikeItem.SubItems.Add((currentMotorbike.sideCar) ? "True" : "False");
                motorbikeList.Items.Add(motorbikeItem);
            }
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            AddMotorbikeFormView addMotorbikeFormView = new AddMotorbikeFormView();
            addMotorbikeFormView.ShowDialog(this);
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            motorbikeServicesObj.Delete(GetSelectedMotorbike());
            FillMotorbikeList();
        }

        private void editButton_Click(object sender, System.EventArgs e)
        {
            EditMotorbikeFormView editMotorbikeFormView = new EditMotorbikeFormView(GetSelectedMotorbike());
            editMotorbikeFormView.ShowDialog(this);
        }

        private void passengerButton_Click(object sender, System.EventArgs e)
        {
            PassengerMotorbikeFormView passengerMotorbikeFormView = new PassengerMotorbikeFormView(GetSelectedMotorbike());
            passengerMotorbikeFormView.ShowDialog(this);
        }

        private void calculateFuelButton_Click(object sender, System.EventArgs e)
        {
            CalculateFuelMotorbikeFormView calculateFuelMotorbikeFormView = new CalculateFuelMotorbikeFormView(GetSelectedMotorbike());
            calculateFuelMotorbikeFormView.ShowDialog(this);
        }

        private void refuelButton_Click(object sender, System.EventArgs e)
        {
            motorbikeServicesObj.Refuel(GetSelectedMotorbike());
            FillMotorbikeList();
        }

        private void refreshButton_Click(object sender, System.EventArgs e)
        {
            FillMotorbikeList();
        }

        private void MotorbikeFormView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private Motorbike GetSelectedMotorbike()
        {
            int selectedIndex = motorbikeList.SelectedIndices[0];
            IList<Motorbike> allMotorbikes = motorbikeServicesObj.GetAll();
            return allMotorbikes[selectedIndex];
        }
    }
}