using HelperClasses.Measurements;
using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.CarFormViews
{
    public partial class CalcualteFuelCarFormView : Form
    {
        private CarServices carServicesObj = new CarServices();
        private Car carToCalculate;

        public CalcualteFuelCarFormView(Car carToCalculate)
        {
            this.carToCalculate = carToCalculate;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Distance distance = new Distance();
            distance.miles = DistanceNumericUpDown.Value;
            carServicesObj.CalculateFuel(carToCalculate, distance);
            (Owner as CarFormView).fillCarList();
            Close();
        }
    }
}