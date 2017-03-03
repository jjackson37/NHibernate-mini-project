using ObjectModelLayer;
using ServicesLayer;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsViewLayer.LorryFormViews;
using WindowsFormsViewLayer.LorryFormViews.PassengerLorryFormViews;

namespace WindowsFormsViewLayer
{
    public partial class LorryFormView : Form
    {
        private LorryServices lorryServicesObj = new LorryServices();

        public void FillLorryList()
        {
            IList<Lorry> allLorrys = lorryServicesObj.GetAll();

            lorryList.Items.Clear();

            foreach (var item in allLorrys)
            {
                ListViewItem lorryItem = new ListViewItem(item.vehicleName);
                lorryItem.SubItems.Add(item.numberPlate);
                lorryItem.SubItems.Add(string.Format("{0} kg",
                    decimal.Round(item.weight.kilograms, 2)));
                lorryItem.SubItems.Add(string.Format("{0}/{1} l",
                    decimal.Round(item.currentFuel.litres, 2),
                    decimal.Round(item.maximumFuel.litres, 2)));
                lorryItem.SubItems.Add(string.Format("{0} mpg",
                    decimal.Round(item.milage.milesPerGallon, 2)));
                lorryItem.SubItems.Add(string.Format("{0}/{1}",
                    item.passengers.Count,
                    item.maximumPassengers));
                lorryItem.SubItems.Add((item.hasLoad)?"True":"False");
                if (item.hasLoad) { lorryItem.SubItems.Add(
                    string.Format("{0} kg",
                    decimal.Round(item.loadWeight.kilograms, 2))); }
                lorryList.Items.Add(lorryItem);
            }
        }

        private Lorry GetSelectedLorry()
        {
            int selectedIndex = lorryList.SelectedIndices[0];
            IList<Lorry> allLorrys = lorryServicesObj.GetAll();
            return allLorrys[selectedIndex];
        }

        public LorryFormView()
        {
            InitializeComponent();
            FillLorryList();
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            AddLorryFormView addLorryFormView = new AddLorryFormView();
            addLorryFormView.Show(this);
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            lorryServicesObj.Delete(GetSelectedLorry());
            FillLorryList();
        }

        private void editButton_Click(object sender, System.EventArgs e)
        {
            EditLorryFormView editLorryFormView = new EditLorryFormView(GetSelectedLorry());
            editLorryFormView.ShowDialog(this);
        }

        private void passengerButton_Click(object sender, System.EventArgs e)
        {
            PassengerLorryFormView passengerLorryFormView = new PassengerLorryFormView(GetSelectedLorry());
            passengerLorryFormView.ShowDialog(this);
        }

        private void calculateFuelButton_Click(object sender, System.EventArgs e)
        {
            CalculateFuelLorryFormView calculateFuelLorryFormView = new CalculateFuelLorryFormView(GetSelectedLorry());
            calculateFuelLorryFormView.ShowDialog(this);
        }

        private void refuelButton_Click(object sender, System.EventArgs e)
        {
            lorryServicesObj.Refuel(GetSelectedLorry());
            FillLorryList();
        }

        private void refreshButton_Click(object sender, System.EventArgs e)
        {
            FillLorryList();
        }

        private void LorryFormView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}