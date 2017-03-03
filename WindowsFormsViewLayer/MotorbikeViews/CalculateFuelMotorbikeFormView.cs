using HelperClasses.Measurements;
using ObjectModelLayer;
using ServicesLayer;
using System.Windows.Forms;

namespace WindowsFormsViewLayer.MotorbikeViews
{
    public partial class CalculateFuelMotorbikeFormView : Form
    {
        private MotorbikeServices motorbikeServicesObj = new MotorbikeServices();
        private Motorbike motorbikeToCalculate;

        public CalculateFuelMotorbikeFormView(Motorbike motorbikeToCalculate)
        {
            this.motorbikeToCalculate = motorbikeToCalculate;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, System.EventArgs e)
        {
            Distance distance = new Distance();
            distance.miles = DistanceNumericUpDown.Value;
            motorbikeServicesObj.CalculateFuel(motorbikeToCalculate, distance);
            (Owner as MotorbikeFormView).FillMotorbikeList();
            Close();
        }
    }
}