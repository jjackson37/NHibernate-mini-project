using HelperClasses.Measurements;
using ObjectModelLayer;
using ServicesLayer;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.LorryFormViews
{
    public partial class CalculateFuelLorryFormView : Form
    {
        private LorryServices lorryServicesObj = new LorryServices();
        private Lorry lorryToCalculate;

        public CalculateFuelLorryFormView(Lorry lorryToCalculate)
        {
            this.lorryToCalculate = lorryToCalculate;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, System.EventArgs e)
        {
            Distance distance = new Distance();
            distance.miles = DistanceNumericUpDown.Value;
            lorryServicesObj.CalculateFuel(lorryToCalculate, distance);
            (Owner as LorryFormView).FillLorryList();
            Close();
        }
    }
}